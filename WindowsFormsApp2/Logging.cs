using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{



    class Logging
    {
        private int boxId { get; set; }
        private string movement { get; set; }
        private double movementQty { get; set; }
        private int transactionBy { get; set; }

        public Logging(int _boxId, string _movement, double _movementQty, int _transactionBY)
        {

            boxId = _boxId;
            movement = _movement;
            movementQty = _movementQty;
            transactionBy = _transactionBY;

        }

        public void upDateLog()
        {

            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO dbo.paint_box_transaction_log (box_id, transaction_date, movement,movement_qty,transaction_by_id) VALUES (@boxID,@transactionDate,@movement,@movementQty,@transactionbyid);";

            cmd.Parameters.AddWithValue("@boxID", boxId);
            cmd.Parameters.AddWithValue("@transactionDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@movement", movement);
            cmd.Parameters.AddWithValue("@movementQty", movementQty);
            cmd.Parameters.AddWithValue("@transactionbyid", transactionBy);

            cmd.ExecuteNonQuery();

            conn.Close();


        }
        





    }
}
