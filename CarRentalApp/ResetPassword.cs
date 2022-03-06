using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class frmResetPassword : Form
    {
        private readonly CarRentalEntities1 _db = new CarRentalEntities1();
        private User _user; 
        
        public frmResetPassword(User user)
        {
            InitializeComponent();
            _user = user; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtNewPassword.Text;
                string confirm_password = txtConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.Id == _user.Id);

                if (newPassword != confirm_password)
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                }
                else
                {
                    user.Password = Utils.HashPassword(newPassword);
                    MessageBox.Show("Password successfully reset.");
                    _db.SaveChanges();
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured. Please try again."); 
            }
        }
    }
}
