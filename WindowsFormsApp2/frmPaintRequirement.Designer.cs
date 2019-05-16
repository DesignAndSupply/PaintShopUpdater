namespace WindowsFormsApp2
{
    partial class frmPaintRequirement
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridPaintlist = new System.Windows.Forms.DataGridView();
            this.dte_paint_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaintlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Paint Date:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(218, 30);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 20);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridPaintlist
            // 
            this.dataGridPaintlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPaintlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPaintlist.Location = new System.Drawing.Point(12, 56);
            this.dataGridPaintlist.Name = "dataGridPaintlist";
            this.dataGridPaintlist.Size = new System.Drawing.Size(766, 487);
            this.dataGridPaintlist.TabIndex = 3;
            // 
            // dte_paint_date
            // 
            this.dte_paint_date.Location = new System.Drawing.Point(12, 30);
            this.dte_paint_date.Name = "dte_paint_date";
            this.dte_paint_date.Size = new System.Drawing.Size(200, 20);
            this.dte_paint_date.TabIndex = 4;
            // 
            // frmPaintRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 555);
            this.Controls.Add(this.dte_paint_date);
            this.Controls.Add(this.dataGridPaintlist);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Name = "frmPaintRequirement";
            this.Text = "Paint Requirement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaintlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridPaintlist;
        private System.Windows.Forms.DateTimePicker dte_paint_date;
    }
}