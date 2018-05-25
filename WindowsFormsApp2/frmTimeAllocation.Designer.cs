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
            this.lblStaff3 = new System.Windows.Forms.Label();
            this.lblStaff2 = new System.Windows.Forms.Label();
            this.lblStaff1 = new System.Windows.Forms.Label();
            this.rdoStaff3 = new System.Windows.Forms.RadioButton();
            this.rdoStaff2 = new System.Windows.Forms.RadioButton();
            this.rdoStaff1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.grpbxStaff.Controls.Add(this.lblStaff3);
            this.grpbxStaff.Controls.Add(this.lblStaff2);
            this.grpbxStaff.Controls.Add(this.lblStaff1);
            this.grpbxStaff.Controls.Add(this.rdoStaff3);
            this.grpbxStaff.Controls.Add(this.rdoStaff2);
            this.grpbxStaff.Controls.Add(this.rdoStaff1);
            this.grpbxStaff.Location = new System.Drawing.Point(56, 144);
            this.grpbxStaff.Name = "grpbxStaff";
            this.grpbxStaff.Size = new System.Drawing.Size(306, 160);
            this.grpbxStaff.TabIndex = 0;
            this.grpbxStaff.TabStop = false;
            this.grpbxStaff.Text = "Select Staff Member";
            // 
            // lblStaff3
            // 
            this.lblStaff3.AutoSize = true;
            this.lblStaff3.Location = new System.Drawing.Point(38, 106);
            this.lblStaff3.Name = "lblStaff3";
            this.lblStaff3.Size = new System.Drawing.Size(35, 13);
            this.lblStaff3.TabIndex = 5;
            this.lblStaff3.Text = "label1";
            // 
            // lblStaff2
            // 
            this.lblStaff2.AutoSize = true;
            this.lblStaff2.Location = new System.Drawing.Point(38, 73);
            this.lblStaff2.Name = "lblStaff2";
            this.lblStaff2.Size = new System.Drawing.Size(35, 13);
            this.lblStaff2.TabIndex = 4;
            this.lblStaff2.Text = "label1";
            // 
            // lblStaff1
            // 
            this.lblStaff1.AutoSize = true;
            this.lblStaff1.Location = new System.Drawing.Point(38, 39);
            this.lblStaff1.Name = "lblStaff1";
            this.lblStaff1.Size = new System.Drawing.Size(35, 13);
            this.lblStaff1.TabIndex = 3;
            this.lblStaff1.Text = "label1";
            // 
            // rdoStaff3
            // 
            this.rdoStaff3.AutoSize = true;
            this.rdoStaff3.Location = new System.Drawing.Point(18, 106);
            this.rdoStaff3.Name = "rdoStaff3";
            this.rdoStaff3.Size = new System.Drawing.Size(14, 13);
            this.rdoStaff3.TabIndex = 2;
            this.rdoStaff3.TabStop = true;
            this.rdoStaff3.UseVisualStyleBackColor = true;
            // 
            // rdoStaff2
            // 
            this.rdoStaff2.AutoSize = true;
            this.rdoStaff2.Location = new System.Drawing.Point(18, 73);
            this.rdoStaff2.Name = "rdoStaff2";
            this.rdoStaff2.Size = new System.Drawing.Size(14, 13);
            this.rdoStaff2.TabIndex = 1;
            this.rdoStaff2.TabStop = true;
            this.rdoStaff2.UseVisualStyleBackColor = true;
            // 
            // rdoStaff1
            // 
            this.rdoStaff1.AutoSize = true;
            this.rdoStaff1.Location = new System.Drawing.Point(18, 39);
            this.rdoStaff1.Name = "rdoStaff1";
            this.rdoStaff1.Size = new System.Drawing.Size(14, 13);
            this.rdoStaff1.TabIndex = 0;
            this.rdoStaff1.TabStop = true;
            this.rdoStaff1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "S:\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(289, 346);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(73, 31);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmTimeAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 408);
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
            this.grpbxStaff.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdoStaff3;
        private System.Windows.Forms.RadioButton rdoStaff2;
        private System.Windows.Forms.RadioButton rdoStaff1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStaff3;
        private System.Windows.Forms.Label lblStaff2;
        private System.Windows.Forms.Label lblStaff1;
        private System.Windows.Forms.Button btnConfirm;
    }
}