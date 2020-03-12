using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_rail : Form
    {
        public bool noComma { get; set; }
        public string txtNumbersNoComma { get; set; }
        public int _DOORID { get; set; }
        public frm_rail(int door_id)
        {
            InitializeComponent();
            _DOORID = door_id;
            for (int i = 1; i < 121; i++)
            {
                listbox.Items.Add(i.ToString(), false);
            }
        }

        private void Txt_numbers_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

        }

        private void Btn_add_txtbox_Click(object sender, EventArgs e)
        {

        }

        private void Btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {

            string numbers = "";
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                if (listbox.GetItemChecked(i))
                    numbers = numbers + listbox.Items[i].ToString() + ",";
            }
            numbers = numbers.Remove(numbers.Length - 1);
            txt_string.Text = numbers;

        }

        private void btn_add_txtbox_Click_1(object sender, EventArgs e)
        {
            txtNumbersNoComma = txt_numbers.Text;
            noComma = false;
            while (noComma == false)
                removeLastComma(txtNumbersNoComma);


            txt_string.Text = txtNumbersNoComma;
        }

        private void removeLastComma(string text)
        {
            string temp = txtNumbersNoComma.Substring(txtNumbersNoComma.Length - 1);
            if (temp != ",")
                noComma = true;
            else
            {
                temp = txtNumbersNoComma.Substring(0, txtNumbersNoComma.Length - 1);
                txtNumbersNoComma = temp;
            }

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_string.Text))
            {
                MessageBox.Show("Please Select Flight Bar Numbers");
                return;
            }
            string sql = "UPDATE dbo.door2 SET flight_bar_num = '" + txt_string.Text + "' WHERE door_id = " + _DOORID.ToString();
            // MessageBox.Show(sql);
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            this.Close();
        }

        private void txt_numbers_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


