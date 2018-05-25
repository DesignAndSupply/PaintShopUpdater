namespace WindowsFormsApp2
{
    partial class frmPaintBoxes
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
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lblPaintDescription = new System.Windows.Forms.Label();
            this.dgvBoxList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoCurrent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoxList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCode.Location = new System.Drawing.Point(12, 45);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(70, 26);
            this.lblStockCode.TabIndex = 0;
            this.lblStockCode.Text = "label1";
            // 
            // lblPaintDescription
            // 
            this.lblPaintDescription.AutoSize = true;
            this.lblPaintDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintDescription.Location = new System.Drawing.Point(14, 71);
            this.lblPaintDescription.Name = "lblPaintDescription";
            this.lblPaintDescription.Size = new System.Drawing.Size(46, 18);
            this.lblPaintDescription.TabIndex = 6;
            this.lblPaintDescription.Text = "label1";
            // 
            // dgvBoxList
            // 
            this.dgvBoxList.AllowUserToAddRows = false;
            this.dgvBoxList.AllowUserToDeleteRows = false;
            this.dgvBoxList.AllowUserToResizeRows = false;
            this.dgvBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBoxList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoxList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoxList.Location = new System.Drawing.Point(17, 211);
            this.dgvBoxList.Name = "dgvBoxList";
            this.dgvBoxList.RowHeadersVisible = false;
            this.dgvBoxList.Size = new System.Drawing.Size(966, 461);
            this.dgvBoxList.TabIndex = 7;
            this.dgvBoxList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoxList_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Controls.Add(this.rdoCurrent);
            this.groupBox1.Location = new System.Drawing.Point(17, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Selection";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(6, 48);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(73, 17);
            this.rdoAll.TabIndex = 10;
            this.rdoAll.Text = "Display All";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoCurrent
            // 
            this.rdoCurrent.AutoSize = true;
            this.rdoCurrent.Checked = true;
            this.rdoCurrent.Location = new System.Drawing.Point(6, 25);
            this.rdoCurrent.Name = "rdoCurrent";
            this.rdoCurrent.Size = new System.Drawing.Size(96, 17);
            this.rdoCurrent.TabIndex = 9;
            this.rdoCurrent.TabStop = true;
            this.rdoCurrent.Text = "Display Current";
            this.rdoCurrent.UseVisualStyleBackColor = true;
            this.rdoCurrent.CheckedChanged += new System.EventHandler(this.rdoCurrent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Box List";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(866, 182);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate Box";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmPaintBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 648);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBoxList);
            this.Controls.Add(this.lblPaintDescription);
            this.Controls.Add(this.lblStockCode);
            this.Name = "frmPaintBoxes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Box List";
            this.Load += new System.EventHandler(this.frmPaintBoxes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoxList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label lblPaintDescription;
        private System.Windows.Forms.DataGridView dgvBoxList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
    }
}