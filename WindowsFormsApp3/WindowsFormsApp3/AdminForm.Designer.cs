namespace WindowsFormsApp3
{
    partial class AdminForm
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
            this.acres = new System.Windows.Forms.TextBox();
            this.housenr = new System.Windows.Forms.TextBox();
            this.rooms = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.garage = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.TextBox();
            this.soorthuis = new System.Windows.Forms.TextBox();
            this.garagecap = new System.Windows.Forms.TextBox();
            this.energielabel = new System.Windows.Forms.TextBox();
            this.housePic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.housePic)).BeginInit();
            this.SuspendLayout();
            // 
            // acres
            // 
            this.acres.Location = new System.Drawing.Point(99, 39);
            this.acres.Name = "acres";
            this.acres.Size = new System.Drawing.Size(100, 20);
            this.acres.TabIndex = 1;
            // 
            // housenr
            // 
            this.housenr.Location = new System.Drawing.Point(99, 65);
            this.housenr.Name = "housenr";
            this.housenr.Size = new System.Drawing.Size(100, 20);
            this.housenr.TabIndex = 2;
            // 
            // rooms
            // 
            this.rooms.Location = new System.Drawing.Point(99, 91);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(100, 20);
            this.rooms.TabIndex = 3;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(99, 13);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 20);
            this.street.TabIndex = 0;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(99, 143);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 5;
            // 
            // garage
            // 
            this.garage.Location = new System.Drawing.Point(99, 117);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(100, 20);
            this.garage.TabIndex = 4;
            this.garage.TextChanged += new System.EventHandler(this.Garage_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(99, 169);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 6;
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(99, 195);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(100, 20);
            this.postcode.TabIndex = 7;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(99, 221);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 8;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(99, 325);
            this.about.Name = "about";
            this.about.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.about.Size = new System.Drawing.Size(100, 20);
            this.about.TabIndex = 12;
            // 
            // soorthuis
            // 
            this.soorthuis.Location = new System.Drawing.Point(99, 247);
            this.soorthuis.Name = "soorthuis";
            this.soorthuis.Size = new System.Drawing.Size(100, 20);
            this.soorthuis.TabIndex = 9;
            // 
            // garagecap
            // 
            this.garagecap.Location = new System.Drawing.Point(99, 299);
            this.garagecap.Name = "garagecap";
            this.garagecap.Size = new System.Drawing.Size(100, 20);
            this.garagecap.TabIndex = 11;
            this.garagecap.TextChanged += new System.EventHandler(this.TextBox12_TextChanged);
            // 
            // energielabel
            // 
            this.energielabel.Location = new System.Drawing.Point(99, 273);
            this.energielabel.Name = "energielabel";
            this.energielabel.Size = new System.Drawing.Size(100, 20);
            this.energielabel.TabIndex = 10;
            // 
            // housePic
            // 
            this.housePic.Location = new System.Drawing.Point(205, 22);
            this.housePic.Name = "housePic";
            this.housePic.Size = new System.Drawing.Size(583, 387);
            this.housePic.TabIndex = 13;
            this.housePic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Street";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Acres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "House number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rooms";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Garage";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "City";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Postcode";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Year built";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "About";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Soort huis";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Energielabel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Garage capacity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.housePic);
            this.Controls.Add(this.energielabel);
            this.Controls.Add(this.garagecap);
            this.Controls.Add(this.soorthuis);
            this.Controls.Add(this.about);
            this.Controls.Add(this.year);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.city);
            this.Controls.Add(this.garage);
            this.Controls.Add(this.price);
            this.Controls.Add(this.street);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.housenr);
            this.Controls.Add(this.acres);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.housePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acres;
        private System.Windows.Forms.TextBox housenr;
        private System.Windows.Forms.TextBox rooms;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox garage;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox about;
        private System.Windows.Forms.TextBox soorthuis;
        private System.Windows.Forms.TextBox garagecap;
        private System.Windows.Forms.TextBox energielabel;
        private System.Windows.Forms.PictureBox housePic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}