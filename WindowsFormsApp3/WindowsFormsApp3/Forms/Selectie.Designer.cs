﻿namespace HuizenmarktApp
{
    partial class Selectie
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
            this.kopen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kopen
            // 
            this.kopen.Location = new System.Drawing.Point(21, 12);
            this.kopen.Name = "kopen";
            this.kopen.Size = new System.Drawing.Size(118, 23);
            this.kopen.TabIndex = 0;
            this.kopen.Text = "Ik wil een huis kopen.";
            this.kopen.UseVisualStyleBackColor = true;
            this.kopen.Click += new System.EventHandler(this.Kopen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Annuleren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ik wil mijn huis bekijken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Selectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.kopen);
            this.Name = "Selectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kopen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}