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
    public partial class NewRepaint : Form
    {
        
        public NewRepaint()
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            txtDoorId.Validating += new CancelEventHandler(textBox_Validating);
            txtKgs.Validating += new CancelEventHandler(textBox_Validating);
            txtReason.Validating += new CancelEventHandler(textBox_Validating);
            txtMins.Validating += new CancelEventHandler(textBox_Validating);
        }

        private void NewRepaint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet1.vibration_tools' table. You can move, or remove it, as needed.
            this.vibration_toolsTableAdapter.Fill(this.order_databaseDataSet1.vibration_tools);
            // TODO: This line of code loads data into the 'dsl_kpiDataSet.department' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dsl_kpiDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dsl_kpiDataSet.department);
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_current_shop_floor_staff' table. You can move, or remove it, as needed.
            this.c_view_current_shop_floor_staffTableAdapter.Fill(this.user_infoDataSet.c_view_current_shop_floor_staff);
            // TODO: This line of code loads data into the 'user_infoDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.user_infoDataSet.user);
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_painting_staff' table. You can move, or remove it, as needed.
            this.c_view_painting_staffTableAdapter.Fill(this.user_infoDataSet.c_view_painting_staff);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.ValidateChildren();

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                String ConnectionString = SqlStatements.ConnectionString;
                //MessageBox.Show(this.cmbEmployee.SelectedValue.ToString());

                int door_id = Int32.Parse(this.txtDoorId.Text.ToString());


                int paint_id = get_paint_id(Int32.Parse(this.txtDoorId.Text.ToString()));

                SqlConnection myConnection = new SqlConnection(ConnectionString);
                myConnection.Open();

                //INSERTS NEW RECORDS INTO DBO DOOR PART COMPLETION LOG




                var sb = string.Format("INSERT into dbo.repaints(sanding_exposure_points,paint_id, paint_kg_used, painter_name, department, door_id, reason_for_repaint,repaint_by, repaint_time,logged_by_id,repaint_complete,date_logged,repaint_from_dept,sanding_time,sanded_by_id) VALUES " +
                                       "(@sandingExposurePoints,@paint_id,@paint_kg_used,@painter_name,@department,@door_id,@reason,@repaint_by,@repaint_time,@logged_by,@complete,@date_logged,@repaint_from_dept,@sandingTime,@sandedById)");

                SqlCommand command = new SqlCommand(sb, myConnection);
                command.Parameters.AddWithValue("@paint_id", paint_id);
                command.Parameters.AddWithValue("@paint_kg_used", this.txtKgs.Text);
                //command.Parameters.AddWithValue("@date_painted", DateTime.Now);
                command.Parameters.AddWithValue("@painter_name", this.cmbEmployee.SelectedValue);
                command.Parameters.AddWithValue("@department", this.cmbDepartment.SelectedValue);
                command.Parameters.AddWithValue("@door_id", door_id);
                command.Parameters.AddWithValue("@reason", this.txtReason.Text);
                command.Parameters.AddWithValue("@repaint_by", this.cmbRepaintBy.SelectedValue);
                command.Parameters.AddWithValue("@repaint_time", 0);
                command.Parameters.AddWithValue("@logged_by", this.cmbLoggedBy.SelectedValue);
                command.Parameters.AddWithValue("@complete", 0);
                command.Parameters.AddWithValue("@date_logged", DateTime.Now);


                if (rdoYes.Checked == true)
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
                command.Parameters.AddWithValue("@repaint_from_dept", string.Format("Painting"));
                command.ExecuteNonQuery();

                SqlStatements sql = new SqlStatements();
                sql.UpdatePaintStock(int.Parse(paint_id.ToString()), int.Parse(txtKgs.Text));
                
                this.Close();
            }
            else
            {
                MessageBox.Show("There are invalid entries on the form. Please fill out all input areas", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void departmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public int get_paint_id(int door_id)
        {
            
            string connectionString = SqlStatements.ConnectionString;
            //string connectionString = "Data Source=192.168.0.150\\SQLEXPRESS;user_id=sa; password=Dodid1; Initial Catalog=order_database; ";
            string queryString = "Select paint_id from dbo.c_view_get_paint_id WHERE door_id=@door_num";
            int paramValue = door_id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@door_num", paramValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int paint_id = (Int32)reader[0];


                        return paint_id;
                    }

                    reader.Close();
                    return 0;
                }
                catch (Exception)
                {
                    return 0;

                }



            }
        }

        private void textBox_Validating(object sender,System.ComponentModel.CancelEventArgs e)
        {
           
            var tb = (TextBox)sender;
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

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            HideSanding();

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

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            HideSanding();
        }
    }
}
