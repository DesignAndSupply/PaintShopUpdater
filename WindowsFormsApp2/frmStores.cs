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
using System.Drawing.Imaging;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp2
{
    public partial class frmStores : Form
    {

        public frmStores()
        {
            InitializeComponent();

            //fill dgv
            //get the start and end of the week so i dont have to do this in a procedure
            DateTime baseDate = DateTime.Now;
            var thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);
            var thisWeekEnd = thisWeekStart.AddDays(7).AddSeconds(-1);
            DateTime start = new DateTime(thisWeekStart.Year, thisWeekStart.Month, thisWeekStart.Day);
            start = start.AddDays(1).AddSeconds(-1);
            DateTime end = new DateTime(thisWeekEnd.Year, thisWeekEnd.Month, thisWeekEnd.Day);
            end = end.AddDays(-1);
            //MessageBox.Show(start.ToString());
            //MessageBox.Show(end.ToString());
            string sql = "select MAX(b.[description]) as[description],MAX(c.finish) as [finish],MAX(d.[NAME]) as [supplier],SUM(a.quantity_same) as [qty] from dbo.door a " +
                " LEFT JOIN dbo.paint_to_door b ON a.id = b.door_id " +
                " LEFT JOIN dbo.paint_finish c ON b.finish_id = c.id " +
                " LEFT JOIN dbo.supplier d ON b.supplier_id = d.id " +
                " where date_paint_complete is null and " +
                " date_paint is not null and " +
                " date_paint > '" + start.ToString("yyyy-MM-dd") + "' AND date_paint < '" + end.ToString("yyyy-MM-dd") + "' " +
                "AND complete_stores = 0 " +
                "AND[description] NOT LIKE '%FREE ISSUE PAINT%' " +
                "AND[description] is not null " +
                //only have selected customers 
                " AND (a.customer_acc_ref LIKE '%BOLT4%' " +
                " OR a.customer_acc_ref LIKE '%CALEDON%' " +
                "OR a.customer_acc_ref LIKE '%DOVE2%' " +
                "OR a.customer_acc_ref LIKE '%FAD%'  " +
                "OR a.customer_acc_ref LIKE '%JODAN%' " +
                "OR a.customer_acc_ref LIKE '%JOHNRE%' " +
                "OR a.customer_acc_ref LIKE '%ROTEC%' " +
                "OR a.customer_acc_ref LIKE '%SUNRAY%'" +
                " OR a.customer_acc_ref LIKE '%STRONDOR%')" +
                "GROUP BY b.description,c.finish,d.[NAME] " +
                "ORDER BY qty DESC";
            MessageBox.Show(sql);
            using (SqlConnection CONNECT = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand CMD = new SqlCommand(sql, CONNECT))
                {
                    DataTable DT = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(CMD);
                    CONNECT.Open();
                    CMD.ExecuteNonQuery();
                    DA.Fill(DT);
                    CONNECT.Close();
                    //add column here if i need to (DT.columns.Add(new DataColumn("header",typeof(double)));
                    dataGridView1.DataSource = DT;
                    //autoSizeForm();
                    //format();
                    dataGridView1.AutoSize = true;
                    format();


                }
            }
        }


        private void autoSizeForm()
        {//unlock the dgv autosize and use the new size to capture the size for the form
            Size dgvSize = getSizeDGV();
            this.ClientSize = dgvSize;


        }
        protected Size getSizeDGV()
        {
            DockStyle dock = dataGridView1.Dock;
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.AutoSize = true;

            Size contentSize = dataGridView1.Size;
            //dataGridView1.AutoSize = false;
            // dataGridView1.Dock = dock;
            return contentSize;
        }

        private void format()
        {
            dataGridView1.Columns[0].HeaderText = "Description";

            dataGridView1.Columns[1].HeaderText = "Finish";
            dataGridView1.Columns[2].HeaderText = "Supplier";
            dataGridView1.Columns[3].HeaderText = "Quantity";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btn_screenshot_Click(object sender, EventArgs e)
        {
            btn_screenshot.Enabled = false;
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"c:\temp\screenshot.png");
            }
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.Print();
            this.Close();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"c:\temp\screenshot.png");
            Point location = new Point(100, 200);
            e.Graphics.DrawImage(img, location);  //e.MarginBounds for fullscreen (breaks if its a small form)
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            label_test rpt = new label_test();
            //PrinterSettings printer = new PrinterSettings;
            //rpt.PrintOptions.PrinterName = @"\\192.168.0.217\ZDesigner GK420d";
            // printer.PrinterName = @"\\192.168.0.217\ZDesigner GK420d";
            //rpt.PrintToPrinter(1, false, 0, 0); //this works well for auto printing
            string printerName = @"\\192.168.0.217\ZDesigner GK420d";
            rpt.Load("label_test");
            System.Drawing.Printing.PrinterSettings printerSettings = new System.Drawing.Printing.PrinterSettings();
            printerSettings.PrinterName = printerName;
            rpt.PrintToPrinter(printerSettings, new PageSettings(), false);
            



        }
    }
}
