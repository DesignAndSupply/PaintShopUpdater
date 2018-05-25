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
    public partial class frmUpdateBox : Form
    {

        //int boxNumber;
        //string paintDesc;
        //double kgsRemaining;
        //double kgsWhenNew;


        public int boxNumber { get; set; }
        public string paintDesc { get; set; }
        public double kgsRemaining { get; set; }
        public double kgsWhenNew { get; set; }


        public frmUpdateBox(int boxID,string desc, double kgsRemain, double kgsWN)
        {
            InitializeComponent();
            boxNumber = boxID;
            paintDesc = desc;
            kgsRemaining = kgsRemain;
            kgsWhenNew = kgsWN;
            lblBox.Text = "Amending info for Box ID: " + boxNumber;
            lblPaintDesc.Text = paintDesc;
            lblKgsRemain.Text = "Current Kgs Remaining in box: " + kgsRemaining.ToString();
        }

        private void frmUpdateBox_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = double.TryParse(txtActualKgs.Text, out n);
            if (isNumeric == true)
            {

                SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
                SqlCommand sqlcmd = new SqlCommand();
                sqlconn.Open();
                sqlcmd.Connection = sqlconn;
                try
                {
                    //if the quantity value is 0 do nothing
                    if (string.IsNullOrWhiteSpace(n.ToString()))
                    {

                    }
                    //NEW BOX IS OPENED AND FINISHED IN ONE GO
                    else if (kgsRemaining == kgsWhenNew && n == 0)
                    {
                        sqlcmd.CommandText = "UPDATE dbo.paint_box SET kgs_remain = @kgsRemain, date_opened = @dateOpened,date_empty = @dateEmpty WHERE id = @boxID";
                        sqlcmd.Parameters.AddWithValue("@kgsRemain", n);
                        sqlcmd.Parameters.AddWithValue("@boxID", boxNumber);
                        sqlcmd.Parameters.AddWithValue("@dateOpened", DateTime.Now);
                        sqlcmd.Parameters.AddWithValue("@dateEmpty", DateTime.Now);
                    }
                    //NEW BOX IS OPENED AND NOT FINISH
                    else if ((kgsRemaining == kgsWhenNew) && kgsRemaining > n)
                    {
                        sqlcmd.CommandText = "UPDATE dbo.paint_box SET kgs_remain = @kgsRemain, date_opened = @dateOpened WHERE id = @boxID";
                        sqlcmd.Parameters.AddWithValue("@kgsRemain", n);
                        sqlcmd.Parameters.AddWithValue("@boxID", boxNumber);
                        sqlcmd.Parameters.AddWithValue("@dateOpened", DateTime.Now);
                    }
                    //BOX THAT IS ALREADY OPENED IS NOW FINISHED
                    else if (n == 0)
                    {

                        sqlcmd.CommandText = "UPDATE dbo.paint_box SET kgs_remain = @kgsRemain, date_empty = @dateEmpty WHERE id = @boxID";
                        sqlcmd.Parameters.AddWithValue("@kgsRemain", n);
                        sqlcmd.Parameters.AddWithValue("@boxID", boxNumber);
                        sqlcmd.Parameters.AddWithValue("@dateEmpty", DateTime.Now);
                    }
                    //BOX THAT IS ALREADY OPENED IS JUST UPDATED
                    else
                    {
                        sqlcmd.CommandText = "UPDATE dbo.paint_box SET kgs_remain = @kgsRemain WHERE id = @boxID";
                        sqlcmd.Parameters.AddWithValue("@kgsRemain", n);
                        sqlcmd.Parameters.AddWithValue("@boxID", boxNumber);
                    }

                    sqlcmd.ExecuteNonQuery();
                    sqlconn.Close();

                    this.Close();


                }
                catch
                {
                    MessageBox.Show("Please ensure you have entered a kgs remaining value. If this error persists call IT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a numeric value!", "Enter Numeric Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
