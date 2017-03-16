namespace Övning_3_7
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
            this.lblTecken = new System.Windows.Forms.Label();
            this.tbxTecken = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTecken
            // 
            this.lblTecken.AutoSize = true;
            this.lblTecken.Location = new System.Drawing.Point(47, 45);
            this.lblTecken.Name = "lblTecken";
            this.lblTecken.Size = new System.Drawing.Size(44, 13);
            this.lblTecken.TabIndex = 0;
            this.lblTecken.Text = "Tecken";
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(129, 42);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 1;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(129, 211);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(115, 176);
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
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxTecken);
            this.Controls.Add(this.lblTecken);
            this.Name = "Form1";
            this.Text = "Övning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecken;
        private System.Windows.Forms.TextBox tbxTecken;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
    }
}

