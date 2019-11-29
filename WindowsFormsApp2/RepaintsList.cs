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
    public partial class RepaintsList : Form
    {
        public RepaintsList()
        {
            InitializeComponent();
        }

        int repaintID;
        int repaintComplete;
        string loggedFrom;
        int doorID;
        int paintID;



        private void RepaintsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_repaint_list' table. You can move, or remove it, as needed.
            this.c_view_repaint_listTableAdapter.FillBy2(this.order_databaseDataSet1.c_view_repaint_list);
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.c_view_repaint_listTableAdapter.FillBy(this.order_databaseDataSet1.c_view_repaint_list);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.c_view_repaint_listTableAdapter.FillBy2(this.order_databaseDataSet1.c_view_repaint_list);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgRepaintList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int selectedrowindex = dgRepaintList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgRepaintList.Rows[selectedrowindex];
            repaintID = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            doorID = Int32.Parse(selectedRow.Cells[12].Value.ToString());
            repaintComplete = Int32.Parse(selectedRow.Cells[9].Value.ToString());
            loggedFrom = selectedRow.Cells[10].Value.ToString();

            //Gets the paint id from the door
            NewRepaint nr = new NewRepaint();
            paintID = nr.get_paint_id(Int32.Parse(selectedRow.Cells[12].Value.ToString()));

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                if (loggedFrom != "Packing")
                {
                    SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE dbo.repaints SET repaint_complete = -1, date_painted= @datetime where id = @id";
                    cmd.Parameters.AddWithValue("@id", repaintID);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    this.c_view_repaint_listTableAdapter.FillBy2(this.order_databaseDataSet1.c_view_repaint_list);
                }
                else
                {
                    CompleteRepaint cr = new CompleteRepaint(doorID,repaintID,paintID);
                    cr.ShowDialog();
                    this.c_view_repaint_listTableAdapter.FillBy2(this.order_databaseDataSet1.c_view_repaint_list);
                }
                
                   
          

            }
        }

        private void btnNewRepaint_Click(object sender, EventArgs e)
        {
            NewRepaint nr = new NewRepaint();
            nr.ShowDialog();
            this.c_view_repaint_listTableAdapter.FillBy2(this.order_databaseDataSet1.c_view_repaint_list);

        }
    }
}
