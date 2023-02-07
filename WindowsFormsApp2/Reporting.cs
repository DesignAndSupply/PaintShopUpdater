using Microsoft.Reporting.WinForms;
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
    public partial class Reporting : Form
    {


        public Reporting()
        {
            InitializeComponent();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_late_painting' table. You can move, or remove it, as needed.

            order_databaseDataSet1.EnforceConstraints = false;
            this.c_view_late_paintingTableAdapter.Fill(this.order_databaseDataSet1.c_view_late_painting);

            this.view_paint_nextTableAdapter1.Fill(this.order_databaseDataSet1.view_paint_next);

            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_daily_repaints' table. You can move, or remove it, as needed.
            this.c_view_daily_repaintsTableAdapter.Fill(this.order_databaseDataSet1.c_view_daily_repaints);
            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_repaints_outstanding' table. You can move, or remove it, as needed.
            this.c_view_repaints_outstandingTableAdapter.Fill(this.order_databaseDataSet1.c_view_repaints_outstanding);
            // TODO: This line of code loads data into the 'order_databaseDataSet1.c_view_repaint_list' table. You can move, or remove it, as needed.
            this.c_view_repaint_listTableAdapter.Fill(this.order_databaseDataSet1.c_view_repaint_list);

            this.reportViewer1.RefreshReport();
            paintNext();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            ReportDataSource RDC = new ReportDataSource();
            RDC.Name = "DataSet1";
            RDC.Value = this.c_view_repaints_outstandingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(RDC);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.rptOutstandingRepaints.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void btnDailyRepaints_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            ReportDataSource RDC = new ReportDataSource();
            RDC.Name = "DailyRepaints";
            RDC.Value = this.c_view_daily_repaintsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(RDC);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.rptDailyRepaints.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void updateReportViewer()
        {

        }

        private void btnLates_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            ReportDataSource RDC = new ReportDataSource();
            RDC.Name = "LoadPainting";
            RDC.Value = this.c_view_late_paintingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(RDC);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.LoadPainting.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void btnPaintNext_Click(object sender, EventArgs e)
        {
            paintNext();
        }

        private void paintNext()
        {
            reportViewer1.Reset();
            ReportDataSource RDC = new ReportDataSource();
            RDC.Name = "PaintNextDS";
            RDC.Value = this.paintNextBS;
            this.reportViewer1.LocalReport.DataSources.Add(RDC);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.rptPaintNextList.rdlc";
            
            this.reportViewer1.RefreshReport();
        }
    }
}
