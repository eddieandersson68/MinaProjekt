﻿namespace Exempel3_1
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
            this.lblTal = new System.Windows.Forms.Label();
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.lblKvadrat = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Location = new System.Drawing.Point(50, 24);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(22, 13);
            this.lblTal.TabIndex = 0;
            this.lblTal.Text = "Tal";
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(106, 16);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(100, 20);
            this.tbxTal.TabIndex = 1;
            // 
            // lblKvadrat
            // 
            this.lblKvadrat.AutoSize = true;
            this.lblKvadrat.Location = new System.Drawing.Point(50, 56);
            this.lblKvadrat.Name = "lblKvadrat";
            this.lblKvadrat.Size = new System.Drawing.Size(0, 13);
            this.lblKvadrat.TabIndex = 2;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(91, 76);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(131, 23);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "Beräkna Kvadraten";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblKvadrat);
            this.Controls.Add(this.tbxTal);
            this.Controls.Add(this.lblTal);
            this.Name = "Form1";
            this.Text = "Exempel 3 -1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.Label lblKvadrat;
        private System.Windows.Forms.Button btnKör;
    }
}

