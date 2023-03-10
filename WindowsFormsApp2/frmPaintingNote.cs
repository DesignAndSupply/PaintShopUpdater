using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmPaintingNote : Form
    {
        public int door_id { get; set; }
        public frmPaintingNote(int door_id)
        {
            InitializeComponent();
            this.door_id = door_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtNote.Text = txtNote.Text.Replace("'", "");
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("Please enter a note before saving!", "Missing Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //get the current note (if there is one)
            string note = "";
            string sql = "select painting_note from dbo.door where id = " + door_id;

            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    var temp = cmd.ExecuteScalar();
                    if (string.IsNullOrEmpty(temp.ToString()))
                        note = txtNote.Text;
                    else
                        note = temp.ToString() + Environment.NewLine + " " +txtNote.Text;
                }

                note = note + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

                //now update the note
                sql = "UPDATE dbo.door SET painting_note = '" + note + "' WHERE id = " + door_id.ToString();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }


                conn.Close();
            }
            this.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
