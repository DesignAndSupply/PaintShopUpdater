using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public class Door
    {
        public int _doorID { get; set; }
        public string _packnote { get; set; }

        public Door(int doorID)
        {
            _doorID = doorID;
        }

        public void getPacknote()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select packing_note from dbo.door where id=@doorID", conn);
            cmd.Parameters.AddWithValue("@doorID", _doorID);
            _packnote = cmd.ExecuteScalar().ToString();
            conn.Close();
        }







    }
}
