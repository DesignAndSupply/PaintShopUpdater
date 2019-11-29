using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    class Allocation
    {

        public int _doorID { get; set; }
        public string _departmentIn { get; set; }
        public int _allocatedTo { get; set; }
        public int _departmentOut { get; set; }
        public Allocation(string department, int doorID)
        {
            _departmentIn = department;
            _doorID = doorID;
            getAllocationData();
        }

        private void getAllocationData()
        {

            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);

            SqlCommand cmd = new SqlCommand();

            switch (_departmentIn)
            {
                case "Office":
                    cmd.CommandText = "SELECT b.user_id FROM dbo.door a inner join dbo.door_container b on a.order_id = b.order_id where a.id =@doorID";
                    _departmentOut = 8;

                    break;
                case "Welding":
                    cmd.CommandText = "SELECT staff_id FROM dbo.door_allocation where door_id = @doorID and department = 'Welding'";
                    _departmentOut = 3;

                    break;
                case "Dressing":
                    cmd.CommandText = "SELECT staff_id FROM dbo.door_allocation where door_id = @doorID and department = 'Dressing'";
                    _departmentOut = 4;

                    break;
                case "Painting":
                    cmd.CommandText = "select top 1 staff_id from dbo.door_part_completion_log where op = 'Painting' and part = 'Powder Coat' and door_id = @doorID";
                    _departmentOut = 5;

                    break;
                case "Packing":
                    cmd.CommandText = "SELECT staff_id FROM dbo.door_allocation where door_id = @doorID and department = 'Packing'";
                    _departmentOut = 6;

                    break;

            }

            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@doorID", _doorID);

            _allocatedTo = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

        }
        


    }
}
