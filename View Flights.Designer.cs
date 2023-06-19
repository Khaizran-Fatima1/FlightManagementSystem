namespace Airline
{
    partial class View_Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Flights));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DestCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlightDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SeatNum = new System.Windows.Forms.TextBox();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(327, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 41);
            this.button3.TabIndex = 43;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(437, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 41);
            this.button4.TabIndex = 42;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(129, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 41);
            this.button2.TabIndex = 41;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(227, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 40;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(323, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Destination";
            // 
            // DestCb
            // 
            this.DestCb.BackColor = System.Drawing.SystemColors.Menu;
            this.DestCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestCb.FormattingEnabled = true;
            this.DestCb.Items.AddRange(new object[] {
            "Cairo",
            "Chennai",
            "Delhi",
            "Dubai",
            "Faislabad",
            "Islamabad",
            "Karachi",
            "Lahore",
            "Los Angeles",
            "Multan",
            "Mumbai",
            "Sialkot",
            "Sharjah",
            "Shimla",
            "Sydney",
            "Toronto"});
            this.DestCb.Location = new System.Drawing.Point(442, 133);
            this.DestCb.Name = "DestCb";
            this.DestCb.Size = new System.Drawing.Size(171, 25);
            this.DestCb.TabIndex = 36;
            // 
            // SrcCb
            // 
            this.SrcCb.BackColor = System.Drawing.SystemColors.Menu;
            this.SrcCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
            "Cairo",
            "Chennai",
            "Delhi",
            "Dubai",
            "Faislabad",
            "Islamabad",
            "Karachi",
            "Lahore",
            "Los Angeles",
            "Multan",
            "Mumbai",
            "Sialkot",
            "Sharjah",
            "Shimla",
            "Sydney",
            "Toronto"});
            this.SrcCb.Location = new System.Drawing.Point(442, 102);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(171, 25);
            this.SrcCb.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(336, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(243, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "View Schduled Flights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(275, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Air Indus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Flight Code";
            // 
            // FlightDGV
            // 
            this.FlightDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FlightDGV.Location = new System.Drawing.Point(6, 291);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightDGV.Size = new System.Drawing.Size(620, 198);
            this.FlightDGV.TabIndex = 46;
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 23);
            this.panel1.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(593, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FcodeTb
            // 
            this.FcodeTb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.FcodeTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcodeTb.Location = new System.Drawing.Point(134, 100);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(171, 23);
            this.FcodeTb.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(150, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "No. of Seats";
            // 
            // SeatNum
            // 
            this.SeatNum.BackColor = System.Drawing.SystemColors.Menu;
            this.SeatNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNum.Location = new System.Drawing.Point(285, 174);
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.Size = new System.Drawing.Size(150, 23);
            this.SeatNum.TabIndex = 54;
            // 
            // FDate
            // 
            this.FDate.Checked = false;
            this.FDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDate.Location = new System.Drawing.Point(134, 135);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(171, 23);
            this.FDate.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(9, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "TakeOf Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(3, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 19);
            this.panel2.TabIndex = 48;
            // 
            // View_Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SeatNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DestCb);
            this.Controls.Add(this.SrcCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Flights";
            this.Load += new System.EventHandler(this.View_Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DestCb;
        private System.Windows.Forms.ComboBox SrcCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView FlightDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SeatNum;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}