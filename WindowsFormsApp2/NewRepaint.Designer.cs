namespace WindowsFormsApp2
{
    partial class NewRepaint
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
            this.txtDoorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dteRepaintDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cviewcurrentshopfloorstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new WindowsFormsApp2.user_infoDataSet();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dslkpiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsl_kpiDataSet = new WindowsFormsApp2.dsl_kpiDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRepaintBy = new System.Windows.Forms.ComboBox();
            this.cviewpaintingstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKgs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.c_view_painting_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.userTableAdapter();
            this.c_view_current_shop_floor_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_current_shop_floor_staffTableAdapter();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new WindowsFormsApp2.dsl_kpiDataSetTableAdapters.departmentTableAdapter();
            this.cmbLoggedBy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSand = new System.Windows.Forms.GroupBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.cmbTool = new System.Windows.Forms.ComboBox();
            this.vibrationtoolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet1 = new WindowsFormsApp2.order_databaseDataSet1();
            this.lblSandBy = new System.Windows.Forms.Label();
            this.cmbSandBy = new System.Windows.Forms.ComboBox();
            this.SandingStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMins = new System.Windows.Forms.Label();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.vibration_toolsTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.vibration_toolsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cviewcurrentshopfloorstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslkpiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsl_kpiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpSand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vibrationtoolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandingStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoorId
            // 
            this.txtDoorId.Location = new System.Drawing.Point(89, 20);
            this.txtDoorId.Name = "txtDoorId";
            this.txtDoorId.Size = new System.Drawing.Size(51, 20);
            this.txtDoorId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Door ID:";
            // 
            // dteRepaintDate
            // 
            this.dteRepaintDate.Location = new System.Drawing.Point(89, 46);
            this.dteRepaintDate.Name = "dteRepaintDate";
            this.dteRepaintDate.Size = new System.Drawing.Size(187, 20);
            this.dteRepaintDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repaint Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Location = new System.Drawing.Point(15, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accountability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Accountable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department Accountable:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DataSource = this.cviewcurrentshopfloorstaffBindingSource;
            this.cmbEmployee.DisplayMember = "fullname";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(137, 62);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(319, 21);
            this.cmbEmployee.TabIndex = 1;
            this.cmbEmployee.ValueMember = "id";
            // 
            // cviewcurrentshopfloorstaffBindingSource
            // 
            this.cviewcurrentshopfloorstaffBindingSource.DataMember = "c_view_current_shop_floor_staff";
            this.cviewcurrentshopfloorstaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DataSource = this.departmentBindingSource1;
            this.cmbDepartment.DisplayMember = "department_name";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(137, 35);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(319, 21);
            this.cmbDepartment.TabIndex = 0;
            this.cmbDepartment.ValueMember = "id";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            this.departmentBindingSource1.DataSource = this.dslkpiDataSetBindingSource;
            // 
            // dslkpiDataSetBindingSource
            // 
            this.dslkpiDataSetBindingSource.DataSource = this.dsl_kpiDataSet;
            this.dslkpiDataSetBindingSource.Position = 0;
            // 
            // dsl_kpiDataSet
            // 
            this.dsl_kpiDataSet.DataSetName = "dsl_kpiDataSet";
            this.dsl_kpiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reason for repaint:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(22, 230);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(455, 87);
            this.txtReason.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Repaint By:";
            // 
            // cmbRepaintBy
            // 
            this.cmbRepaintBy.DataSource = this.cviewpaintingstaffBindingSource;
            this.cmbRepaintBy.DisplayMember = "fullname";
            this.cmbRepaintBy.FormattingEnabled = true;
            this.cmbRepaintBy.Location = new System.Drawing.Point(152, 330);
            this.cmbRepaintBy.Name = "cmbRepaintBy";
            this.cmbRepaintBy.Size = new System.Drawing.Size(326, 21);
            this.cmbRepaintBy.TabIndex = 7;
            this.cmbRepaintBy.ValueMember = "id";
            // 
            // cviewpaintingstaffBindingSource
            // 
            this.cviewpaintingstaffBindingSource.DataMember = "c_view_painting_staff";
            this.cviewpaintingstaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // txtKgs
            // 
            this.txtKgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtKgs.Location = new System.Drawing.Point(152, 357);
            this.txtKgs.Name = "txtKgs";
            this.txtKgs.Size = new System.Drawing.Size(56, 20);
            this.txtKgs.TabIndex = 8;
            this.txtKgs.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "KGs Used:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // c_view_painting_staffTableAdapter
            // 
            this.c_view_painting_staffTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.user_infoDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // c_view_current_shop_floor_staffTableAdapter
            // 
            this.c_view_current_shop_floor_staffTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.dslkpiDataSetBindingSource;
            this.departmentBindingSource.CurrentChanged += new System.EventHandler(this.departmentBindingSource_CurrentChanged);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLoggedBy
            // 
            this.cmbLoggedBy.DataSource = this.cviewpaintingstaffBindingSource;
            this.cmbLoggedBy.DisplayMember = "fullname";
            this.cmbLoggedBy.FormattingEnabled = true;
            this.cmbLoggedBy.Location = new System.Drawing.Point(152, 554);
            this.cmbLoggedBy.Name = "cmbLoggedBy";
            this.cmbLoggedBy.Size = new System.Drawing.Size(244, 21);
            this.cmbLoggedBy.TabIndex = 11;
            this.cmbLoggedBy.ValueMember = "id";
            this.cmbLoggedBy.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Logged By:";
            this.label8.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpSand
            // 
            this.grpSand.Controls.Add(this.lblTool);
            this.grpSand.Controls.Add(this.cmbTool);
            this.grpSand.Controls.Add(this.lblSandBy);
            this.grpSand.Controls.Add(this.cmbSandBy);
            this.grpSand.Controls.Add(this.lblMins);
            this.grpSand.Controls.Add(this.txtMins);
            this.grpSand.Controls.Add(this.rdoNo);
            this.grpSand.Controls.Add(this.rdoYes);
            this.grpSand.Location = new System.Drawing.Point(22, 388);
            this.grpSand.Name = "grpSand";
            this.grpSand.Size = new System.Drawing.Size(456, 158);
            this.grpSand.TabIndex = 13;
            this.grpSand.TabStop = false;
            this.grpSand.Text = "Sanding Required";
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Location = new System.Drawing.Point(192, 122);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(56, 13);
            this.lblTool.TabIndex = 17;
            this.lblTool.Text = "Tool Used";
            // 
            // cmbTool
            // 
            this.cmbTool.DataSource = this.vibrationtoolsBindingSource;
            this.cmbTool.DisplayMember = "description";
            this.cmbTool.FormattingEnabled = true;
            this.cmbTool.Location = new System.Drawing.Point(255, 119);
            this.cmbTool.Name = "cmbTool";
            this.cmbTool.Size = new System.Drawing.Size(194, 21);
            this.cmbTool.TabIndex = 16;
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
            // lblSandBy
            // 
            this.lblSandBy.AutoSize = true;
            this.lblSandBy.Location = new System.Drawing.Point(192, 95);
            this.lblSandBy.Name = "lblSandBy";
            this.lblSandBy.Size = new System.Drawing.Size(62, 13);
            this.lblSandBy.TabIndex = 15;
            this.lblSandBy.Text = "Sanded By:";
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
            this.txtMins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            // NewRepaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 584);
            this.Controls.Add(this.grpSand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbLoggedBy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKgs);
            this.Controls.Add(this.cmbRepaintBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dteRepaintDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoorId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRepaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewRepaint";
            this.Load += new System.EventHandler(this.NewRepaint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cviewcurrentshopfloorstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslkpiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsl_kpiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
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

        private System.Windows.Forms.TextBox txtDoorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteRepaintDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRepaintBy;
        private System.Windows.Forms.TextBox txtKgs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter c_view_painting_staffTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private user_infoDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource cviewcurrentshopfloorstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_current_shop_floor_staffTableAdapter c_view_current_shop_floor_staffTableAdapter;
        private System.Windows.Forms.BindingSource dslkpiDataSetBindingSource;
        private dsl_kpiDataSet dsl_kpiDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private dsl_kpiDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.ComboBox cmbLoggedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grpSand;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.Label lblSandBy;
        private System.Windows.Forms.ComboBox cmbSandBy;
        private System.Windows.Forms.BindingSource SandingStaffBindingSource;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.ComboBox cmbTool;
        private order_databaseDataSet1 order_databaseDataSet1;
        private System.Windows.Forms.BindingSource vibrationtoolsBindingSource;
        private order_databaseDataSet1TableAdapters.vibration_toolsTableAdapter vibration_toolsTableAdapter;
    }
}