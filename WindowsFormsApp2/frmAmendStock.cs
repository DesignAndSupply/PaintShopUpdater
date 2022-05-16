using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmAmendStock : Form
    {
        public string _stockCode { get; set; }
        public frmAmendStock(string stockCode)
        {
            InitializeComponent();
            _stockCode = stockCode;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtQty.TextLength < 1)
            {
                MessageBox.Show("Please enter a quantity before updating the stock value!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToDouble(txtQty.Text) <  0.1)
            {
                MessageBox.Show("Please enter a quantity that is > 0 before updating the stock value!", "Error", MessageBoxButtons.OK);
                return;
            }
            string sql = "UPDATE dbo.stock SET amount_in_stock = " + txtQty.Text + " WHERE stock_code = '" + _stockCode + "'";

            MessageBox.Show(sql);

            frmDeductStock frm = new frmDeductStock(_stockCode); //open up the deduct form 
            frm.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
