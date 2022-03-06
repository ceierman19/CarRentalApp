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
    public partial class frmAddUser : Form
    {
        private readonly CarRentalEntities1 _db = new CarRentalEntities1();
        private frmManageUsers _frmManageUsers; 

        //public frmAddUser()
        //{
        //    InitializeComponent();
        //}

        // Notice only one constructor 
        // Unlikely to call frmAddUser w/o an object of frmManageUsers 
        public frmAddUser(frmManageUsers frmManageUsers)
        {
            InitializeComponent();
            _frmManageUsers = frmManageUsers;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            // Query database 
            var roles = _db.Roles.ToList();
            
            // Fill combo box / dropdown with list of roles from database 
            cboRoles.DataSource = roles;
            cboRoles.ValueMember = "Id";
            cboRoles.DisplayMember = "Name";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new user 
                string username = txtUsername.Text;
                int roleId = (int)cboRoles.SelectedValue;
                string password = Utils.DefaultHashedPassword();

                User user = new User
                {
                    Username = username,
                    Password = password,
                    IsActive = true
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                // Fetch Id 
                int userId = user.Id;

                // Assign user to their selected role 
                UserRole userRole = new UserRole
                {
                    RoleId = roleId,
                    UserId = userId
                };

                _db.UserRoles.Add(userRole);
                _db.SaveChanges();

                MessageBox.Show("New user successfully added.");
                _frmManageUsers.PopulateUserGrid(); 
                Close(); 
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured."); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
