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

            Door d = new Door(_doorID);
            d.getPacknote();



            if(placement == "trolley")
            {
                placementMessage = d._packnote + " ||  DOOR ON TROLLEY  || ";
            }
            else
            {
                placementMessage = d._packnote + " ||  DOOR ON TRACK SYSTEM  || ";
            }



            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE DBO.DOOR SET packing_note = @packNote where id=@doorID",conn);
            cmd.Parameters.AddWithValue("@packNote", placementMessage);
            cmd.Parameters.AddWithValue("@doorId", _doorID);

            cmd.ExecuteNonQuery();

            conn.Close();
            this.Close();

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            updatePackingNote("track");
           
        }
    }
}
