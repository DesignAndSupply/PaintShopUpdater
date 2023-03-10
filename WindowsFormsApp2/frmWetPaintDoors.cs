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
using System.Drawing.Printing;
using System.Drawing.Imaging;
using GemBox.Document;

namespace WindowsFormsApp2
{
    public partial class frmWetPaintDoors : Form
    {

        public int id_index { get; set; }
        public int date_paint_index { get; set; }
        public int customer_index { get; set; }
        public int door_type_index { get; set; }
        public int paint_description_index { get; set; }
        public int painting_note_index { get; set; }
        public int add_note_index { get; set; }
        public frmWetPaintDoors()
        {
            InitializeComponent();

            load_data();

        }

        private void load_data()
        {
            string sql = "select d.id,d.date_paint,rtrim(s.[NAME]) as customer,dt.door_type_description, pc.[paint_description],d.painting_note from dbo.door d " +
                "left join dbo.door_type dt on d.door_type_id = dt.id " +
                "left join dbo.SALES_LEDGER s on d.customer_acc_ref = s.ACCOUNT_REF " +
                "left join dbo.paint_to_door p on d.id = p.door_id " +
                "left join dbo.finish f on p.finish_id = f.id " +
                "left join dbo.view_paint_to_door_concat_multiple_paint pc on d.id = pc.door_id " +
                "where wet = -1 and (complete_paint = 0 or complete_paint is null) and date_paint >= CAST(GETDATE() as date) " +
                "order by date_paint";

            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                conn.Close();
            }
            column_index();
            add_buttons();
            column_index();
            format();
        }

        private void add_buttons()
        {
            int col_index = 0;
           

            if (dataGridView1.Columns.Contains("Add Note") == true)
            {
                dataGridView1.Columns.Remove("Add Note");
            }
            column_index();
            col_index = painting_note_index + 1;
            DataGridViewButtonColumn processedButton = new DataGridViewButtonColumn();
            processedButton.Name = "Add Note";
            processedButton.Text = "Add Note";
            processedButton.UseColumnTextForButtonValue = true;
            if (dataGridView1.Columns["Add Note_column"] == null)
            {
                dataGridView1.Columns.Insert(col_index, processedButton);
            }
        }
        private void column_index()
        {
            id_index = dataGridView1.Columns["id"].Index;
            date_paint_index = dataGridView1.Columns["date_paint"].Index;
            customer_index = dataGridView1.Columns["customer"].Index;
            door_type_index = dataGridView1.Columns["door_type_description"].Index;
            paint_description_index = dataGridView1.Columns["paint_description"].Index;
            painting_note_index = dataGridView1.Columns["painting_note"].Index;
            if (dataGridView1.Columns.Contains("Add Note") == true)
                add_note_index = dataGridView1.Columns["Add Note"].Index;
        }

        private void format()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Columns[painting_note_index].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[id_index].HeaderText = "Door ID";
            dataGridView1.Columns[date_paint_index].HeaderText = "Painting Date";
            dataGridView1.Columns[customer_index].HeaderText = "Customer";
            dataGridView1.Columns[door_type_index].HeaderText = "Door Type";
            dataGridView1.Columns[paint_description_index].HeaderText = "Paint Required";
            dataGridView1.Columns[painting_note_index].HeaderText = "Note";
            dataGridView1.Columns[add_note_index].HeaderText = "Add Note";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\temp\temp_" + DateTime.Now.ToString("mm-ss") + ".jpg";
            try
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    bitmap.Save(fileName, ImageFormat.Jpeg);
                    printImage(fileName);
                }
            }
            catch
            {
            }
        }

        private void printImage(string fileName)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, args) =>
                {
                    Image i = Image.FromFile(fileName);
                    Point p = new Point(100, 100);
                    args.Graphics.DrawImage(i, args.MarginBounds);
                };

                pd.DefaultPageSettings.Landscape = true;
                Margins margins = new Margins(50, 50, 50, 50);
                pd.DefaultPageSettings.Margins = margins;
                pd.Print();
            }
            catch
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == add_note_index)
            {
                frmPaintingNote frm = new frmPaintingNote(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[id_index].Value.ToString()));
                frm.ShowDialog();
                load_data();
            }
        }

        private void frmWetPaintDoors_Shown(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
