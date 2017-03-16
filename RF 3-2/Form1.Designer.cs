namespace RF_3_2
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
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxUnicode = new System.Windows.Forms.TextBox();
            this.lblUnicode = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(106, 201);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxUnicode
            // 
            this.tbxUnicode.Location = new System.Drawing.Point(106, 58);
            this.tbxUnicode.Name = "tbxUnicode";
            this.tbxUnicode.Size = new System.Drawing.Size(100, 20);
            this.tbxUnicode.TabIndex = 1;
            // 
            // lblUnicode
            // 
            this.lblUnicode.AutoSize = true;
            this.lblUnicode.Location = new System.Drawing.Point(22, 58);
            this.lblUnicode.Name = "lblUnicode";
            this.lblUnicode.Size = new System.Drawing.Size(45, 13);
            this.lblUnicode.TabIndex = 2;
            this.lblUnicode.Text = "unicode";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(77, 174);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblUnicode);
            this.Controls.Add(this.tbxUnicode);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "RF 3-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxUnicode;
        private System.Windows.Forms.Label lblUnicode;
        private System.Windows.Forms.Label lblSvar;
    }
}

