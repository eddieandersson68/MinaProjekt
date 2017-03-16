namespace Övning_3_9
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
            this.btnFlytta = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFlytta
            // 
            this.btnFlytta.Location = new System.Drawing.Point(120, 89);
            this.btnFlytta.Name = "btnFlytta";
            this.btnFlytta.Size = new System.Drawing.Size(60, 20);
            this.btnFlytta.TabIndex = 0;
            this.btnFlytta.Text = "Flytta";
            this.btnFlytta.UseVisualStyleBackColor = true;
            this.btnFlytta.Click += new System.EventHandler(this.btnFlytta_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(77, 23);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(80, 39);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(64, 20);
            this.tbxX.TabIndex = 2;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(180, 23);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(166, 39);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(64, 20);
            this.tbxY.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnFlytta);
            this.Name = "Form1";
            this.Text = "Övning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlytta;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbxY;
    }
}

