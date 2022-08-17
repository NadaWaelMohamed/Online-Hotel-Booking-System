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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            Hotel_Booking_SystemEntities1 database = new Hotel_Booking_SystemEntities1();
            List<User> accounts = database.Users.ToList();
            foreach (User U in accounts)
            {
                if (U.Username == UsernameTB.Text && U.Password == PasswordTB.Text)
                {
                    MessageBox.Show("Successful Login .. Welcome To Our Website" );
                    MainForm M = new MainForm();
                    M.Show();
                    this.Hide();
                }
         
            }
        }

    }
}


