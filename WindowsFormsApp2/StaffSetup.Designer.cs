namespace WindowsFormsApp2
{
    partial class StaffSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgStaffSetup = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cviewpaintingstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new WindowsFormsApp2.user_infoDataSet();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cviewpaintingstaffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cviewpaintingstaffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_painting_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffSetup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStaffSetup
            // 
            this.dgStaffSetup.AllowUserToAddRows = false;
            this.dgStaffSetup.AllowUserToDeleteRows = false;
            this.dgStaffSetup.AllowUserToResizeColumns = false;
            this.dgStaffSetup.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "0";
            this.dgStaffSetup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStaffSetup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStaffSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStaffSetup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgStaffSetup.Location = new System.Drawing.Point(12, 12);
            this.dgStaffSetup.Name = "dgStaffSetup";
            this.dgStaffSetup.Size = new System.Drawing.Size(564, 333);
            this.dgStaffSetup.TabIndex = 64;
            this.dgStaffSetup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStaffSetup_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Column1";
            this.Column1.DataSource = this.cviewpaintingstaffBindingSource;
            this.Column1.DisplayMember = "fullname";
            this.Column1.HeaderText = "Staff 1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.ValueMember = "fullname";
            this.Column1.Width = 162;
            // 
            // cviewpaintingstaffBindingSource
            // 
            this.cviewpaintingstaffBindingSource.DataMember = "c_view_painting_staff";
            this.cviewpaintingstaffBindingSource.DataSource = this.user_infoDataSet;
            this.cviewpaintingstaffBindingSource.CurrentChanged += new System.EventHandler(this.cviewpaintingstaffBindingSource_CurrentChanged);
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Column2";
            this.Column2.DataSource = this.cviewpaintingstaffBindingSource;
            this.Column2.DisplayMember = "fullname";
            this.Column2.HeaderText = "Staff 2";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "fullname";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Column3";
            this.Column3.DataSource = this.cviewpaintingstaffBindingSource;
            this.Column3.DisplayMember = "fullname";
            this.Column3.HeaderText = "Staff 3";
            this.Column3.Name = "Column3";
            this.Column3.ValueMember = "fullname";
            // 
            // cviewpaintingstaffBindingSource1
            // 
            this.cviewpaintingstaffBindingSource1.DataMember = "c_view_painting_staff";
            this.cviewpaintingstaffBindingSource1.DataSource = this.user_infoDataSet;
            // 
            // cviewpaintingstaffBindingSource2
            // 
            this.cviewpaintingstaffBindingSource2.DataMember = "c_view_painting_staff";
            this.cviewpaintingstaffBindingSource2.DataSource = this.user_infoDataSet;
            // 
            // c_view_painting_staffTableAdapter
            // 
            this.c_view_painting_staffTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(582, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(582, 41);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 66;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // StaffSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 357);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgStaffSetup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffSetup";
            this.Load += new System.EventHandler(this.StaffSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffSetup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStaffSetup;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter c_view_painting_staffTableAdapter;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource1;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
    }
}