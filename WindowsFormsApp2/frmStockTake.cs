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
    public partial class frmStockTake : Form
    {
        public frmStockTake()
        {
            InitializeComponent();

            string sql = "";
            using (SqlConnection CONNECT = new SqlConnection(SqlStatements.ConnectionString))
            { //datagridview
                sql = "SELECT TOP 10 id,paint_stock_code,[description] from dbo.paint_rolling_stock_take ORDER BY stock_take_number DESC";
                using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                {
                    DataTable DT = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    CONNECT.Open();
                    cmd.ExecuteNonQuery();
                    DA.Fill(DT);
                    CONNECT.Close();
                    DT.Columns.Add(new DataColumn("Quantity in Stock", typeof(double)));
                    dataGridView1.DataSource = DT;
                    format();
                }
                //combo
                sql = "select a.id,b.date_plan,c.forename + ' ' + c.surname as [name],a.department from dbo.power_plan_staff a " +
                         "LEFT JOIN dbo.power_plan_date b ON a.date_id = b.id " +
                         "LEFT JOIN[user_info].[dbo].[user] c on a.staff_id = c.id " +
                         "WHERE a.department = 'Painting' AND date_plan = CAST(GETDATE() AS DATE)" +
                         "ORDER BY [name] ASC";
                using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                {
                    CONNECT.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        combo_user.Items.Add(dr["name"].ToString());
                    }
                }

            }
        }

        private void format()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Paint Stock Code";
            dataGridView1.Columns[2].HeaderText = "Description";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = false;

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(checkDigits);
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(checkDigits);
                }
            }
        }
        private void checkDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql = "";
            using (SqlConnection CONNECT = new SqlConnection(SqlStatements.ConnectionString))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sql = "UPDATE dbo.paint_rolling_stock_take SET amount_in_stock_post = " + dataGridView1.Rows[i].Cells[3].Value.ToString() + ",Counted_by_id = '" + combo_user.SelectedItem + "',Committed = -1,";
                    using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                    {
                        MessageBox.Show(sql);
                    }
                }
            }

        }
    }
}
