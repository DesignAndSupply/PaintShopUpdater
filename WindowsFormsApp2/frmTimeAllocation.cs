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
    public partial class frmTimeAllocation : Form
    {
        public int staffID;
        public int ReturnStaffId { get; set; }
        

        string OpFromMainMenu;

        public frmTimeAllocation(string op)
        {
            InitializeComponent();
            OpFromMainMenu = op;
        }

        private void frmTimeAllocation_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\PaintShop\xml.xml");

           

            DataTable xmlDt = ds.Tables["Table1"];
            string expression;
            string Staff1;
            string Staff2;
            string Staff3;
            
            expression = "Column4='" + OpFromMainMenu + "'";

            DataRow[] results = xmlDt.Select(expression);

            if (results.Length > 0)
            {
                try
                {
                    Staff1 = Convert.ToString(results[0]["Column1"]);
                    lblStaff1.Text = Staff1;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    Staff2 = Convert.ToString(results[0]["Column2"]);
                }
                catch
                {
                    Staff2 = "";
                }
                try
                {
                    Staff3 = Convert.ToString(results[0]["Column3"]);
                }
                catch
                {
                    Staff3 = "";
                }

                lblStaff2.Text = Staff2;
                lblStaff3.Text = Staff3;
                
                if(string.IsNullOrWhiteSpace(Staff2))
                {
                    rdoStaff2.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(Staff3))
                {
                    rdoStaff3.Visible = false;
                }

            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            SqlStatements sql = new SqlStatements();

            

            if(rdoStaff1.Checked == true)
            {
                this.ReturnStaffId = sql.GetStaffIDFromName(lblStaff1.Text.ToString());
            }
            else if(rdoStaff2.Checked == true)
            {
                this.ReturnStaffId = sql.GetStaffIDFromName(lblStaff2.Text.ToString());
            }
            else
            {
                this.ReturnStaffId = sql.GetStaffIDFromName(lblStaff3.Text.ToString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
