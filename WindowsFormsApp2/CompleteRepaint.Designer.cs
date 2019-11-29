namespace WindowsFormsApp2
{
    partial class CompleteRepaint
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
            this.cmbRepaintBy = new System.Windows.Forms.ComboBox();
            this.cviewpaintingstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new WindowsFormsApp2.user_infoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKgs = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtDoorID = new System.Windows.Forms.TextBox();
            this.txtPaintID = new System.Windows.Forms.TextBox();
            this.txtRepaintID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.c_view_painting_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter();
            this.grpSand = new System.Windows.Forms.GroupBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.lblSandBy = new System.Windows.Forms.Label();
            this.cmbTool = new System.Windows.Forms.ComboBox();
            this.vibrationtoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet1 = new WindowsFormsApp2.order_databaseDataSet1();
            this.cmbSandBy = new System.Windows.Forms.ComboBox();
            this.SandingStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMins = new System.Windows.Forms.Label();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.vibration_toolsTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.vibration_toolsTableAdapter();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartmentResponsible = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpSand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vibrationtoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandingStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRepaintBy
            // 
            this.cmbRepaintBy.DataSource = this.cviewpaintingstaffBindingSource;
            this.cmbRepaintBy.DisplayMember = "fullname";
            this.cmbRepaintBy.FormattingEnabled = true;
            this.cmbRepaintBy.Location = new System.Drawing.Point(148, 108);
            this.cmbRepaintBy.Name = "cmbRepaintBy";
            this.cmbRepaintBy.Size = new System.Drawing.Size(210, 21);
            this.cmbRepaintBy.TabIndex = 8;
            this.cmbRepaintBy.ValueMember = "id";
            this.cmbRepaintBy.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRepaintBy_Validating);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repaint By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kgs Used:";
            // 
            // txtKgs
            // 
            this.txtKgs.Location = new System.Drawing.Point(148, 136);
            this.txtKgs.Name = "txtKgs";
            this.txtKgs.Size = new System.Drawing.Size(72, 20);
            this.txtKgs.TabIndex = 11;
            this.txtKgs.Validating += new System.ComponentModel.CancelEventHandler(this.txtKgs_Validating);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(396, 505);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            this.btnComplete.Validating += new System.ComponentModel.CancelEventHandler(this.BtnComplete_Validating);
            // 
            // txtDoorID
            // 
            this.txtDoorID.Enabled = false;
            this.txtDoorID.Location = new System.Drawing.Point(148, 23);
            this.txtDoorID.Name = "txtDoorID";
            this.txtDoorID.Size = new System.Drawing.Size(72, 20);
            this.txtDoorID.TabIndex = 13;
            // 
            // txtPaintID
            // 
            this.txtPaintID.Enabled = false;
            this.txtPaintID.Location = new System.Drawing.Point(148, 49);
            this.txtPaintID.Name = "txtPaintID";
            this.txtPaintID.Size = new System.Drawing.Size(72, 20);
            this.txtPaintID.TabIndex = 14;
            // 
            // txtRepaintID
            // 
            this.txtRepaintID.Enabled = false;
            this.txtRepaintID.Location = new System.Drawing.Point(148, 75);
            this.txtRepaintID.Name = "txtRepaintID";
            this.txtRepaintID.Size = new System.Drawing.Size(72, 20);
            this.txtRepaintID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Door ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Paint Stock Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Repaint ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // c_view_painting_staffTableAdapter
            // 
            this.c_view_painting_staffTableAdapter.ClearBeforeFill = true;
            // 
            // grpSand
            // 
            this.grpSand.Controls.Add(this.lblTool);
            this.grpSand.Controls.Add(this.lblSandBy);
            this.grpSand.Controls.Add(this.cmbTool);
            this.grpSand.Controls.Add(this.cmbSandBy);
            this.grpSand.Controls.Add(this.lblMins);
            this.grpSand.Controls.Add(this.txtMins);
            this.grpSand.Controls.Add(this.rdoNo);
            this.grpSand.Controls.Add(this.rdoYes);
            this.grpSand.Location = new System.Drawing.Point(15, 339);
            this.grpSand.Name = "grpSand";
            this.grpSand.Size = new System.Drawing.Size(456, 160);
            this.grpSand.TabIndex = 19;
            this.grpSand.TabStop = false;
            this.grpSand.Text = "Sanding Required";
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(192, 122);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(56, 13);
            this.lblTool.TabIndex = 21;
            this.lblTool.Text = "Tool Used";
            // 
            // lblSandBy
            // 
            this.lblSandBy.AutoSize = true;
            this.lblSandBy.Location = new System.Drawing.Point(192, 95);
            this.lblSandBy.Name = "lblSandBy";
            this.lblSandBy.Size = new System.Drawing.Size(62, 13);
            this.lblSandBy.TabIndex = 15;
            this.lblSandBy.Text = "Sanded By:";
            // 
            // cmbTool
            // 
            this.cmbTool.DataSource = this.vibrationtoolsBindingSource;
            this.cmbTool.DisplayMember = "description";
            this.cmbTool.FormattingEnabled = true;
            this.cmbTool.Location = new System.Drawing.Point(255, 119);
            this.cmbTool.Name = "cmbTool";
            this.cmbTool.Size = new System.Drawing.Size(194, 21);
            this.cmbTool.TabIndex = 20;
            this.cmbTool.ValueMember = "exposure_points_ph";
            // 
            // vibrationtoolsBindingSource
            // 
            this.vibrationtoolsBindingSource.DataMember = "vibration_tools";
            this.vibrationtoolsBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // order_databaseDataSet1
            // 
            this.order_databaseDataSet1.DataSetName = "order_databaseDataSet1";
            this.order_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSandBy
            // 
            this.cmbSandBy.DataSource = this.SandingStaffBindingSource;
            this.cmbSandBy.DisplayMember = "fullname";
            this.cmbSandBy.FormattingEnabled = true;
            this.cmbSandBy.Location = new System.Drawing.Point(255, 92);
            this.cmbSandBy.Name = "cmbSandBy";
            this.cmbSandBy.Size = new System.Drawing.Size(194, 21);
            this.cmbSandBy.TabIndex = 14;
            this.cmbSandBy.ValueMember = "id";
            // 
            // SandingStaffBindingSource
            // 
            this.SandingStaffBindingSource.DataMember = "c_view_painting_staff";
            this.SandingStaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(10, 95);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(117, 13);
            this.lblMins.TabIndex = 3;
            this.lblMins.Text = "Minutes Spent Sanding";
            // 
            // txtMins
            // 
            this.txtMins.Location = new System.Drawing.Point(133, 92);
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(53, 20);
            this.txtMins.TabIndex = 2;
            this.txtMins.Text = "0";
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Checked = true;
            this.rdoNo.Location = new System.Drawing.Point(13, 61);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(39, 17);
            this.rdoNo.TabIndex = 1;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            this.rdoNo.CheckedChanged += new System.EventHandler(this.rdoNo_CheckedChanged);
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Enabled = false;
            this.rdoYes.Location = new System.Drawing.Point(13, 28);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(43, 17);
            this.rdoYes.TabIndex = 0;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            this.rdoYes.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // vibration_toolsTableAdapter
            // 
            this.vibration_toolsTableAdapter.ClearBeforeFill = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(148, 166);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(344, 126);
            this.txtReason.TabIndex = 20;
            this.txtReason.Validating += new System.ComponentModel.CancelEventHandler(this.TxtReason_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reason for repaint:";
            // 
            // cmbDepartmentResponsible
            // 
            this.cmbDepartmentResponsible.FormattingEnabled = true;
            this.cmbDepartmentResponsible.Items.AddRange(new object[] {
            "Office",
            "Welding",
            "Dressing",
            "Painting",
            "Packing"});
            this.cmbDepartmentResponsible.Location = new System.Drawing.Point(148, 299);
            this.cmbDepartmentResponsible.Name = "cmbDepartmentResponsible";
            this.cmbDepartmentResponsible.Size = new System.Drawing.Size(172, 21);
            this.cmbDepartmentResponsible.TabIndex = 22;
            this.cmbDepartmentResponsible.Validating += new System.ComponentModel.CancelEventHandler(this.CmbDepartmentResponsible_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Department Responsible";
            // 
            // CompleteRepaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDepartmentResponsible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.grpSand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRepaintID);
            this.Controls.Add(this.txtPaintID);
            this.Controls.Add(this.txtDoorID);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtKgs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRepaintBy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompleteRepaint";
            this.Text = "CompleteRepaint";
            this.Load += new System.EventHandler(this.CompleteRepaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpSand.ResumeLayout(false);
            this.grpSand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vibrationtoolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandingStaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRepaintBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKgs;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtDoorID;
        private System.Windows.Forms.TextBox txtPaintID;
        private System.Windows.Forms.TextBox txtRepaintID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter c_view_painting_staffTableAdapter;
        private System.Windows.Forms.GroupBox grpSand;
        private System.Windows.Forms.Label lblSandBy;
        private System.Windows.Forms.ComboBox cmbSandBy;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.ComboBox cmbTool;
        private order_databaseDataSet1 order_databaseDataSet1;
        private System.Windows.Forms.BindingSource vibrationtoolsBindingSource;
        private order_databaseDataSet1TableAdapters.vibration_toolsTableAdapter vibration_toolsTableAdapter;
        private System.Windows.Forms.BindingSource SandingStaffBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartmentResponsible;
    }
}