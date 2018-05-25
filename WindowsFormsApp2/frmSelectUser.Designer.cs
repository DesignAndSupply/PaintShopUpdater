namespace WindowsFormsApp2
{
    partial class frmSelectUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.cviewpaintingstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new WindowsFormsApp2.user_infoDataSet();
            this.c_view_painting_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a user being continuing";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cviewpaintingstaffBindingSource, "id", true));
            this.cmbStaff.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cviewpaintingstaffBindingSource, "fullname", true));
            this.cmbStaff.DataSource = this.cviewpaintingstaffBindingSource;
            this.cmbStaff.DisplayMember = "fullname";
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(33, 48);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(180, 21);
            this.cmbStaff.TabIndex = 1;
            // 
            // cviewpaintingstaffBindingSource
            // 
            this.cviewpaintingstaffBindingSource.DataMember = "c_view_painting_staff";
            this.cviewpaintingstaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_view_painting_staffTableAdapter
            // 
            this.c_view_painting_staffTableAdapter.ClearBeforeFill = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(109, 76);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "button1";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmSelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 114);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select User";
            this.Load += new System.EventHandler(this.frmSelectUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStaff;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter c_view_painting_staffTableAdapter;
        private System.Windows.Forms.Button btnGo;
    }
}