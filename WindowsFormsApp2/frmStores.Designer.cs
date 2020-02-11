namespace WindowsFormsApp2
{
    partial class frmStores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_screenshot = new System.Windows.Forms.Button();
            this.btnLabel = new System.Windows.Forms.Button();
            this.hiddenDGV = new System.Windows.Forms.DataGridView();
            this.btnRePrint = new System.Windows.Forms.Button();
            this.btnDoorSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(427, 21);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_screenshot
            // 
            this.btn_screenshot.Location = new System.Drawing.Point(364, 22);
            this.btn_screenshot.Name = "btn_screenshot";
            this.btn_screenshot.Size = new System.Drawing.Size(75, 23);
            this.btn_screenshot.TabIndex = 1;
            this.btn_screenshot.Text = "Print Screen";
            this.btn_screenshot.UseVisualStyleBackColor = true;
            this.btn_screenshot.Click += new System.EventHandler(this.btn_screenshot_Click);
            // 
            // btnLabel
            // 
            this.btnLabel.Location = new System.Drawing.Point(12, 22);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(97, 23);
            this.btnLabel.TabIndex = 2;
            this.btnLabel.Text = "Print ALL Labels";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // hiddenDGV
            // 
            this.hiddenDGV.AllowUserToAddRows = false;
            this.hiddenDGV.AllowUserToDeleteRows = false;
            this.hiddenDGV.AllowUserToResizeColumns = false;
            this.hiddenDGV.AllowUserToResizeRows = false;
            this.hiddenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hiddenDGV.Location = new System.Drawing.Point(373, 35);
            this.hiddenDGV.Name = "hiddenDGV";
            this.hiddenDGV.RowHeadersVisible = false;
            this.hiddenDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hiddenDGV.Size = new System.Drawing.Size(10, 10);
            this.hiddenDGV.TabIndex = 3;
            // 
            // btnRePrint
            // 
            this.btnRePrint.Location = new System.Drawing.Point(115, 22);
            this.btnRePrint.Name = "btnRePrint";
            this.btnRePrint.Size = new System.Drawing.Size(110, 23);
            this.btnRePrint.TabIndex = 4;
            this.btnRePrint.Text = "Reprint a label";
            this.btnRePrint.UseVisualStyleBackColor = true;
            this.btnRePrint.Click += new System.EventHandler(this.btnRePrint_Click);
            // 
            // btnDoorSearch
            // 
            this.btnDoorSearch.Location = new System.Drawing.Point(231, 22);
            this.btnDoorSearch.Name = "btnDoorSearch";
            this.btnDoorSearch.Size = new System.Drawing.Size(127, 23);
            this.btnDoorSearch.TabIndex = 5;
            this.btnDoorSearch.Text = "Search Door Number";
            this.btnDoorSearch.UseVisualStyleBackColor = true;
            this.btnDoorSearch.Click += new System.EventHandler(this.btnDoorSearch_Click);
            // 
            // frmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 78);
            this.Controls.Add(this.btnDoorSearch);
            this.Controls.Add(this.btnRePrint);
            this.Controls.Add(this.btnLabel);
            this.Controls.Add(this.btn_screenshot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hiddenDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stores List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_screenshot;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.DataGridView hiddenDGV;
        private System.Windows.Forms.Button btnRePrint;
        private System.Windows.Forms.Button btnDoorSearch;
    }
}