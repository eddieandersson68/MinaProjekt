﻿namespace Övning3_3
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
            this.lblTalA = new System.Windows.Forms.Label();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.lblTalB = new System.Windows.Forms.Label();
            this.lblTalC = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.lblMedel = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(119, 216);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblTalA
            // 
            this.lblTalA.AutoSize = true;
            this.lblTalA.Location = new System.Drawing.Point(36, 26);
            this.lblTalA.Name = "lblTalA";
            this.lblTalA.Size = new System.Drawing.Size(32, 13);
            this.lblTalA.TabIndex = 1;
            this.lblTalA.Text = "Tal A";
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(119, 23);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 2;
            // 
            // lblTalB
            // 
            this.lblTalB.AutoSize = true;
            this.lblTalB.Location = new System.Drawing.Point(36, 60);
            this.lblTalB.Name = "lblTalB";
            this.lblTalB.Size = new System.Drawing.Size(32, 13);
            this.lblTalB.TabIndex = 3;
            this.lblTalB.Text = "Tal B";
            // 
            // lblTalC
            // 
            this.lblTalC.AutoSize = true;
            this.lblTalC.Location = new System.Drawing.Point(36, 101);
            this.lblTalC.Name = "lblTalC";
            this.lblTalC.Size = new System.Drawing.Size(32, 13);
            this.lblTalC.TabIndex = 4;
            this.lblTalC.Text = "Tal C";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(116, 152);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(45, 13);
            this.lblSumma.TabIndex = 5;
            this.lblSumma.Text = "Summa:";
            // 
            // lblMedel
            // 
            this.lblMedel.AutoSize = true;
            this.lblMedel.Location = new System.Drawing.Point(116, 177);
            this.lblMedel.Name = "lblMedel";
            this.lblMedel.Size = new System.Drawing.Size(66, 13);
            this.lblMedel.TabIndex = 6;
            this.lblMedel.Text = "Medlevärde:";
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(119, 60);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 7;
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(119, 101);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 20);
            this.tbxC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.lblMedel);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lblTalC);
            this.Controls.Add(this.lblTalB);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.lblTalA);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Övning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblTalA;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Label lblTalB;
        private System.Windows.Forms.Label lblTalC;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Label lblMedel;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxC;
    }
}

