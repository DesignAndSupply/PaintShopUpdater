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
    public partial class frmStockBalance : Form
    {

        int sc = 0;
        string desc = "";

        public frmStockBalance()
        {
            InitializeComponent();
            dgvPaintList.CellClick += dgvPaintList_CellClick;
            //frmSelectUser frmsu = new frmSelectUser();
            //frmsu.ShowDialog();

        }

        private void frmStockBalance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_paint_stock' table. You can move, or remove it, as needed.

        }

        private void txtColour_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void populatePaintList()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);



            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand sqlPaint = new SqlCommand();
            sqlPaint.Connection = con;
            sqlPaint.CommandType = CommandType.Text;
            sqlPaint.CommandText = "Select * From c_view_paint_stock WHERE colour like @colour";
            sqlPaint.Parameters.AddWithValue("@colour","%" + txtColour.Text + "%");
            SqlDataAdapter sqlPaintListAdap = new SqlDataAdapter(sqlPaint);

            try
            {

                DataTable dtPaint = new DataTable();
                sqlPaintListAdap.Fill(dtPaint);
                dgvPaintList.DataSource = dtPaint;

                //add selection button

                //COMMENTED OUT BECAUSE THE BOX IDEA NEVER WENT LIVE

                //DataGridViewButtonColumn selectButton = new DataGridViewButtonColumn();
                //selectButton.Text = "View Boxes";
                //selectButton.Name = "View Boxes";
                //selectButton.UseColumnTextForButtonValue = true;
                //int columnIndex = 5;

                //if (dgvPaintList.Columns["View Boxes"] == null)
                //{
                //    dgvPaintList.Columns.Insert(columnIndex, selectButton);
                //}



            }
            catch
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            populatePaintList();
        }


        private void dgvPaintList_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvPaintList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPaintList.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPaintList.Rows[selectedrowindex];

                sc = Convert.ToInt32(selectedRow.Cells["Stock Code"].Value);
                desc = selectedRow.Cells["Colour"].Value + " " + selectedRow.Cells["Finish"].Value + " " + selectedRow.Cells["Supplier"].Value;

            }



            if (e.ColumnIndex == dgvPaintList.Columns["View Boxes"].Index)
            {
                frmPaintBoxes frmPB = new frmPaintBoxes(sc,desc);
                frmPB.ShowDialog();
                populatePaintList();
            }
        }

        private void btnSearchBox_Click(object sender, EventArgs e)
        {
            


            SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "Select [Stock Code], colour,finish,supplier from c_view_paint_box_list where [Box ID]=@boxId";
            sqlcmd.Parameters.AddWithValue("@boxId", txtBoxID.Text);
            SqlDataReader sdr = sqlcmd.ExecuteReader();

            while (sdr.Read())
            {
                sc = Convert.ToInt32(sdr["Stock Code"]);
                desc = sdr["Colour"] + " " + sdr["Finish"] + " " + sdr["Supplier"];
            }

            sdr.Close();
            sqlcmd.Dispose();

            frmPaintBoxes frmPB = new frmPaintBoxes(sc, desc);
            frmPB.ShowDialog();

        }

        private void dgvPaintList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
