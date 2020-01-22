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
            //wrap void in check for unfilled data
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (string.IsNullOrEmpty(dataGridView1.Rows[row.Index].Cells[3].Value.ToString()))
                {
                    //it is null so break out 
                    MessageBox.Show("One or more stock entires are empty!", "E R R O R !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //check combo
            if (combo_user.SelectedItem == null)
            {
                MessageBox.Show("Please select your name!", "E R R O R !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "";
            int staff_id = 0;
            //get user ID
            using (SqlConnection CONNECT = new SqlConnection(SqlStatements.ConnectionStringUser))
            {
                sql = "SELECT ID FROM DBO.[user] WHERE forename + ' ' + surname = '" + combo_user.SelectedItem + "' ";
                using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                {
                    CONNECT.Open();
                    staff_id = (int)cmd.ExecuteScalar();
                    CONNECT.Close();
                }
            }
            using (SqlConnection CONNECT = new SqlConnection(SqlStatements.ConnectionString))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sql = "UPDATE dbo.paint_rolling_stock_take SET amount_in_stock_post = " + dataGridView1.Rows[i].Cells[3].Value.ToString() + ",Counted_by_id = '" + staff_id + "',[Committed] = -1" +
                        " WHERE paint_stock_code = " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " AND id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                    {
                        // MessageBox.Show(sql);
                        CONNECT.Open();
                        cmd.ExecuteNonQuery();
                        CONNECT.Close();
                    }
                }

                //update dbo.stock with the new values
                double allocated_paint = 0;
                
                double dgvPaint = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //get value of the each paint selected THATS currently allocated
                    sql = "SELECT COALESCE(SUM(powder_kgs),0) as paint_used FROM((dbo.paint_to_door INNER JOIN dbo.door ON dbo.paint_to_door.door_id = dbo.door.id)" +
                        " LEFT JOIN dbo.paint_finish ON dbo.paint_to_door.finish_id = dbo.paint_finish.id)" +
                        " LEFT JOIN dbo.SALES_LEDGER ON dbo.door.customer_acc_ref = SALES_LEDGER.ACCOUNT_REF" +
                        " WHERE(((dbo.door.complete_paint) = 'False') AND((dbo.door.status_id) = 1 Or(dbo.door.status_id) = 2)) AND paint_to_door.paint_id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                    {
                    //    MessageBox.Show(sql);
                        CONNECT.Open();
                        
                        allocated_paint = (double)cmd.ExecuteScalar();
                        CONNECT.Close();
                        dgvPaint = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        MessageBox.Show("paint_id = " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " - has " + allocated_paint + " allocated to doors and the entered value = " + dataGridView1.Rows[i].Cells[3].Value.ToString());
                        allocated_paint = allocated_paint + dgvPaint;
                        MessageBox.Show("new value = " + allocated_paint.ToString());
                    }
                    sql = "UPDATE dbo.stock SET amount_in_stock = " + allocated_paint.ToString() + " WHERE stock_code = " + dataGridView1.Rows[i].Cells[1].Value.ToString() ;
                    using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                    {
                        //now we have the amount thats allocated we add this to the current value
                        CONNECT.Open();
                        //cmd.ExecuteNonQuery();
                        CONNECT.Close();
                    }
                    //also add to post because i forgot about that
                    sql = "update dbo.paint_rolling_stock SET amount_in_stock_post = " + allocated_paint.ToString() + " WHERE id = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                    using (SqlCommand cmd = new SqlCommand(sql, CONNECT))
                    {
                        CONNECT.Open();
                       // cmd.ExecuteNonQuery();
                        CONNECT.Close();
                    }
                }
            }
        }

        private void frmStockTake_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
