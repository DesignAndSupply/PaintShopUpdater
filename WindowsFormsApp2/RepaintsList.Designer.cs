namespace WindowsFormsApp2
{
    partial class RepaintsList
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
            this.dgRepaintList = new System.Windows.Forms.DataGridView();
            this.repaintIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLoggedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRepaintedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paintColourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgsUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsResponsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loggedFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.door_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cviewrepaintlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet1 = new WindowsFormsApp2.order_databaseDataSet1();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewRepaint = new System.Windows.Forms.Button();
            this.orderdatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_repaint_listTableAdapter = new WindowsFormsApp2.order_databaseDataSet1TableAdapters.c_view_repaint_listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepaintList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewrepaintlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRepaintList
            // 
            this.dgRepaintList.AllowUserToAddRows = false;
            this.dgRepaintList.AllowUserToDeleteRows = false;
            this.dgRepaintList.AllowUserToResizeRows = false;
            this.dgRepaintList.AutoGenerateColumns = false;
            this.dgRepaintList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRepaintList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepaintList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repaintIDDataGridViewTextBoxColumn,
            this.dateLoggedDataGridViewTextBoxColumn,
            this.dateRepaintedDataGridViewTextBoxColumn,
            this.paintColourDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.finishDataGridViewTextBoxColumn,
            this.kgsUsedDataGridViewTextBoxColumn,
            this.personsResponsibleDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.completeDataGridViewTextBoxColumn,
            this.loggedFromDataGridViewTextBoxColumn,
            this.Complete,
            this.door_id});
            this.dgRepaintList.DataSource = this.cviewrepaintlistBindingSource;
            this.dgRepaintList.Location = new System.Drawing.Point(12, 171);
            this.dgRepaintList.Name = "dgRepaintList";
            this.dgRepaintList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgRepaintList.Size = new System.Drawing.Size(1244, 406);
            this.dgRepaintList.TabIndex = 0;
            this.dgRepaintList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRepaintList_CellContentClick);
            // 
            // repaintIDDataGridViewTextBoxColumn
            // 
            this.repaintIDDataGridViewTextBoxColumn.DataPropertyName = "Repaint ID";
            this.repaintIDDataGridViewTextBoxColumn.HeaderText = "Repaint ID";
            this.repaintIDDataGridViewTextBoxColumn.Name = "repaintIDDataGridViewTextBoxColumn";
            // 
            // dateLoggedDataGridViewTextBoxColumn
            // 
            this.dateLoggedDataGridViewTextBoxColumn.DataPropertyName = "Date Logged";
            this.dateLoggedDataGridViewTextBoxColumn.HeaderText = "Date Logged";
            this.dateLoggedDataGridViewTextBoxColumn.Name = "dateLoggedDataGridViewTextBoxColumn";
            // 
            // dateRepaintedDataGridViewTextBoxColumn
            // 
            this.dateRepaintedDataGridViewTextBoxColumn.DataPropertyName = "Date Repainted";
            this.dateRepaintedDataGridViewTextBoxColumn.HeaderText = "Date Repainted";
            this.dateRepaintedDataGridViewTextBoxColumn.Name = "dateRepaintedDataGridViewTextBoxColumn";
            // 
            // paintColourDataGridViewTextBoxColumn
            // 
            this.paintColourDataGridViewTextBoxColumn.DataPropertyName = "Paint Colour";
            this.paintColourDataGridViewTextBoxColumn.HeaderText = "Paint Colour";
            this.paintColourDataGridViewTextBoxColumn.Name = "paintColourDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // finishDataGridViewTextBoxColumn
            // 
            this.finishDataGridViewTextBoxColumn.DataPropertyName = "Finish";
            this.finishDataGridViewTextBoxColumn.HeaderText = "Finish";
            this.finishDataGridViewTextBoxColumn.Name = "finishDataGridViewTextBoxColumn";
            // 
            // kgsUsedDataGridViewTextBoxColumn
            // 
            this.kgsUsedDataGridViewTextBoxColumn.DataPropertyName = "Kgs Used";
            this.kgsUsedDataGridViewTextBoxColumn.HeaderText = "Kgs Used";
            this.kgsUsedDataGridViewTextBoxColumn.Name = "kgsUsedDataGridViewTextBoxColumn";
            // 
            // personsResponsibleDataGridViewTextBoxColumn
            // 
            this.personsResponsibleDataGridViewTextBoxColumn.DataPropertyName = "Persons Responsible";
            this.personsResponsibleDataGridViewTextBoxColumn.HeaderText = "Persons Responsible";
            this.personsResponsibleDataGridViewTextBoxColumn.Name = "personsResponsibleDataGridViewTextBoxColumn";
            this.personsResponsibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // completeDataGridViewTextBoxColumn
            // 
            this.completeDataGridViewTextBoxColumn.DataPropertyName = "Complete";
            this.completeDataGridViewTextBoxColumn.HeaderText = "Complete";
            this.completeDataGridViewTextBoxColumn.Name = "completeDataGridViewTextBoxColumn";
            this.completeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.completeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // loggedFromDataGridViewTextBoxColumn
            // 
            this.loggedFromDataGridViewTextBoxColumn.DataPropertyName = "Logged from";
            this.loggedFromDataGridViewTextBoxColumn.HeaderText = "Logged from";
            this.loggedFromDataGridViewTextBoxColumn.Name = "loggedFromDataGridViewTextBoxColumn";
            // 
            // Complete
            // 
            this.Complete.HeaderText = "Complete";
            this.Complete.Name = "Complete";
            this.Complete.Text = "Mark as Complete";
            this.Complete.UseColumnTextForButtonValue = true;
            // 
            // door_id
            // 
            this.door_id.DataPropertyName = "door_id";
            this.door_id.HeaderText = "door_id";
            this.door_id.Name = "door_id";
            // 
            // cviewrepaintlistBindingSource
            // 
            this.cviewrepaintlistBindingSource.DataMember = "c_view_repaint_list";
            this.cviewrepaintlistBindingSource.DataSource = this.order_databaseDataSet1;
            // 
            // order_databaseDataSet1
            // 
            this.order_databaseDataSet1.DataSetName = "order_databaseDataSet1";
            this.order_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(1276, 25);
            this.fillBy2ToolStrip.TabIndex = 3;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "S:\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(553, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewRepaint
            // 
            this.btnNewRepaint.Location = new System.Drawing.Point(1151, 137);
            this.btnNewRepaint.Name = "btnNewRepaint";
            this.btnNewRepaint.Size = new System.Drawing.Size(105, 28);
            this.btnNewRepaint.TabIndex = 5;
            this.btnNewRepaint.Text = "New Repaint";
            this.btnNewRepaint.UseVisualStyleBackColor = true;
            this.btnNewRepaint.Click += new System.EventHandler(this.btnNewRepaint_Click);
            // 
            // orderdatabaseDataSet1BindingSource
            // 
            this.orderdatabaseDataSet1BindingSource.DataSource = this.order_databaseDataSet1;
            this.orderdatabaseDataSet1BindingSource.Position = 0;
            // 
            // c_view_repaint_listTableAdapter
            // 
            this.c_view_repaint_listTableAdapter.ClearBeforeFill = true;
            // 
            // RepaintsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 601);
            this.Controls.Add(this.btnNewRepaint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.dgRepaintList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RepaintsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepaintsList";
            this.Load += new System.EventHandler(this.RepaintsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRepaintList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewrepaintlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet1)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRepaintList;
        private System.Windows.Forms.BindingSource orderdatabaseDataSet1BindingSource;
        private order_databaseDataSet1 order_databaseDataSet1;
        private System.Windows.Forms.BindingSource cviewrepaintlistBindingSource;
        private order_databaseDataSet1TableAdapters.c_view_repaint_listTableAdapter c_view_repaint_listTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewRepaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaintIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLoggedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRepaintedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paintColourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgsUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personsResponsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggedFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn door_id;
    }
}