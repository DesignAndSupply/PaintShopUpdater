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
    }
}


