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
    public partial class frmTrolleyOrTrack : Form
    {
        public frmTrolleyOrTrack(int doorNumber)
        {
            InitializeComponent();
            _doorID = doorNumber;

        }
        public int _doorID { get; set; }


        private void frmTrolleyOrTrack_Load(object sender, EventArgs e)
        {
           
        }

        private void btnTrolley_Click(object sender, EventArgs e)
        {

            updatePackingNote("trolley");
            

        }


        private void updatePackingNote(string placement)
        {

            string placementMessage;
            string placementIdentifier;

            Door d = new Door(_doorID);
            d.getPacknote();



            if(placement == "trolley")
            {
                placementMessage = d._packnote + " ||  DOOR ON TROLLEY  || ";
                placementIdentifier = "Trolley";
            }
            else
            {
                placementMessage = d._packnote + " ||  DOOR ON TRACK SYSTEM  || ";
                placementIdentifier = "Track";
            }

            using (SqlConnection con = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_trolley_or_track ", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@doorID", SqlDbType.VarChar).Value = _doorID;
                    cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = placementMessage;
                    cmd.Parameters.Add("@identifier", SqlDbType.VarChar).Value = placementIdentifier;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }



         
            this.Close();

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            updatePackingNote("track");
            //frm rail goes here
            frm_rail frm = new frm_rail(_doorID);
            frm.ShowDialog();
        }
    }
}
