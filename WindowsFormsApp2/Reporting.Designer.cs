namespace WindowsFormsApp2
{
    partial class Reporting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.c_view_late_paintingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet1 = new WindowsFormsApp2.order_databaseDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDailyRepaints = new System.Windows.Forms.Button();
            this.btnLates = new System.Windows.Forms.Button();
            this.btnPaintNext = new System.Windows.Forms.Button();
            this.c_view_daily_repaintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_repaints_outstandingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_repaint_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_repaint_listTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_repaint_listTableAdapter();
            this.c_view_repaints_outstandingTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_repaints_outstandingTableAdapter();
            this.c_view_daily_repaintsTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_daily_repaintsTableAdapter();
            this.c_view_late_paintingTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_late_paintingTableAdapter();
            this.view_paint_nextTableAdapter1 = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.view_paint_nextTableAdapter();
            this.paintNextBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c_view_late_paintingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_daily_repaintsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_repaints_outstandingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_repaint_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintNextBS)).BeginInit();
            this.SuspendLayout();
            // 
            // c_view_late_paintingBindingSource
            // 
            this.c_view_late_paintingBindingSource.DataMember = "c_view_late_painting";
            this.c_view_late_paintingBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // order_databaseDataSet1
            // 
            this.order_databaseDataSet1.DataSetName = "order_databaseDataSet1";
            this.order_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "LoadPainting";
            reportDataSource2.Value = this.c_view_late_paintingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.LoadPainting.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(12, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1356, 578);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.Reporting_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Outstanding Repaints";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDailyRepaints
            // 
            this.btnDailyRepaints.Location = new System.Drawing.Point(154, 17);
            this.btnDailyRepaints.Name = "btnDailyRepaints";
            this.btnDailyRepaints.Size = new System.Drawing.Size(136, 25);
            this.btnDailyRepaints.TabIndex = 2;
            this.btnDailyRepaints.Text = "Todays Repaints";
            this.btnDailyRepaints.UseVisualStyleBackColor = true;
            this.btnDailyRepaints.Click += new System.EventHandler(this.btnDailyRepaints_Click);
            // 
            // btnLates
            // 
            this.btnLates.Enabled = false;
            this.btnLates.Location = new System.Drawing.Point(296, 17);
            this.btnLates.Name = "btnLates";
            this.btnLates.Size = new System.Drawing.Size(136, 25);
            this.btnLates.TabIndex = 3;
            this.btnLates.Text = "Current Load";
            this.btnLates.UseVisualStyleBackColor = true;
            this.btnLates.Click += new System.EventHandler(this.btnLates_Click);
            // 
            // btnPaintNext
            // 
            this.btnPaintNext.Location = new System.Drawing.Point(438, 17);
            this.btnPaintNext.Name = "btnPaintNext";
            this.btnPaintNext.Size = new System.Drawing.Size(136, 25);
            this.btnPaintNext.TabIndex = 4;
            this.btnPaintNext.Text = "Paint Next";
            this.btnPaintNext.UseVisualStyleBackColor = true;
            this.btnPaintNext.Click += new System.EventHandler(this.btnPaintNext_Click);
            // 
            // c_view_daily_repaintsBindingSource
            // 
            this.c_view_daily_repaintsBindingSource.DataMember = "c_view_daily_repaints";
            this.c_view_daily_repaintsBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // c_view_repaints_outstandingBindingSource
            // 
            this.c_view_repaints_outstandingBindingSource.DataMember = "c_view_repaints_outstanding";
            this.c_view_repaints_outstandingBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // c_view_repaint_listBindingSource
            // 
            this.c_view_repaint_listBindingSource.DataMember = "c_view_repaint_list";
            this.c_view_repaint_listBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // c_view_repaint_listTableAdapter
            // 
            this.c_view_repaint_listTableAdapter.ClearBeforeFill = true;
            // 
            // c_view_repaints_outstandingTableAdapter
            // 
            this.c_view_repaints_outstandingTableAdapter.ClearBeforeFill = true;
            // 
            // c_view_daily_repaintsTableAdapter
            // 
            this.c_view_daily_repaintsTableAdapter.ClearBeforeFill = true;
            // 
            // c_view_late_paintingTableAdapter
            // 
            this.c_view_late_paintingTableAdapter.ClearBeforeFill = true;
            // 
            // view_paint_nextTableAdapter1
            // 
            this.view_paint_nextTableAdapter1.ClearBeforeFill = true;
            // 
            // paintNextBS
            // 
            this.paintNextBS.DataMember = "view_paint_next";
            this.paintNextBS.DataSource = this.order_databaseDataSet1;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 654);
            this.Controls.Add(this.btnPaintNext);
            this.Controls.Add(this.btnLates);
            this.Controls.Add(this.btnDailyRepaints);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.Reporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_view_late_paintingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_daily_repaintsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_repaints_outstandingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_view_repaint_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintNextBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource c_view_repaint_listBindingSource;
        private order_databaseDataSet1 order_databaseDataSet1;
        private order_databaseDataSet1TableAdapters.c_view_repaint_listTableAdapter c_view_repaint_listTableAdapter;
        private System.Windows.Forms.BindingSource c_view_repaints_outstandingBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_repaints_outstandingTableAdapter c_view_repaints_outstandingTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDailyRepaints;
        private System.Windows.Forms.BindingSource c_view_daily_repaintsBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_daily_repaintsTableAdapter c_view_daily_repaintsTableAdapter;
        private System.Windows.Forms.Button btnLates;
        private System.Windows.Forms.BindingSource c_view_late_paintingBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_late_paintingTableAdapter c_view_late_paintingTableAdapter;
        private System.Windows.Forms.Button btnPaintNext;
        private order_databaseDataSet1TableAdapters.view_paint_nextTableAdapter view_paint_nextTableAdapter1;
        private System.Windows.Forms.BindingSource paintNextBS;
    }
}