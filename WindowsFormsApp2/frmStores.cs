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
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class frmStores : Form
    {

        public bool alreadyPrinted { get; set; }
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


        private void printLabels()
        {
            //first we need to grab the data we need and dump it into a random fucking dgv 
            //same sql as the one on load but thiis bad boy doesnt have a group on it
            DateTime baseDate = DateTime.Now;
            var thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);
            var thisWeekEnd = thisWeekStart.AddDays(7).AddSeconds(-1);
            DateTime start = new DateTime(thisWeekStart.Year, thisWeekStart.Month, thisWeekStart.Day);
            start = start.AddDays(1).AddSeconds(-1);
            DateTime end = new DateTime(thisWeekEnd.Year, thisWeekEnd.Month, thisWeekEnd.Day);
            end = end.AddDays(-1);
            //MessageBox.Show(start.ToString());
            //MessageBox.Show(end.ToString());
            string sql = "select b.[description], a.id ,(d.[NAME]) as [supplier] , (c.finish) as [finish] from dbo.door a " +
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
                "order by a.id";
            // MessageBox.Show(sql);
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
                    hiddenDGV.DataSource = DT;
                    //autoSizeForm();
                    //format();                    
                }
            }
            //now we start printing like a mad man#
            for (int i = 0; i < hiddenDGV.Rows.Count; i++)
            {
                //first check if this door label has been printed 
                checkDoor(hiddenDGV.Rows[i].Cells[1].Value.ToString());
                if (alreadyPrinted == false)
                {
                    label_test rpt = new label_test();
                    string RAL = hiddenDGV.Rows[i].Cells[0].Value.ToString();
                    string DOOR = hiddenDGV.Rows[i].Cells[1].Value.ToString();
                    string FINISH = hiddenDGV.Rows[i].Cells[3].Value.ToString();
                    string SUPPLIER = hiddenDGV.Rows[i].Cells[2].Value.ToString();
                    rpt.SetParameterValue("RALCOLOUR", RAL);
                    rpt.SetParameterValue("SUPPLIER", "Supplier: " + SUPPLIER);
                    rpt.SetParameterValue("FINISH", "Finish: " + FINISH);
                    rpt.SetParameterValue("DOORNUMBER", "Door Number: " + DOOR);
                    rpt.PrintToPrinter(1, false, 0, 0); //this works well for auto printing
                    insertINTO(DOOR);
                    return;
                }
                else
                    continue;
                //after printing this label add this row to the new table with the repaint set to -1
                
            }
        }

        private void insertINTO(string doorID)
        {
            string sql = "INSERT INTO dbo.door_paint_label_printed (door_id,label_printed,label_print_date) VALUES (" + doorID + ",-1,CAST(GETDATE() as DateTime))"; //check the date time here
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }

        private void checkDoor(string doorID)
        {
            string sql = "SELECT COALESCE(label_printed,0) from dbo.door_paint_label_printed WHERE door_id = " + doorID;
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    int temp = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (temp == -1)
                        alreadyPrinted = true;
                    else
                        alreadyPrinted = false;

                }
            }
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            int i = 60;
            printLabels();
            //PrinterSettings printer = new PrinterSettings;
            //rpt.PrintOptions.PrinterName = @"\\192.168.0.217\ZDesigner GK420d";
            // printer.PrinterName = @"\\192.168.0.217\ZDesigner GK420d";



            //golden code
            //rpt.SetParameterValue("RALCOLOUR", "test number + " + i.ToString() + "!");
            //rpt.SetParameterValue("DOORNUMBER", "636363");
            //rpt.PrintToPrinter(1, false, 0, 0); //this works well for auto printing
            /////////////////////////////


            //string printerName = @"\\192.168.0.217\ZDesigner GK420d";
            //rpt.Load("label_test");
            //System.Drawing.Printing.PrinterSettings printerSettings = new System.Drawing.Printing.PrinterSettings();
            //printerSettings.PrinterName = printerName;
            //rpt.PrintToPrinter(printerSettings, new PageSettings(), false);




        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            //here we open a form to look for a label thats been printed already ...
            frmReprintSearch frm = new frmReprintSearch();
            frm.ShowDialog();
                        
        }

        private void btnDoorSearch_Click(object sender, EventArgs e)
        {
            //form to search for a door i guess?
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter a door number!", "Door Number", "0", 500, 500);
            if (IsDigitsOnly(input) == true)
            {
                //print labels and stuffs
                string doorID = "";
                string RAL = "";
                string FINISH = "";
                string SUPPLIER = "";
                //get the DOOR ID from the lit up dgv
                doorID = input;

                //test print i guess?
                string sql = "select b.[description], a.id ,(d.[NAME]) as [supplier] , (c.finish) as [finish] from dbo.door a " +
                    " LEFT JOIN dbo.paint_to_door b ON a.id = b.door_id " +
                    " LEFT JOIN dbo.paint_finish c ON b.finish_id = c.id " +
                    " LEFT JOIN dbo.supplier d ON b.supplier_id = d.id " +
                    "WHERE  complete_stores = 0 " +
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
                    " AND a.id = " + doorID + " " +
                    "order by a.id";
                using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            RAL = Convert.ToString(dr["description"]);
                            FINISH = Convert.ToString(dr["finish"]);
                            SUPPLIER = Convert.ToString(dr["supplier"]);
                        }
                    }
                }
                //first we need to get the values that get printed :)
                label_test rpt = new label_test();

                rpt.SetParameterValue("RALCOLOUR", RAL);
                rpt.SetParameterValue("SUPPLIER", "Supplier: " + SUPPLIER);
                rpt.SetParameterValue("FINISH", "Finish: " + FINISH);
                rpt.SetParameterValue("DOORNUMBER", "Door Number: " + doorID);
                rpt.PrintToPrinter(1, false, 0, 0); //this works well for auto printing



                //before closing we need to mark as repaint if it is not there

                this.Close();
            }
            else
                MessageBox.Show("Please only enter numbers!", "ERROR", MessageBoxButtons.OK);
        }

        bool IsDigitsOnly (string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
