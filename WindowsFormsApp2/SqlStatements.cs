using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    class SqlStatements

    {

        public const  string ConnectionString = "user id=sa;" +
                               "password=Dodid1;Network Address=192.168.0.150\\sqlexpress;" +
                               "Trusted_Connection=no;" +
                               "database=order_database; " +
                               "connection timeout=30";

        public const string ConnectionStringUser = "user id=sa;" +
                               "password=Dodid1;Network Address=192.168.0.150\\sqlexpress;" +
                               "Trusted_Connection=no;" +
                               "database=user_info; " +
                               "connection timeout=30";


        DateTime time = DateTime.Now;
        string format = "yyyy-MM-dd HH:mm:ss";
      


        public void timeStamp100()
        {
            var UpdateDate = DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000");

            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand readcmd = new SqlCommand();
            readcmd.Connection = conn;
            readcmd.CommandText = "SELECT time_100_percent_paint, actual_hours, goal_hours from dbo.daily_department_goal WHERE date_goal = @date";
            readcmd.Parameters.AddWithValue("@date", UpdateDate);

            SqlDataReader rdr = readcmd.ExecuteReader();

            while (rdr.Read())
            {
                if (string.IsNullOrWhiteSpace(rdr["time_100_percent_paint"].ToString()))
                {
                    if ((Convert.ToDouble(rdr["actual_hours"]) / Convert.ToDouble(rdr["goal_hours"])) >= 1)
                    {

                        SqlCommand writecmd = new SqlCommand();
                        writecmd.Connection = conn;
                        writecmd.CommandText = "UPDATE dbo.daily_department_goal SET time_100_percent_paint = @now WHERE date_goal = @date";
                        writecmd.Parameters.AddWithValue("@now", DateTime.Now);
                        writecmd.Parameters.AddWithValue("@date", UpdateDate);
                    }
                }
            }

            conn.Close();

        }


        public void UpdatePaintStock(int stockCode, float deductionAmount)
        {
            var UpdateStock = string.Format("UPDATE dbo.stock SET amount_in_stock = amount_in_stock - @paint_kg_used WHERE stock_code = @paint_id; ");
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();
            SqlCommand commandStock = new SqlCommand(UpdateStock, myConnection);
            commandStock.Parameters.AddWithValue("@paint_id", stockCode);
            commandStock.Parameters.AddWithValue("@paint_kg_used", deductionAmount);
            commandStock.ExecuteNonQuery();
        }
        public void UpdateDoor(int door_id, float time_remaining,string op_short,int staff_no1, int staff_no2, int staff_no3)
        {

                TimeSplit ts = new TimeSplit();

                SqlConnection myConnection = new SqlConnection(ConnectionString);
                myConnection.Open();

                string sb;
                string sb1;

                if (op_short == "up")
                {
                    sb = string.Format("UPDATE dbo.door SET up_complete_paint = -1 WHERE id={0}" ,door_id);
                    SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
                    myCommand.ExecuteNonQuery();
                }
  

                if (op_short == "oven")
                    {
                        sb1 = string.Format("UPDATE dbo.door SET {2}_complete_by_id = " + staff_no1 + ",{2}_complete_by_id2 = " + staff_no2 + ",{2}_complete_by_id3 = " + staff_no3 + ", {2}_complete_date2 ='" + time.ToString(format) + "', time_remaining_paint = time_remaining_paint - {0} WHERE id={1}", time_remaining, door_id, op_short);
                    }
                    else
                    {
                         sb1 = string.Format("UPDATE dbo.door SET {2}_complete_by_id = " + staff_no1 + ",{2}_complete_by_id2 = " + staff_no2 + ",{2}_complete_by_id3 = " + staff_no3 + ", {2}_complete_date ='" + time.ToString(format) + "', time_remaining_paint = time_remaining_paint - {0} WHERE id={1}", time_remaining, door_id, op_short);
                    }
                    SqlCommand myCommand1 = new SqlCommand(sb1.ToString(), myConnection);
                    myCommand1.ExecuteNonQuery();
       
        }

        public void SaveNote(int doorId, string paintingNote)
        {
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();
            string sb;
            sb = string.Format("UPDATE dbo.door set painting_note = @paintingNote , note_amended_painting = @now WHERE id = @id;");
            SqlCommand sqlCmd = new SqlCommand(sb, myConnection);
            sqlCmd.Parameters.AddWithValue("@paintingNote", paintingNote);
            sqlCmd.Parameters.AddWithValue("@now", DateTime.Now);
            sqlCmd.Parameters.AddWithValue("@id", doorId);
            sqlCmd.ExecuteNonQuery();

            
        }

        public void CompleteDoor(int door_id,int completeValue)
        {
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();
            string sb;
            if (completeValue == -1)
            {
                 sb = string.Format("UPDATE dbo.door SET date_paint_complete = '" + time.ToString(format) + "' ,complete_paint =" + completeValue + ", time_remaining_paint = 0 where id = " + door_id + ";");
            }
            else
            {
                 sb = string.Format("UPDATE dbo.door SET date_paint_complete = null, complete_paint =" + completeValue + " where id = " + door_id + ";");
            }

            SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
            myCommand.ExecuteNonQuery();

        }


        public void InsertPartCompletion(int door_id, string part_id, float time_for_part, int staff_id,int loopCount=1)
        {
            string sb;
            // try
            //{
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();

            //INSERTS NEW RECORDS INTO DBO DOOR PART COMPLETION LOG

            sb = string.Format("INSERT INTO dbo.door_part_completion_log (door_id,part_complete_date,time_for_part,part,part_status,op,staff_id)" +
                               "values(" + door_id + ",'" + time.ToString(format) + "'," + time_for_part + ",'" + part_id + "','Complete','Painting'," + staff_id + ")");

            SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
            myCommand.ExecuteNonQuery();

            //INSERTS THE ALLOCATION RECORD IF POWDER COATING IS COMPLETED
            //test

            if (loopCount <= 1)
            {
                if (part_id == "Powder Coat")
                {
                    sb = string.Format("INSERT INTO dbo.door_allocation (door_id, operation_date, department, staff_id)" +
                                        "VALUES(@door_id,@allocation_time,'Painting',@staff_id);");

                    SqlCommand sqlAllocation = new SqlCommand(sb, myConnection);

                    sqlAllocation.Parameters.AddWithValue("@door_id", door_id);
                    sqlAllocation.Parameters.AddWithValue("@allocation_time", DateTime.Now);
                    sqlAllocation.Parameters.AddWithValue("@staff_id", staff_id);

                    sqlAllocation.ExecuteNonQuery();
                }
            }


        }


        public void UpdateDailyGoals(float actual_hours, string op = "Painting")
        {

            var UpdateDate = DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000");
            
            try
            {
                SqlConnection myConnection = new SqlConnection(ConnectionString);
                myConnection.Open();

                var sb = string.Format("UPDATE dbo.daily_department_goal SET actual_hours = actual_hours + " + (actual_hours /60) + " where date_goal = '" + UpdateDate + "';");

                SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
                myCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured when updating the daily goal sheet, please notify IT immediately!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    
        }

        public int GetStaffIDFromName(string name)
        {
            string connectionString = ConnectionStringUser;
           
            string queryString = "Select id from dbo.c_view_painting_staff WHERE fullname=@name";
            string paramValue = name;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", paramValue);

                //try
                //{
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = (Int32)reader[0];

                        return id;

                    }

                    reader.Close();
                    return 0;
               // }
                //catch (Exception)
                //{
                 //   return 0;

               // }

            }
        }

        //DELETIONS//////////////////////////////////////////////

        public void DeletePartCompletion(int door_id, string part_id)
        {

            // try
            //{
            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();

            //INSERTS NEW RECORDS INTO DBO DOOR PART COMPLETION LOG


            var sb = string.Format("Delete FROM dbo.door_part_completion_log WHERE door_id =" + door_id + " and part = '" + part_id + "' and op='Painting'");
            SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
            myCommand.ExecuteNonQuery();


            if (part_id == "Powder Coat")
            {

                sb = string.Format("DELETE  FROM dbo.door_allocation WHERE department='Painting' and door_id = @door_id");

                SqlCommand sqlAllocation = new SqlCommand(sb, myConnection);

                sqlAllocation.Parameters.AddWithValue("@door_id", door_id);
                

                sqlAllocation.ExecuteNonQuery();
            }

        }

        public void DeductDailyGoals(float actual_hours, string op = "Painting")
        {

            var UpdateDate = DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000");

            try
            {
                SqlConnection myConnection = new SqlConnection(ConnectionString);
                myConnection.Open();

                var sb = string.Format("UPDATE dbo.daily_department_goal SET actual_hours = actual_hours - " + (actual_hours / 60) + " where date_goal = '" + UpdateDate + "';");

                SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
                myCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured when updating the daily goal sheet, please notify IT immediately!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void AddToDoor(int door_id, float time_remaining, string op_short)
        {

            TimeSplit ts = new TimeSplit();

            SqlConnection myConnection = new SqlConnection(ConnectionString);
            myConnection.Open();
            string sb;

            if (op_short == "up")
            {
                sb = string.Format("UPDATE dbo.door SET up_complete_paint = 0 WHERE id={0}", door_id);
                SqlCommand myCommand = new SqlCommand(sb.ToString(), myConnection);
                myCommand.ExecuteNonQuery();
            }



            if (op_short == "oven")
            { 
            sb = string.Format("UPDATE dbo.door SET {2}_complete_by_id = null,{2}_complete_by_id2 = null,{2}_complete_by_id3 = null, {2}_complete_date2 =null, time_remaining_paint = time_remaining_paint + {0} WHERE id={1}", time_remaining, door_id, op_short);
            }
            else
            {
            sb = string.Format("UPDATE dbo.door SET {2}_complete_by_id = null,{2}_complete_by_id2 = null,{2}_complete_by_id3 = null, {2}_complete_date =null, time_remaining_paint = time_remaining_paint + {0} WHERE id={1}", time_remaining, door_id, op_short);
            }
            SqlCommand myCommand1 = new SqlCommand(sb.ToString(), myConnection);
            myCommand1.ExecuteNonQuery();

        }




    }
}
