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
    public partial class frmCheckDoorSearched : Form
    {

        public bool yesNo { get; set; }
        public frmCheckDoorSearched(string RAL,string doorID,string supplier,string finish)
        {
            InitializeComponent();
            txtRAL.Text = RAL;
            txtFinish.Text = finish;
            txtSupplier.Text = supplier;
            txtDoorNumber.Text = doorID;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            yesNo = false;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            yesNo = true;
            this.Close();
        }
    }
}
