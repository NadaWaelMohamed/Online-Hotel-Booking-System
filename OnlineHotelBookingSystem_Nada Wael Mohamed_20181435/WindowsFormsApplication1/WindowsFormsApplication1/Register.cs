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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hotel_Booking_SystemEntities1 database = new Hotel_Booking_SystemEntities1();
            User U = new User();
            U.FirstName = FirstNameTB.Text;
            U.Lastname = LastNameTB.Text;
            U.Username = UsernameTB.Text;
            U.Password = PasswordTB.Text;
            database.Users.Add(U);
            database.SaveChanges();
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }
    }
}
