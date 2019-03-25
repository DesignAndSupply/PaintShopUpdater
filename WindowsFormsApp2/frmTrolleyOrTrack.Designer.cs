namespace WindowsFormsApp2
{
    partial class frmTrolleyOrTrack
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
            this.btnTrolley = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrolley
            // 
            this.btnTrolley.Location = new System.Drawing.Point(12, 48);
            this.btnTrolley.Name = "btnTrolley";
            this.btnTrolley.Size = new System.Drawing.Size(112, 46);
            this.btnTrolley.TabIndex = 0;
            this.btnTrolley.Text = "Trolley";
            this.btnTrolley.UseVisualStyleBackColor = true;
            this.btnTrolley.Click += new System.EventHandler(this.btnTrolley_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(189, 48);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(112, 46);
            this.btnTrack.TabIndex = 1;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the one of the following locations for this door:";
            // 
            // frmTrolleyOrTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnTrolley);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrolleyOrTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trolley or Track";
            this.Load += new System.EventHandler(this.frmTrolleyOrTrack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrolley;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label label1;
    }
}