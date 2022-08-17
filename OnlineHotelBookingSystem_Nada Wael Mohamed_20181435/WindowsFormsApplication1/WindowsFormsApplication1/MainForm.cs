using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            Hotel_Booking_SystemEntities1 database = new Hotel_Booking_SystemEntities1();
            Room R = new Room();
            R.Room_Type = RoomTypeTB.Text;
            R.Amount = AmountTB.Text;
            database.Rooms.Add(R);
            database.SaveChanges();
            MessageBox.Show("Booking Successfully");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel_Booking_SystemEntities1 database = new Hotel_Booking_SystemEntities1();
            int temp = Int32.Parse(RoomIdTB.Text);
            var Deleted = database.Rooms.First(R => R.Room_Id == temp);
            database.Rooms.Remove(Deleted);
            database.SaveChanges();
            MessageBox.Show("Room Canceled Successfully");
            this.Hide();
           
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogOut LO = new LogOut();
            LO.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hotel_Booking_SystemEntities1 database = new Hotel_Booking_SystemEntities1();
            Hotel H = new Hotel();
            H.Hotal_Name = HotelNameTB.Text;
            H.Hotel_Reviews = ReviewsTB.Text;
            database.Hotels.Add(H);
            database.SaveChanges();
            MessageBox.Show("Your Review has being added");
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HotelNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
