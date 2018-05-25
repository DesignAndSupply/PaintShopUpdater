namespace WindowsFormsApp2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCompleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oporderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cviewpaintingsectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet1 = new WindowsFormsApp2.order_databaseDataSet1();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cmdOp = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.user_infoDataSet1 = new WindowsFormsApp2.user_infoDataSet();
            this.user_infoDataSet = new WindowsFormsApp2.user_infoDataSet();
            this.cviewpaintingstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_painting_staffTableAdapter = new WindowsFormsApp2.user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter();
            this.btnStaffSetup = new System.Windows.Forms.Button();
            this.dgPaintToDoor = new System.Windows.Forms.DataGridView();
            this.dooridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powderkgsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.freeissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unallocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sideselectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cviewpaintondoorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinishID = new System.Windows.Forms.TextBox();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtDoorType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCompleteDoor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPaintingStatus = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.automatic_report_sent_logTableAdapter1 = new WindowsFormsApp2.order_databaseDataSetTableAdapters.automatic_report_sent_logTableAdapter();
            this.dgProductionProgress = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaintingNote = new System.Windows.Forms.TextBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.c_view_painting_sectionsTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_painting_sectionsTableAdapter();
            this.c_view_paint_on_doorTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_paint_on_doorTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisDoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.looseItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtQuantitySame = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.balanceStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingsectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaintToDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintondoorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "\\\\designsvr1\\apps\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(397, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(830, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(74, 20);
            this.txtSearch.TabIndex = 57;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(910, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 23);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Load Door";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.staff1DataGridViewTextBoxColumn,
            this.staff2DataGridViewTextBoxColumn,
            this.staff3DataGridViewTextBoxColumn,
            this.dateCompleteDataGridViewTextBoxColumn,
            this.oporderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cviewpaintingsectionsBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 279);
            this.dataGridView1.TabIndex = 59;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // staff1DataGridViewTextBoxColumn
            // 
            this.staff1DataGridViewTextBoxColumn.DataPropertyName = "Staff1";
            this.staff1DataGridViewTextBoxColumn.HeaderText = "Staff1";
            this.staff1DataGridViewTextBoxColumn.Name = "staff1DataGridViewTextBoxColumn";
            // 
            // staff2DataGridViewTextBoxColumn
            // 
            this.staff2DataGridViewTextBoxColumn.DataPropertyName = "Staff2";
            this.staff2DataGridViewTextBoxColumn.HeaderText = "Staff2";
            this.staff2DataGridViewTextBoxColumn.Name = "staff2DataGridViewTextBoxColumn";
            // 
            // staff3DataGridViewTextBoxColumn
            // 
            this.staff3DataGridViewTextBoxColumn.DataPropertyName = "Staff3";
            this.staff3DataGridViewTextBoxColumn.HeaderText = "Staff3";
            this.staff3DataGridViewTextBoxColumn.Name = "staff3DataGridViewTextBoxColumn";
            // 
            // dateCompleteDataGridViewTextBoxColumn
            // 
            this.dateCompleteDataGridViewTextBoxColumn.DataPropertyName = "dateComplete";
            this.dateCompleteDataGridViewTextBoxColumn.HeaderText = "dateComplete";
            this.dateCompleteDataGridViewTextBoxColumn.Name = "dateCompleteDataGridViewTextBoxColumn";
            // 
            // oporderDataGridViewTextBoxColumn
            // 
            this.oporderDataGridViewTextBoxColumn.DataPropertyName = "op_order";
            this.oporderDataGridViewTextBoxColumn.HeaderText = "op_order";
            this.oporderDataGridViewTextBoxColumn.Name = "oporderDataGridViewTextBoxColumn";
            // 
            // cviewpaintingsectionsBindingSource
            // 
            this.cviewpaintingsectionsBindingSource.DataMember = "c_view_painting_sections";
            this.cviewpaintingsectionsBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // order_databaseDataSet1
            // 
            this.order_databaseDataSet1.DataSetName = "order_databaseDataSet1";
            this.order_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(991, 25);
            this.fillByToolStrip.TabIndex = 60;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // cmdOp
            // 
            this.cmdOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOp.FormattingEnabled = true;
            this.cmdOp.Items.AddRange(new object[] {
            "Up",
            "Wash/Wipe",
            "Etch",
            "Sand",
            "Powder Prime",
            "Powder Coat",
            "Oven",
            "Wet Prep",
            "Wet Paint",
            "Oven 2"});
            this.cmdOp.Location = new System.Drawing.Point(732, 377);
            this.cmdOp.Name = "cmdOp";
            this.cmdOp.Size = new System.Drawing.Size(163, 21);
            this.cmdOp.TabIndex = 61;
            this.cmdOp.Validating += new System.ComponentModel.CancelEventHandler(this.cmdOp_Validating);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(901, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update Op";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // user_infoDataSet1
            // 
            this.user_infoDataSet1.DataSetName = "user_infoDataSet";
            this.user_infoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnStaffSetup
            // 
            this.btnStaffSetup.Location = new System.Drawing.Point(93, 26);
            this.btnStaffSetup.Name = "btnStaffSetup";
            this.btnStaffSetup.Size = new System.Drawing.Size(91, 23);
            this.btnStaffSetup.TabIndex = 63;
            this.btnStaffSetup.Text = "Staff Setup";
            this.btnStaffSetup.UseVisualStyleBackColor = true;
            this.btnStaffSetup.Visible = false;
            this.btnStaffSetup.Click += new System.EventHandler(this.btnStaffSetup_Click);
            // 
            // dgPaintToDoor
            // 
            this.dgPaintToDoor.AllowUserToAddRows = false;
            this.dgPaintToDoor.AllowUserToDeleteRows = false;
            this.dgPaintToDoor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPaintToDoor.AutoGenerateColumns = false;
            this.dgPaintToDoor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPaintToDoor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaintToDoor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dooridDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.finishDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.powderkgsDataGridViewTextBoxColumn,
            this.wetDataGridViewTextBoxColumn,
            this.freeissueDataGridViewTextBoxColumn,
            this.unallocatedDataGridViewTextBoxColumn,
            this.sideselectionDataGridViewTextBoxColumn});
            this.dgPaintToDoor.DataSource = this.cviewpaintondoorBindingSource;
            this.dgPaintToDoor.Enabled = false;
            this.dgPaintToDoor.Location = new System.Drawing.Point(12, 299);
            this.dgPaintToDoor.Name = "dgPaintToDoor";
            this.dgPaintToDoor.ReadOnly = true;
            this.dgPaintToDoor.Size = new System.Drawing.Size(964, 90);
            this.dgPaintToDoor.TabIndex = 64;
            // 
            // dooridDataGridViewTextBoxColumn
            // 
            this.dooridDataGridViewTextBoxColumn.DataPropertyName = "door_id";
            this.dooridDataGridViewTextBoxColumn.HeaderText = "door_id";
            this.dooridDataGridViewTextBoxColumn.Name = "dooridDataGridViewTextBoxColumn";
            this.dooridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishDataGridViewTextBoxColumn
            // 
            this.finishDataGridViewTextBoxColumn.DataPropertyName = "finish";
            this.finishDataGridViewTextBoxColumn.HeaderText = "finish";
            this.finishDataGridViewTextBoxColumn.Name = "finishDataGridViewTextBoxColumn";
            this.finishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powderkgsDataGridViewTextBoxColumn
            // 
            this.powderkgsDataGridViewTextBoxColumn.DataPropertyName = "powder_kgs";
            this.powderkgsDataGridViewTextBoxColumn.HeaderText = "powder_kgs";
            this.powderkgsDataGridViewTextBoxColumn.Name = "powderkgsDataGridViewTextBoxColumn";
            this.powderkgsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wetDataGridViewTextBoxColumn
            // 
            this.wetDataGridViewTextBoxColumn.DataPropertyName = "wet";
            this.wetDataGridViewTextBoxColumn.HeaderText = "wet";
            this.wetDataGridViewTextBoxColumn.Name = "wetDataGridViewTextBoxColumn";
            this.wetDataGridViewTextBoxColumn.ReadOnly = true;
            this.wetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // freeissueDataGridViewTextBoxColumn
            // 
            this.freeissueDataGridViewTextBoxColumn.DataPropertyName = "free_issue";
            this.freeissueDataGridViewTextBoxColumn.HeaderText = "free_issue";
            this.freeissueDataGridViewTextBoxColumn.Name = "freeissueDataGridViewTextBoxColumn";
            this.freeissueDataGridViewTextBoxColumn.ReadOnly = true;
            this.freeissueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.freeissueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // unallocatedDataGridViewTextBoxColumn
            // 
            this.unallocatedDataGridViewTextBoxColumn.DataPropertyName = "unallocated";
            this.unallocatedDataGridViewTextBoxColumn.HeaderText = "unallocated";
            this.unallocatedDataGridViewTextBoxColumn.Name = "unallocatedDataGridViewTextBoxColumn";
            this.unallocatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.unallocatedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unallocatedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sideselectionDataGridViewTextBoxColumn
            // 
            this.sideselectionDataGridViewTextBoxColumn.DataPropertyName = "side_selection";
            this.sideselectionDataGridViewTextBoxColumn.HeaderText = "side_selection";
            this.sideselectionDataGridViewTextBoxColumn.Name = "sideselectionDataGridViewTextBoxColumn";
            this.sideselectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cviewpaintondoorBindingSource
            // 
            this.cviewpaintondoorBindingSource.DataMember = "c_view_paint_on_door";
            this.cviewpaintondoorBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Required Paint";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Operations";
            // 
            // txtFinishID
            // 
            this.txtFinishID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinishID.Enabled = false;
            this.txtFinishID.Location = new System.Drawing.Point(830, 77);
            this.txtFinishID.Name = "txtFinishID";
            this.txtFinishID.Size = new System.Drawing.Size(146, 20);
            this.txtFinishID.TabIndex = 67;
            // 
            // txtFinish
            // 
            this.txtFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinish.Enabled = false;
            this.txtFinish.Location = new System.Drawing.Point(830, 103);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(146, 20);
            this.txtFinish.TabIndex = 68;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(830, 129);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(146, 20);
            this.txtCustomer.TabIndex = 69;
            // 
            // txtDoorType
            // 
            this.txtDoorType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoorType.Enabled = false;
            this.txtDoorType.Location = new System.Drawing.Point(831, 155);
            this.txtDoorType.Name = "txtDoorType";
            this.txtDoorType.Size = new System.Drawing.Size(146, 20);
            this.txtDoorType.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(773, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Finish ID:";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Finish Type:";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(770, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Customer:";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(764, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Door Type:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(901, 400);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 75;
            this.btnRemove.Text = "Remove Op";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCompleteDoor
            // 
            this.btnCompleteDoor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteDoor.ForeColor = System.Drawing.Color.Green;
            this.btnCompleteDoor.Location = new System.Drawing.Point(827, 709);
            this.btnCompleteDoor.Name = "btnCompleteDoor";
            this.btnCompleteDoor.Size = new System.Drawing.Size(146, 23);
            this.btnCompleteDoor.TabIndex = 76;
            this.btnCompleteDoor.Text = "Complete in painting";
            this.btnCompleteDoor.UseVisualStyleBackColor = true;
            this.btnCompleteDoor.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(678, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "UnComplete in painting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtPaintingStatus
            // 
            this.txtPaintingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaintingStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPaintingStatus.Location = new System.Drawing.Point(12, 709);
            this.txtPaintingStatus.Name = "txtPaintingStatus";
            this.txtPaintingStatus.Size = new System.Drawing.Size(558, 20);
            this.txtPaintingStatus.TabIndex = 78;
            this.txtPaintingStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 79;
            this.button2.Text = "Repaints List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Location = new System.Drawing.Point(190, 26);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(75, 23);
            this.btnReporting.TabIndex = 80;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Visible = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // automatic_report_sent_logTableAdapter1
            // 
            this.automatic_report_sent_logTableAdapter1.ClearBeforeFill = true;
            // 
            // dgProductionProgress
            // 
            this.dgProductionProgress.AllowUserToAddRows = false;
            this.dgProductionProgress.AllowUserToDeleteRows = false;
            this.dgProductionProgress.AllowUserToResizeColumns = false;
            this.dgProductionProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductionProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductionProgress.Location = new System.Drawing.Point(12, 107);
            this.dgProductionProgress.Name = "dgProductionProgress";
            this.dgProductionProgress.Size = new System.Drawing.Size(366, 150);
            this.dgProductionProgress.TabIndex = 81;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Operation Progress";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Painting Note:";
            // 
            // txtPaintingNote
            // 
            this.txtPaintingNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaintingNote.ForeColor = System.Drawing.Color.Red;
            this.txtPaintingNote.Location = new System.Drawing.Point(763, 217);
            this.txtPaintingNote.Multiline = true;
            this.txtPaintingNote.Name = "txtPaintingNote";
            this.txtPaintingNote.Size = new System.Drawing.Size(211, 52);
            this.txtPaintingNote.TabIndex = 84;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.Location = new System.Drawing.Point(901, 275);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNote.TabIndex = 85;
            this.btnSaveNote.Text = "Save Note";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(576, 709);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 86;
            this.button3.Text = "View Loose Items";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(867, 48);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 23);
            this.btnNext.TabIndex = 87;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(829, 48);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 23);
            this.btnPrevious.TabIndex = 88;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // c_view_painting_sectionsTableAdapter
            // 
            this.c_view_painting_sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // c_view_paint_on_doorTableAdapter
            // 
            this.c_view_paint_on_doorTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.thisDoorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 89;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffSetupToolStripMenuItem,
            this.repaintsToolStripMenuItem,
            this.reportingToolStripMenuItem,
            this.balanceStockToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // staffSetupToolStripMenuItem
            // 
            this.staffSetupToolStripMenuItem.Name = "staffSetupToolStripMenuItem";
            this.staffSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffSetupToolStripMenuItem.Text = "Staff Setup";
            this.staffSetupToolStripMenuItem.Click += new System.EventHandler(this.staffSetupToolStripMenuItem_Click);
            // 
            // repaintsToolStripMenuItem
            // 
            this.repaintsToolStripMenuItem.Name = "repaintsToolStripMenuItem";
            this.repaintsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repaintsToolStripMenuItem.Text = "Repaints";
            this.repaintsToolStripMenuItem.Click += new System.EventHandler(this.repaintsToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportingToolStripMenuItem.Text = "Reporting";
            this.reportingToolStripMenuItem.Click += new System.EventHandler(this.reportingToolStripMenuItem_Click);
            // 
            // thisDoorToolStripMenuItem
            // 
            this.thisDoorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.looseItemsToolStripMenuItem});
            this.thisDoorToolStripMenuItem.Name = "thisDoorToolStripMenuItem";
            this.thisDoorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thisDoorToolStripMenuItem.Text = "This Door";
            // 
            // looseItemsToolStripMenuItem
            // 
            this.looseItemsToolStripMenuItem.Name = "looseItemsToolStripMenuItem";
            this.looseItemsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.looseItemsToolStripMenuItem.Text = "Loose Items";
            this.looseItemsToolStripMenuItem.Click += new System.EventHandler(this.looseItemsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtQuantitySame
            // 
            this.txtQuantitySame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantitySame.Enabled = false;
            this.txtQuantitySame.Location = new System.Drawing.Point(831, 180);
            this.txtQuantitySame.Name = "txtQuantitySame";
            this.txtQuantitySame.Size = new System.Drawing.Size(146, 20);
            this.txtQuantitySame.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "Quantity Same:";
            // 
            // balanceStockToolStripMenuItem
            // 
            this.balanceStockToolStripMenuItem.Name = "balanceStockToolStripMenuItem";
            this.balanceStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balanceStockToolStripMenuItem.Text = "Balance Stock";
            this.balanceStockToolStripMenuItem.Click += new System.EventHandler(this.balanceStockToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuantitySame);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.txtPaintingNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgProductionProgress);
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPaintingStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCompleteDoor);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoorType);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtFinishID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPaintToDoor);
            this.Controls.Add(this.btnStaffSetup);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmdOp);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingsectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintingstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaintToDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpaintondoorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private order_databaseDataSet1 order_databaseDataSet1;
        private System.Windows.Forms.BindingSource cviewpaintingsectionsBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_painting_sectionsTableAdapter c_view_painting_sectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCompleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oporderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ComboBox cmdOp;
        private System.Windows.Forms.Button btnUpdate;
        private user_infoDataSet user_infoDataSet1;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewpaintingstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_painting_staffTableAdapter c_view_painting_staffTableAdapter;
        private System.Windows.Forms.Button btnStaffSetup;
        private System.Windows.Forms.DataGridView dgPaintToDoor;
        private System.Windows.Forms.BindingSource cviewpaintondoorBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_paint_on_doorTableAdapter c_view_paint_on_doorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dooridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powderkgsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn freeissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn unallocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideselectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinishID;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtDoorType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCompleteDoor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPaintingStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReporting;
        private order_databaseDataSetTableAdapters.automatic_report_sent_logTableAdapter automatic_report_sent_logTableAdapter1;
        private System.Windows.Forms.DataGridView dgProductionProgress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.TextBox txtPaintingNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thisDoorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem looseItemsToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantitySame;
        private System.Windows.Forms.ToolStripMenuItem balanceStockToolStripMenuItem;
    }
}

