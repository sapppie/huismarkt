namespace WindowsFormsApp3.Forms
{
    partial class Bid
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
            this.BidValue = new System.Windows.Forms.TextBox();
            this.BidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BidValue
            // 
            this.BidValue.Location = new System.Drawing.Point(12, 12);
            this.BidValue.Name = "BidValue";
            this.BidValue.Size = new System.Drawing.Size(100, 20);
            this.BidValue.TabIndex = 0;
            // 
            // BidButton
            // 
            this.BidButton.Location = new System.Drawing.Point(12, 38);
            this.BidButton.Name = "BidButton";
            this.BidButton.Size = new System.Drawing.Size(100, 23);
            this.BidButton.TabIndex = 1;
            this.BidButton.Text = "Bid";
            this.BidButton.UseVisualStyleBackColor = true;
            this.BidButton.Click += new System.EventHandler(this.BidButton_Click);
            // 
            // Bid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 80);
            this.Controls.Add(this.BidButton);
            this.Controls.Add(this.BidValue);
            this.Name = "Bid";
            this.Text = "Bid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BidValue;
        private System.Windows.Forms.Button BidButton;
    }
}