﻿namespace WindowsFormsApp3
{
    partial class LoginForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UserText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(139, 75);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 13);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(289, 72);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 20);
            this.UserText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(289, 122);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(100, 20);
            this.PassText.TabIndex = 4;
            this.PassText.TextChanged += new System.EventHandler(this.PassText_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Button button2;
    }
}