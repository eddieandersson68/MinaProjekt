﻿namespace Övning_3_4
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
            this.tbxEngelska = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.lblEngelska = new System.Windows.Forms.Label();
            this.lblSvenska = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxSvenska = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxEngelska
            // 
            this.tbxEngelska.Location = new System.Drawing.Point(116, 22);
            this.tbxEngelska.Name = "tbxEngelska";
            this.tbxEngelska.Size = new System.Drawing.Size(100, 20);
            this.tbxEngelska.TabIndex = 0;
            this.tbxEngelska.TextChanged += new System.EventHandler(this.tbxEngelska_TextChanged);
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(103, 200);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 1;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblEngelska
            // 
            this.lblEngelska.AutoSize = true;
            this.lblEngelska.Location = new System.Drawing.Point(12, 25);
            this.lblEngelska.Name = "lblEngelska";
            this.lblEngelska.Size = new System.Drawing.Size(51, 13);
            this.lblEngelska.TabIndex = 2;
            this.lblEngelska.Text = "Engelska";
            // 
            // lblSvenska
            // 
            this.lblSvenska.AutoSize = true;
            this.lblSvenska.Location = new System.Drawing.Point(12, 69);
            this.lblSvenska.Name = "lblSvenska";
            this.lblSvenska.Size = new System.Drawing.Size(49, 13);
            this.lblSvenska.TabIndex = 3;
            this.lblSvenska.Text = "Svenska";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(72, 167);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 3;
            // 
            // tbxSvenska
            // 
            this.tbxSvenska.Location = new System.Drawing.Point(116, 66);
            this.tbxSvenska.Name = "tbxSvenska";
            this.tbxSvenska.Size = new System.Drawing.Size(100, 20);
            this.tbxSvenska.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxSvenska);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblSvenska);
            this.Controls.Add(this.lblEngelska);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxEngelska);
            this.Name = "Form1";
            this.Text = "Övning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEngelska;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblEngelska;
        private System.Windows.Forms.Label lblSvenska;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxSvenska;
    }
}

