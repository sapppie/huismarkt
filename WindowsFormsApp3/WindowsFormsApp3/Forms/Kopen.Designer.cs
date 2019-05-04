namespace HuizenmarktApp
{
    partial class Kopen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City_Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postcode_Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.cityz = new System.Windows.Forms.Label();
            this.streetwithnumberz = new System.Windows.Forms.Label();
            this.acresz = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rooms = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.spotsavailable = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.energylabel = new System.Windows.Forms.TextBox();
            this.garage = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.typeofhouse = new System.Windows.Forms.TextBox();
            this.acres = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView
            // 
            this.listView.AutoArrange = false;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.City_Header,
            this.AddressHeader,
            this.Postcode_Header});
            this.listView.GridLines = true;
            this.listView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView.LabelEdit = true;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(483, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(317, 410);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 23;
            // 
            // City_Header
            // 
            this.City_Header.Text = "City";
            this.City_Header.Width = 88;
            // 
            // AddressHeader
            // 
            this.AddressHeader.Text = "Address";
            this.AddressHeader.Width = 77;
            // 
            // Postcode_Header
            // 
            this.Postcode_Header.Text = "Postcode";
            this.Postcode_Header.Width = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bieden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityz
            // 
            this.cityz.AutoSize = true;
            this.cityz.Location = new System.Drawing.Point(57, 303);
            this.cityz.Name = "cityz";
            this.cityz.Size = new System.Drawing.Size(60, 13);
            this.cityz.TabIndex = 3;
            this.cityz.Text = "Stad/Dorp:";
            // 
            // streetwithnumberz
            // 
            this.streetwithnumberz.AutoSize = true;
            this.streetwithnumberz.Location = new System.Drawing.Point(5, 323);
            this.streetwithnumberz.Name = "streetwithnumberz";
            this.streetwithnumberz.Size = new System.Drawing.Size(112, 13);
            this.streetwithnumberz.TabIndex = 4;
            this.streetwithnumberz.Text = "Straat en huisnummer:";
            // 
            // acresz
            // 
            this.acresz.AutoSize = true;
            this.acresz.Location = new System.Drawing.Point(39, 343);
            this.acresz.Name = "acresz";
            this.acresz.Size = new System.Drawing.Size(78, 13);
            this.acresz.TabIndex = 5;
            this.acresz.Text = "Hectare grond:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Heeft Garage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kamers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Prijs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bouwjaar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Over het huis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Soort huis:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Energie label:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Plaatsen in garage:";
            // 
            // rooms
            // 
            this.rooms.Location = new System.Drawing.Point(119, 400);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(100, 20);
            this.rooms.TabIndex = 15;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(119, 300);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 16;
            // 
            // spotsavailable
            // 
            this.spotsavailable.Location = new System.Drawing.Point(325, 300);
            this.spotsavailable.Name = "spotsavailable";
            this.spotsavailable.Size = new System.Drawing.Size(100, 20);
            this.spotsavailable.TabIndex = 17;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(119, 320);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 18;
            // 
            // energylabel
            // 
            this.energylabel.Location = new System.Drawing.Point(119, 380);
            this.energylabel.Name = "energylabel";
            this.energylabel.Size = new System.Drawing.Size(100, 20);
            this.energylabel.TabIndex = 19;
            // 
            // garage
            // 
            this.garage.Location = new System.Drawing.Point(119, 420);
            this.garage.Name = "garage";
            this.garage.Size = new System.Drawing.Size(100, 20);
            this.garage.TabIndex = 20;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(119, 360);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 21;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(325, 340);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 23;
            // 
            // typeofhouse
            // 
            this.typeofhouse.Location = new System.Drawing.Point(325, 320);
            this.typeofhouse.Name = "typeofhouse";
            this.typeofhouse.Size = new System.Drawing.Size(100, 20);
            this.typeofhouse.TabIndex = 24;
            // 
            // acres
            // 
            this.acres.Location = new System.Drawing.Point(119, 340);
            this.acres.Name = "acres";
            this.acres.Size = new System.Drawing.Size(100, 20);
            this.acres.TabIndex = 18;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(228, 380);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(249, 56);
            this.about.TabIndex = 25;
            this.about.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Terug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Kopen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Kopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.about);
            this.Controls.Add(this.typeofhouse);
            this.Controls.Add(this.price);
            this.Controls.Add(this.year);
            this.Controls.Add(this.garage);
            this.Controls.Add(this.energylabel);
            this.Controls.Add(this.acres);
            this.Controls.Add(this.address);
            this.Controls.Add(this.spotsavailable);
            this.Controls.Add(this.city);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acresz);
            this.Controls.Add(this.streetwithnumberz);
            this.Controls.Add(this.cityz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kopen";
            this.Text = "Kopen";
            this.Load += new System.EventHandler(this.Kopen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader City_Header;
        private System.Windows.Forms.ColumnHeader AddressHeader;
        private System.Windows.Forms.ColumnHeader Postcode_Header;
        private System.Windows.Forms.Label cityz;
        private System.Windows.Forms.Label streetwithnumberz;
        private System.Windows.Forms.Label acresz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rooms;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox spotsavailable;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox energylabel;
        private System.Windows.Forms.TextBox garage;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox typeofhouse;
        private System.Windows.Forms.TextBox acres;
        private System.Windows.Forms.RichTextBox about;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

