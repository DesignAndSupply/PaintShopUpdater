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
    public partial class frmReprintSearch : Form
    {
        public frmReprintSearch()
        {
            InitializeComponent();
            Operations();


            //add a search at some point? i guess

        }

        private void Operations()
        {
            //get the txtbox string and search from the get go

            string sql = "SELECT door_id,label_print_date from dbo.door_paint_label_printed WHERE door_id LIKE '%" + txtDoor.Text + "%' AND label_printed = -1 ORDER BY id DESC";
            //get the data and dump it in dgv
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //dgv magic
                    conn.Open();
                    DataTable DT = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    DA.Fill(DT);
                    dataGridView1.DataSource = DT;
                    conn.Close();
                }
            }
            //now format the bastard
            dataGridView1.Columns[0].HeaderText = "Door ID";
            dataGridView1.Columns[1].HeaderText = "Label Print Date";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void txtDoor_TextChanged(object sender, EventArgs e)
        {
            Operations();
        }

        private void txtDoor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.LightSeaGreen)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Empty;
            }
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string doorID = "";
            string RAL = "";
            string FINISH = "";
            string SUPPLIER = "";
            //get the DOOR ID from the lit up dgv
            for (int i = 0; i < dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.LightSeaGreen)
                    doorID = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }

            //test print i guess?
            string sql = "select b.[description], a.id ,(d.[NAME]) as [supplier] , (c.finish) as [finish] from dbo.door a " +
                " LEFT JOIN dbo.paint_to_door b ON a.id = b.door_id " +
                " LEFT JOIN dbo.paint_finish c ON b.finish_id = c.id " +
                " LEFT JOIN dbo.supplier d ON b.supplier_id = d.id " +
                "WHERE  complete_stores = 0 " +
                "AND[description] NOT LIKE '%FREE ISSUE PAINT%' " +
                "AND[description] is not null " +
                //only have selected customers 
                " AND (a.customer_acc_ref LIKE '%BOLT4%' " +
                " OR a.customer_acc_ref LIKE '%CALEDON%' " +
                "OR a.customer_acc_ref LIKE '%DOVE2%' " +
                "OR a.customer_acc_ref LIKE '%FAD%'  " +
                "OR a.customer_acc_ref LIKE '%JODAN%' " +
                "OR a.customer_acc_ref LIKE '%JOHNRE%' " +
                "OR a.customer_acc_ref LIKE '%ROTEC%' " +
                "OR a.customer_acc_ref LIKE '%SUNRAY%'" +
                " OR a.customer_acc_ref LIKE '%STRONDOR%')" +
                " AND a.id = " + doorID + " " +
                "order by a.id";
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                         RAL = Convert.ToString(dr["description"]);
                         FINISH =  Convert.ToString(dr["finish"]);
                         SUPPLIER = Convert.ToString(dr["supplier"]);
                    }
                    }
            }
            //first we need to get the values that get printed :)
            label_test rpt = new label_test();

            rpt.SetParameterValue("RALCOLOUR", RAL);
            rpt.SetParameterValue("SUPPLIER", "Supplier: " + SUPPLIER);
            rpt.SetParameterValue("FINISH", "Finish: " + FINISH);
            rpt.SetParameterValue("DOORNUMBER", "Door Number: " + doorID);
            rpt.PrintToPrinter(1, false, 0, 0); //this works well for auto printing

            this.Close();
        }
    }
}
