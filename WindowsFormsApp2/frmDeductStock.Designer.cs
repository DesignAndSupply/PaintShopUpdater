namespace WindowsFormsApp2
{
    partial class frmDeductStock
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
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoMultiple = new System.Windows.Forms.RadioButton();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblMultiple = new System.Windows.Forms.Label();
            this.txtMultiple = new System.Windows.Forms.TextBox();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(12, 61);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(121, 20);
            this.txtBefore.TabIndex = 0;
            this.txtBefore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBefore_KeyPress);
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(157, 61);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(121, 20);
            this.txtAfter.TabIndex = 1;
            this.txtAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAfter_KeyPress);
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Location = new System.Drawing.Point(35, 10);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(75, 17);
            this.rdoSingle.TabIndex = 2;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single Box";
            this.rdoSingle.UseVisualStyleBackColor = true;
            this.rdoSingle.CheckedChanged += new System.EventHandler(this.rdoSingle_CheckedChanged);
            // 
            // rdoMultiple
            // 
            this.rdoMultiple.AutoSize = true;
            this.rdoMultiple.Location = new System.Drawing.Point(171, 10);
            this.rdoMultiple.Name = "rdoMultiple";
            this.rdoMultiple.Size = new System.Drawing.Size(93, 17);
            this.rdoMultiple.TabIndex = 3;
            this.rdoMultiple.TabStop = true;
            this.rdoMultiple.Text = "Multiple Boxes";
            this.rdoMultiple.UseVisualStyleBackColor = true;
            this.rdoMultiple.CheckedChanged += new System.EventHandler(this.rdoMultiple_CheckedChanged);
            // 
            // lblBefore
            // 
            this.lblBefore.Location = new System.Drawing.Point(12, 43);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(121, 15);
            this.lblBefore.TabIndex = 4;
            this.lblBefore.Text = "Box Weight Before";
            this.lblBefore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAfter
            // 
            this.lblAfter.Location = new System.Drawing.Point(157, 43);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(121, 15);
            this.lblAfter.TabIndex = 5;
            this.lblAfter.Text = "Box Weight After";
            this.lblAfter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMultiple
            // 
            this.lblMultiple.Location = new System.Drawing.Point(87, 43);
            this.lblMultiple.Name = "lblMultiple";
            this.lblMultiple.Size = new System.Drawing.Size(121, 15);
            this.lblMultiple.TabIndex = 7;
            this.lblMultiple.Text = "Kgs used";
            this.lblMultiple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtMultiple
            // 
            this.txtMultiple.Location = new System.Drawing.Point(87, 61);
            this.txtMultiple.Name = "txtMultiple";
            this.txtMultiple.Size = new System.Drawing.Size(121, 20);
            this.txtMultiple.TabIndex = 6;
            this.txtMultiple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMultiple_KeyDown);
            this.txtMultiple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMultiple_KeyPress);
            // 
            // btnDeduct
            // 
            this.btnDeduct.Location = new System.Drawing.Point(155, 87);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeduct.TabIndex = 8;
            this.btnDeduct.Text = "Deduct";
            this.btnDeduct.UseVisualStyleBackColor = true;
            this.btnDeduct.Click += new System.EventHandler(this.btnDeduct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(74, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeductStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeduct);
            this.Controls.Add(this.lblMultiple);
            this.Controls.Add(this.txtMultiple);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.rdoMultiple);
            this.Controls.Add(this.rdoSingle);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeductStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deduct Paint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoMultiple;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblMultiple;
        private System.Windows.Forms.TextBox txtMultiple;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.Button btnCancel;
    }
}