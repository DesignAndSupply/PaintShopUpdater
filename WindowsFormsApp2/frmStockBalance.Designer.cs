namespace WindowsFormsApp2
{
    partial class frmStockBalance
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPaintList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaintList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "\\\\designsvr1\\apps\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(60, 126);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(124, 20);
            this.txtBoxID.TabIndex = 5;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(60, 217);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(124, 20);
            this.txtColour.TabIndex = 6;
            this.txtColour.TextChanged += new System.EventHandler(this.txtColour_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Box ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Colour:";
            // 
            // dgvPaintList
            // 
            this.dgvPaintList.AllowUserToAddRows = false;
            this.dgvPaintList.AllowUserToDeleteRows = false;
            this.dgvPaintList.AllowUserToResizeRows = false;
            this.dgvPaintList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaintList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaintList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaintList.Location = new System.Drawing.Point(204, 27);
            this.dgvPaintList.Name = "dgvPaintList";
            this.dgvPaintList.RowHeadersVisible = false;
            this.dgvPaintList.Size = new System.Drawing.Size(985, 580);
            this.dgvPaintList.TabIndex = 9;
            this.dgvPaintList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaintList_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(109, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchBox
            // 
            this.btnSearchBox.Location = new System.Drawing.Point(109, 152);
            this.btnSearchBox.Name = "btnSearchBox";
            this.btnSearchBox.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBox.TabIndex = 11;
            this.btnSearchBox.Text = "Search";
            this.btnSearchBox.UseVisualStyleBackColor = true;
            this.btnSearchBox.Click += new System.EventHandler(this.btnSearchBox_Click);
            // 
            // frmStockBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 619);
            this.Controls.Add(this.btnSearchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPaintList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmStockBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Stock";
            this.Load += new System.EventHandler(this.frmStockBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaintList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPaintList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchBox;
    }
}