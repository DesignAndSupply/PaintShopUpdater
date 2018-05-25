namespace WindowsFormsApp2
{
    partial class frmUpdateBox
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
            this.lblBox = new System.Windows.Forms.Label();
            this.lblPaintDesc = new System.Windows.Forms.Label();
            this.lblKgsRemain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActualKgs = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox.Location = new System.Drawing.Point(12, 9);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(60, 24);
            this.lblBox.TabIndex = 0;
            this.lblBox.Text = "label1";
            // 
            // lblPaintDesc
            // 
            this.lblPaintDesc.AutoSize = true;
            this.lblPaintDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintDesc.Location = new System.Drawing.Point(13, 33);
            this.lblPaintDesc.Name = "lblPaintDesc";
            this.lblPaintDesc.Size = new System.Drawing.Size(46, 17);
            this.lblPaintDesc.TabIndex = 1;
            this.lblPaintDesc.Text = "label1";
            // 
            // lblKgsRemain
            // 
            this.lblKgsRemain.AutoSize = true;
            this.lblKgsRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgsRemain.Location = new System.Drawing.Point(13, 117);
            this.lblKgsRemain.Name = "lblKgsRemain";
            this.lblKgsRemain.Size = new System.Drawing.Size(60, 24);
            this.lblKgsRemain.TabIndex = 2;
            this.lblKgsRemain.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actual Kgs Remaining In Box:";
            // 
            // txtActualKgs
            // 
            this.txtActualKgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualKgs.Location = new System.Drawing.Point(273, 151);
            this.txtActualKgs.Name = "txtActualKgs";
            this.txtActualKgs.Size = new System.Drawing.Size(46, 29);
            this.txtActualKgs.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 551);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Box";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Box Location:";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLocation.Location = new System.Drawing.Point(244, 188);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(75, 29);
            this.txtBoxLocation.TabIndex = 7;
            // 
            // frmUpdateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 586);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtActualKgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKgsRemain);
            this.Controls.Add(this.lblPaintDesc);
            this.Controls.Add(this.lblBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Box";
            this.Load += new System.EventHandler(this.frmUpdateBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.Label lblPaintDesc;
        private System.Windows.Forms.Label lblKgsRemain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActualKgs;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLocation;
    }
}