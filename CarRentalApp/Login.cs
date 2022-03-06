using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class frmLogin : Form
    {
        private readonly CarRentalEntities1 _db = new CarRentalEntities1(); 

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim(); 
                string password = txtPassword.Text; 

                var hashed_password = Utils.HashPassword(password);

                // Check for matching username, password, and active flag 
                var user = _db.Users.FirstOrDefault(q => q.Username == username
                                                         && q.Password == hashed_password
                                                         && q.IsActive == true);
                
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials."); 
                }
                else
                {
                    MainWindow mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }
}
