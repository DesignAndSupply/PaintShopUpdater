namespace WindowsFormsApp2
{
    partial class frmTimeAllocation
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
            this.order_databaseDataSet1 = new WindowsFormsApp2.order_databaseDataSet1();
            this.cviewpaintingsectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_painting_sectionsTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_painting_sectionsTableAdapter();
            this.user_infoDataSet = new WindowsFormsApp2.user_infoDataSet();
            this.cviewpaintingstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_painting_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter();
            this.grpbxStaff = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingsectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).BeginInit();
            this.grpbxStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // order_databaseDataSet1
            // 
            this.order_databaseDataSet1.DataSetName = "order_databaseDataSet1";
            this.order_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cviewpaintingsectionsBindingSource
            // 
            this.cviewpaintingsectionsBindingSource.DataMember = "c_view_painting_sections";
            this.cviewpaintingsectionsBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // c_view_painting_sectionsTableAdapter
            // 
            this.c_view_painting_sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cviewpaintingstaffBindingSource
            // 
            this.cviewpaintingstaffBindingSource.DataMember = "c_view_painting_staff";
            this.cviewpaintingstaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // c_view_painting_staffTableAdapter
            // 
            this.c_view_painting_staffTableAdapter.ClearBeforeFill = true;
            // 
            // grpbxStaff
            // 
            this.grpbxStaff.Controls.Add(this.cmbStaff);
            this.grpbxStaff.Location = new System.Drawing.Point(42, 144);
            this.grpbxStaff.Name = "grpbxStaff";
            this.grpbxStaff.Size = new System.Drawing.Size(209, 70);
            this.grpbxStaff.TabIndex = 0;
            this.grpbxStaff.TabStop = false;
            this.grpbxStaff.Text = "Select Staff Member";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "S:\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(110, 220);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(73, 31);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(17, 32);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(172, 21);
            this.cmbStaff.TabIndex = 6;
            // 
            // frmTimeAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbxStaff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimeAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Allocation";
            this.Load += new System.EventHandler(this.frmTimeAllocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingsectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).EndInit();
            this.grpbxStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private order_databaseDataSet1 order_databaseDataSet1;
        private System.Windows.Forms.BindingSource cviewpaintingsectionsBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_painting_sectionsTableAdapter c_view_painting_sectionsTableAdapter;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter c_view_painting_staffTableAdapter;
        private System.Windows.Forms.GroupBox grpbxStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbStaff;
    }
}