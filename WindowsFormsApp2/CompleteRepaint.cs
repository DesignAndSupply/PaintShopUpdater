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
    public partial class CompleteRepaint : Form 
    {
        public CompleteRepaint(int dID, int rpID, int pID)
        {
            InitializeComponent();
            txtDoorID.Text = dID.ToString();
            txtPaintID.Text = pID.ToString();
            txtRepaintID.Text = rpID.ToString();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            
            cmbRepaintBy.Validating += new CancelEventHandler(cmbRepaintBy_Validating);
            txtKgs.Validating += new CancelEventHandler(txtKgs_Validating);
            
        }

        private void CompleteRepaint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet1.vibration_tools' table. You can move, or remove it, as needed.
            this.vibration_toolsTableAdapter.Fill(this.order_databaseDataSet1.vibration_tools);
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_painting_staff' table. You can move, or remove it, as needed.
            this.c_view_painting_staffTableAdapter.Fill(this.user_infoDataSet.c_view_painting_staff);




        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {

                //UPDATE REPAINT INFORMATION
                SqlConnection myConnection = new SqlConnection(SqlStatements.ConnectionString);
                myConnection.Open();
                var sb = string.Format("UPDATE dbo.repaints set sanding_exposure_points = @sandingExposurePoints, sanding_time= @sandingTime,sanded_by_id = @sandedById, repaint_by= @repaint_by,paint_kg_used = @paint_kg_used, repaint_complete = @complete, date_painted = @date_painted WHERE id=@repaint_id");
                SqlCommand command = new SqlCommand(sb, myConnection);
                command.Parameters.AddWithValue("@repaint_id", this.txtRepaintID.Text);
                command.Parameters.AddWithValue("@paint_kg_used", this.txtKgs.Text);
                command.Parameters.AddWithValue("@date_painted", DateTime.Now);
                command.Parameters.AddWithValue("@repaint_by", this.cmbRepaintBy.SelectedValue);
                command.Parameters.AddWithValue("@complete", -1);

                if(rdoYes.Checked == true)
                {
                    command.Parameters.AddWithValue("@sandingTime", this.txtMins.Text);
                    command.Parameters.AddWithValue("@sandedById", this.cmbSandBy.SelectedValue);
                   
                    command.Parameters.AddWithValue("@sandingExposurePoints", (Convert.ToDouble(this.txtMins.Text) / 60) * Convert.ToDouble(this.cmbTool.SelectedValue));
                }
                else
                {
                    command.Parameters.AddWithValue("@sandingTime", DBNull.Value);
                    command.Parameters.AddWithValue("@sandedById", DBNull.Value);
                    
                    command.Parameters.AddWithValue("@sandingExposurePoints", DBNull.Value);
                }
                

                command.ExecuteNonQuery();



                //UPDATE STOCK
                SqlStatements sql = new SqlStatements();
                sql.UpdatePaintStock(int.Parse(txtPaintID.Text), int.Parse(txtKgs.Text));
                MessageBox.Show("Repaint Completed Successfully.","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled in before completing the repaint!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cmbRepaintBy_Validating(object sender, CancelEventArgs e)
        {
            var tb = (ComboBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb, "Mandatory Field Missing");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb, string.Empty);
            }
        }

        private void txtKgs_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb, "Numerical value is required.");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb, string.Empty);
            }
        }

        private void HideSanding()
        {
            if (rdoYes.Checked == true)
            {
                this.txtMins.Visible = true;
                this.lblMins.Visible = true;
                this.lblSandBy.Visible = true;
                this.cmbSandBy.Visible = true;
                this.lblTool.Visible = true;
                this.cmbTool.Visible = true;

            }
            else
            {
                this.txtMins.Visible = false;
                this.lblMins.Visible = false;
                this.lblSandBy.Visible = false;
                this.cmbSandBy.Visible = false;
                this.lblTool.Visible = false;
                this.cmbTool.Visible = false;

            }
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            HideSanding();
        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            HideSanding();
        }
    }
}
