using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class AuthenticatedUser
    {
        
        public static string uFullName { get; set; }
        public static int uID { get; set; }

        public AuthenticatedUser(int userId)
        {
            uID = userId;
            uFullName = userFullName();
        }

        private string userFullName()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionStringUser);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id,forename + ' ' + surname as fullname from dbo.user WHERE id = @id;";
            cmd.Parameters.AddWithValue("@id", uID);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return rdr["fullname"].ToString();
            }
            else
            {
                return "";
            }

            
        }



    }
}
