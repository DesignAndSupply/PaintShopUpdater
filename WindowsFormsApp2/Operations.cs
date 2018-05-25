using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    class Operations {


        public float p_up;
        public float p_ww;
        public float p_etch;
        public float p_sand;
        public float p_pp;
        public float p_pc;
        public float p_oven;
        public float p_wp;
        public float p_wet;
        public float p_oven1;
        public float time_to_remove = 0.0f;


        public float CalcTimeRemaining(int door_id,string op,int finishID,int divisionBy = 1)
        {
            SectionPercentage sp = new SectionPercentage();
            p_up = sp.GetUPPercent(finishID);
            p_ww = sp.GetWWPercent(finishID);
            p_etch = sp.GetETCHPercent(finishID);
            p_sand = sp.GetSANDPercent(finishID);
            p_pp = sp.GetPPPercent(finishID);
            p_pc = sp.GetPCPercent(finishID);
            p_oven = sp.GetOVENPercent(finishID);
            p_wp = sp.GetWPPercent(finishID);
            p_wet = sp.GetWETPercent(finishID);
            p_oven1 = sp.GetOVEN2Percent(finishID);

            int TotalPaintingTime = GetTimePainting(door_id);

            switch (op)
            {
                case "Up":
                    time_to_remove = TotalPaintingTime * p_up;
                    break;
                case "Wash/Wipe":
                    time_to_remove = TotalPaintingTime * p_ww;
                    break;
                case "Etch":
                    time_to_remove = TotalPaintingTime * p_etch;
                    break;
                case "Sand":
                    time_to_remove = TotalPaintingTime * p_sand;
                    break;
                case "Powder Prime":
                    time_to_remove = TotalPaintingTime * p_pp;
                    break;
                case "Powder Coat":
                    time_to_remove = TotalPaintingTime * p_pc;
                    break;
                case "Oven":
                    time_to_remove = TotalPaintingTime * p_oven;
                    break;
                case "Wet Prep":
                    time_to_remove = TotalPaintingTime * p_wp;
                    break;
                case "Wet Paint":
                    time_to_remove = TotalPaintingTime * p_wet;
                    break;
                case "Oven 2":
                    time_to_remove = TotalPaintingTime * p_oven1;
                    break;
                default:
                    MessageBox.Show("No operation has been selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }



            return time_to_remove / divisionBy;

        }


        public  int GetTimePainting(int door_id)
        {

                string connectionString = SqlStatements.ConnectionString;
                //string connectionString = "Data Source=192.168.0.150\\SQLEXPRESS;user_id=sa; password=Dodid1; Initial Catalog=order_database; ";
                string queryString = "Select time_paint,quantity_same from dbo.door WHERE id=@door_num";
                int paramValue = door_id;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@door_num", paramValue);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int time_paint = (Int32) reader[0];
                            int quantity_same = (Int32) reader[1];
                            int total_time_paint = time_paint * quantity_same;
    
                            return total_time_paint;
                        }
                    
                        reader.Close();
                    return 0;
                }
                    catch (Exception)
                    {
                    return 0;

                    }
                   


                }



            
            
        }



    }



    
}
