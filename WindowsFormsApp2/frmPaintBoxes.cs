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
using GemBox.Document;

namespace WindowsFormsApp2
{
    public partial class frmPaintBoxes : Form
    {
        private int stockCode;
        private string paintInfo;

        public frmPaintBoxes(int sC, string paintDescription)
        {
            InitializeComponent();
            dgvBoxList.CellClick += dgvBoxList_CellClick;
            stockCode = sC;
            paintInfo = paintDescription;
            lblStockCode.Text = "Stock Code: " + stockCode.ToString();
            lblPaintDescription.Text = paintInfo.ToString();
            populateBoxList();
        }

        private void frmPaintBoxes_Load(object sender, EventArgs e)
        {

        }


        private void populateBoxList()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand sqlPaint = new SqlCommand();
            sqlPaint.Connection = con;
            sqlPaint.CommandType = CommandType.Text;

            if (rdoCurrent.Checked == true)
            {
                sqlPaint.CommandText = "Select * From c_view_paint_box_list WHERE [Stock Code] like @stockCode and [Kgs Remain] > 0 order by [Date Delivered] desc";
            }
            else
            {
                sqlPaint.CommandText = "Select * From c_view_paint_box_list WHERE [Stock Code] like @stockCode  order by [Date Delivered] desc";
            }

            sqlPaint.Parameters.AddWithValue("@stockCode", stockCode);
            SqlDataAdapter sqlPaintListAdap = new SqlDataAdapter(sqlPaint);

            try
            {

                DataTable dtPaint = new DataTable();
                sqlPaintListAdap.Fill(dtPaint);
                dgvBoxList.DataSource = dtPaint;

                //add selection button

                DataGridViewButtonColumn selectButton = new DataGridViewButtonColumn();
                selectButton.Text = "Update Box";
                selectButton.Name = "Update Box";
                selectButton.UseColumnTextForButtonValue = true;
                int columnIndex = 11;

                if (dgvBoxList.Columns["Update Box"] == null)
                {
                    dgvBoxList.Columns.Insert(columnIndex, selectButton);
                }


                //ADD PRINT LABEL BUTTON

                DataGridViewButtonColumn selectButton2 = new DataGridViewButtonColumn();
                selectButton2.Text = "Print Label";
                selectButton2.Name = "Print Label";
                selectButton2.UseColumnTextForButtonValue = true;
                columnIndex = 12;

                if (dgvBoxList.Columns["Print Label"] == null)
                {
                    dgvBoxList.Columns.Insert(columnIndex, selectButton2);
                }


            }
            catch
            {

            }
        }

        private void rdoCurrent_CheckedChanged(object sender, EventArgs e)
        {
            populateBoxList();
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            populateBoxList();
        }

        private void dgvBoxList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int box=0;
            double kgsRemain = 0;
            double kgsWhenNew = 0;

            if (dgvBoxList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvBoxList.SelectedCells[0].RowIndex;
                

                DataGridViewRow selectedRow = dgvBoxList.Rows[selectedrowindex];

                box = Convert.ToInt32(selectedRow.Cells["Box ID"].Value);
                kgsRemain = Convert.ToDouble(selectedRow.Cells["Kgs Remain"].Value);
                kgsWhenNew = Convert.ToDouble(selectedRow.Cells["Kgs When New"].Value);
            }



            //FIRES IF THE UPDATE BOX BUTTON IS CLICKED
            if (e.ColumnIndex == dgvBoxList.Columns["Update Box"].Index && e.RowIndex >= 0)
            {
                frmUpdateBox frmUB = new frmUpdateBox(box, lblPaintDescription.Text, kgsRemain, kgsWhenNew);
                frmUB.ShowDialog();
                populateBoxList();
            }
            //FIRES IF THE PRINT LABEL BUTTON IS CLICKED
            if (e.ColumnIndex == dgvBoxList.Columns["Print Label"].Index && e.RowIndex >= 0)
            {
                Document docs = new Document(box, paintInfo, DateTime.Now, kgsWhenNew);
                docs.PrintBoxLabel();
            }


        }




        private void dgvBoxList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateBox gb = new GenerateBox(stockCode);
            gb.ShowDialog();
            populateBoxList();
        }
    }
}
