namespace HuizenmarktApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.HighestBid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BidValue
            // 
            this.BidValue.Location = new System.Drawing.Point(12, 78);
            this.BidValue.Name = "BidValue";
            this.BidValue.Size = new System.Drawing.Size(100, 20);
            this.BidValue.TabIndex = 0;
            // 
            // BidButton
            // 
            this.BidButton.Location = new System.Drawing.Point(12, 103);
            this.BidButton.Name = "BidButton";
            this.BidButton.Size = new System.Drawing.Size(100, 23);
            this.BidButton.TabIndex = 1;
            this.BidButton.Text = "Bied";
            this.BidButton.UseVisualStyleBackColor = true;
            this.BidButton.Click += new System.EventHandler(this.BidButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Het hoogste bod bedraagt zich:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighestBid
            // 
            this.HighestBid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HighestBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestBid.Location = new System.Drawing.Point(12, 42);
            this.HighestBid.Name = "HighestBid";
            this.HighestBid.Size = new System.Drawing.Size(100, 33);
            this.HighestBid.TabIndex = 4;
            this.HighestBid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 138);
            this.Controls.Add(this.HighestBid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BidButton);
            this.Controls.Add(this.BidValue);
            this.Name = "Bid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BidValue;
        private System.Windows.Forms.Button BidButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HighestBid;
    }
}