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
    public partial class frmSelectUser : Form
    {
        public frmSelectUser()
        {
            InitializeComponent();
        }

        private void frmSelectUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_painting_staff' table. You can move, or remove it, as needed.
            this.c_view_painting_staffTableAdapter.Fill(this.user_infoDataSet.c_view_painting_staff);

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            AuthenticatedUser au = new AuthenticatedUser(Convert.ToInt32(cmbStaff.SelectedValue));
            this.Dispose();
        }
    }
}
