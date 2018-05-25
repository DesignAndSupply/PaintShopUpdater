using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class GenerateBox : Form
    {

        public int sc { get; set; }


        public GenerateBox(int stockCode)
        {
            InitializeComponent();
            sc = stockCode;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int i = 0;
            

            while (i < Convert.ToInt32(txtBoxQuantity.Text))
            {
                SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                if (txtCurrentKGs.Text != txtNewKgs.Text)
                {
                    sqlcmd.CommandText = "INSERT INTO dbo.paint_box (paint_id, kgs_when_new, kgs_remain,date_delivered,date_opened,location) VALUES(@stockCode,@kgsWHenNew,@kgsCurrent,@dateDelivered,@dateOpened,@location)";
                    sqlcmd.Parameters.AddWithValue("@stockCode", sc);
                    sqlcmd.Parameters.AddWithValue("@kgsWhenNew", txtNewKgs.Text);
                    sqlcmd.Parameters.AddWithValue("@kgsCurrent", txtCurrentKGs.Text);
                    sqlcmd.Parameters.AddWithValue("@dateDelivered", DateTime.Now);
                    sqlcmd.Parameters.AddWithValue("@dateOpened", DateTime.Now);
                    sqlcmd.Parameters.AddWithValue("@location", txtLocation.Text);

                }
                else
                {
                    sqlcmd.CommandText = "INSERT INTO dbo.paint_box (paint_id, kgs_when_new, kgs_remain,date_delivered,location) VALUES(@stockCode,@kgsWHenNew,@kgsCurrent,@dateDelivered,@location)";
                    sqlcmd.Parameters.AddWithValue("@stockCode", sc);
                    sqlcmd.Parameters.AddWithValue("@kgsWhenNew", txtNewKgs.Text);
                    sqlcmd.Parameters.AddWithValue("@kgsCurrent", txtCurrentKGs.Text);
                    sqlcmd.Parameters.AddWithValue("@dateDelivered", DateTime.Now);
                    sqlcmd.Parameters.AddWithValue("@location", txtLocation.Text);
                }

                sqlcmd.ExecuteNonQuery();
                i++;


                SqlCommand maxID = new SqlCommand();
                maxID.Connection = sqlconn;
                maxID.CommandText = "SELECT max(id) as maxID from dbo.paint_box";

                SqlDataReader rdr = maxID.ExecuteReader();
               

                while (rdr.Read())
                {
                    Document labelPrint = new Document(Convert.ToInt32(rdr["maxID"]));
                    labelPrint.PrintBoxLabel();
                }

                rdr.Close();
                sqlconn.Close();
            }



            MessageBox.Show("New boxes successfully Generated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
