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
    public partial class frmReprintSearch : Form
    {
        public frmReprintSearch()
        {
            InitializeComponent();


            //add a search at some point? i guess
            
        }

        private void Operations()
        {
            //get the txtbox string and search from the get go
            string sql = "SELECT * from dbo.door_paint_label_printed WHERE label_printed = -1 ORDER BY id DESC";
            

        }
    }
}
