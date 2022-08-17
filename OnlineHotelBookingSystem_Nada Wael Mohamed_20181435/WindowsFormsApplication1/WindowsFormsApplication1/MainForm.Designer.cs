namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.BookingButton = new System.Windows.Forms.Button();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.RoomTypeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomIdTB = new System.Windows.Forms.TextBox();
            this.CancelingButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ReviewsTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HotelReviews = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.HotelNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(575, 139);
            this.BookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(226, 45);
            this.BookingButton.TabIndex = 0;
            this.BookingButton.Text = "Booking";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(338, 205);
            this.AmountTB.Margin = new System.Windows.Forms.Padding(4);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(136, 27);
            this.AmountTB.TabIndex = 1;
            // 
            // RoomTypeTB
            // 
            this.RoomTypeTB.Location = new System.Drawing.Point(338, 95);
            this.RoomTypeTB.Margin = new System.Windows.Forms.Padding(4);
            this.RoomTypeTB.Name = "RoomTypeTB";
            this.RoomTypeTB.Size = new System.Drawing.Size(136, 27);
            this.RoomTypeTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Booking Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cancel Booking";
            // 
            // RoomIdTB
            // 
            this.RoomIdTB.Location = new System.Drawing.Point(338, 377);
            this.RoomIdTB.Name = "RoomIdTB";
            this.RoomIdTB.Size = new System.Drawing.Size(136, 27);
            this.RoomIdTB.TabIndex = 8;
            // 
            // CancelingButton
            // 
            this.CancelingButton.Location = new System.Drawing.Point(575, 365);
            this.CancelingButton.Name = "CancelingButton";
            this.CancelingButton.Size = new System.Drawing.Size(226, 50);
            this.CancelingButton.TabIndex = 9;
            this.CancelingButton.Text = "Canceling";
            this.CancelingButton.UseVisualStyleBackColor = true;
            this.CancelingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(1053, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(289, 44);
            this.LogOut.TabIndex = 10;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Your Review";
            // 
            // ReviewsTB
            // 
            this.ReviewsTB.Location = new System.Drawing.Point(805, 536);
            this.ReviewsTB.Name = "ReviewsTB";
            this.ReviewsTB.Size = new System.Drawing.Size(149, 27);
            this.ReviewsTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adding Review";
            // 
            // HotelReviews
            // 
            this.HotelReviews.Location = new System.Drawing.Point(1053, 524);
            this.HotelReviews.Name = "HotelReviews";
            this.HotelReviews.Size = new System.Drawing.Size(289, 39);
            this.HotelReviews.TabIndex = 11;
            this.HotelReviews.Text = "Hotel Reviews";
            this.HotelReviews.UseVisualStyleBackColor = true;
            this.HotelReviews.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hotel Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // HotelNameTB
            // 
            this.HotelNameTB.Location = new System.Drawing.Point(338, 540);
            this.HotelNameTB.Name = "HotelNameTB";
            this.HotelNameTB.Size = new System.Drawing.Size(136, 27);
            this.HotelNameTB.TabIndex = 16;
            this.HotelNameTB.TextChanged += new System.EventHandler(this.HotelNameTB_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1353, 591);
            this.Controls.Add(this.HotelNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReviewsTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HotelReviews);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.CancelingButton);
            this.Controls.Add(this.RoomIdTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomTypeTB);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.BookingButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox RoomTypeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RoomIdTB;
        private System.Windows.Forms.Button CancelingButton;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReviewsTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button HotelReviews;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HotelNameTB;
    }
}