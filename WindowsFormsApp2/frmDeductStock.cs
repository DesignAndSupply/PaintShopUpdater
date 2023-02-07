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
    public partial class frmDeductStock : Form
    {
        public string _stockCode { get; set; }
        public frmDeductStock(string stockCode)
        {
            InitializeComponent();
            rdoSingle.Checked = true;
            _stockCode = stockCode;
        }

        private void rdoSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSingle.Checked == true)
            {
                lblAfter.Visible = true;
                lblBefore.Visible = true;
                txtAfter.Visible = true;
                txtBefore.Visible = true;
                lblMultiple.Visible = false;
                txtMultiple.Visible = false;
            }
            else
            {
                lblAfter.Visible = false;
                lblBefore.Visible = false;
                txtAfter.Visible = false;
                txtBefore.Visible = false;
                lblMultiple.Visible = true;
                txtMultiple.Visible = true;
            }
        }

        private void rdoMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMultiple.Checked == true)
            {
                lblAfter.Visible = false;
                lblBefore.Visible = false;
                txtAfter.Visible = false;
                txtBefore.Visible = false;
                lblMultiple.Visible = true;
                txtMultiple.Visible = true;
            }
            else
            {
                lblAfter.Visible = true;
                lblBefore.Visible = true;
                txtAfter.Visible = true;
                txtBefore.Visible = true;
                lblMultiple.Visible = false;
                txtMultiple.Visible = false;
            }
        }

        private void btnDeduct_Click(object sender, EventArgs e)
        {

            string sql = "";
            double weight_to_remove = 0;
            double amount_in_stock = 0;
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                conn.Open();
                //get the current paint value of this box
                sql = "SELECT COALESCE(amount_in_stock,0) FROM dbo.stock WHERE stock_code = '" + _stockCode + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                    amount_in_stock = (double)cmd.ExecuteScalar();

                if (rdoSingle.Checked == true)
                {
                    if (txtBefore.TextLength < 1 || txtAfter.TextLength < 1)
                    {
                        MessageBox.Show("Please enter both quantities before deducting any stock!");
                        return;
                    } //validation
                    if (Convert.ToDouble(txtAfter.Text) > Convert.ToDouble(txtBefore.Text))
                    {
                        MessageBox.Show("KG after *CANNOT* be more than the KG before");
                        return;
                    } //validation

                    weight_to_remove = Convert.ToDouble(txtBefore.Text) - Convert.ToDouble(txtAfter.Text);
                    if (( amount_in_stock - weight_to_remove) < 0)
                    {
                        weight_to_remove = amount_in_stock;
                    }
                    sql = "UPDATE dbo.stock SET amount_in_stock = amount_in_stock - " + weight_to_remove.ToString() + " WHERE stock_code = '" + _stockCode + "'";
                }
                else //its multiple
                {
                    if (txtMultiple.TextLength < 1)
                    {
                        MessageBox.Show("Please enter the total KG used before deducting any stock!");
                        return;
                    } //validation
                    weight_to_remove = Convert.ToDouble(txtMultiple.Text);
                    if ((amount_in_stock - weight_to_remove) < 0)
                    {
                        weight_to_remove = amount_in_stock;
                    }
                    sql = "UPDATE dbo.stock SET amount_in_stock = amount_in_stock - " + weight_to_remove.ToString() + " WHERE stock_code = '" + _stockCode + "'";
                }

                //fire sql here
                MessageBox.Show(sql);
                conn.Close();
                this.Close();
            }

        }

        private void txtBefore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMultiple_KeyDown(object sender, KeyEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtMultiple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
