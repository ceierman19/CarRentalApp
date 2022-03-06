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
    public partial class MainWindow : Form
    {
        private frmLogin _frmLogin;
        public User _user;
        public string _roleName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(frmLogin login, User user) 
        {
            InitializeComponent();
            _frmLogin = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.ShortName;

            // same as 
            //var role = user.UserRoles.FirstOrDefault();
            //string roleShortName = role.Role.shortName; 
        }

        // Commented out b/c you cannot add a song when archive (Rental Records grid) is not open 
        // This is b/c AddEditRentalRecord calls the PopulateRentalRecordsGrid() function 
        // Add Rental Record menu option is not visible to user 
        // Code is here for reference 
        //private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // Creates a new instance of AddEditRentalRecord class
        //    // Tethers the AddEditRentalRecord forms to the MainWindow and shows them  
        //    // Default behavior is a new AddEditRentalRecord form will appear each time the button is clicked 
        //    // Can change this...  

        //    // Prevents user from adding/editing on multiple forms at once
        //    frmAddEditRentalRecord addRentalRecord = new frmAddEditRentalRecord();
        //    addRentalRecord.ShowDialog();
        //}

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if an instance of frmManageVehicleListing is already open 
            // if form !open, create a new instance and show 
            if (!Utils.FormIsOpen("frmManageVehicleListing")) 
            {
                frmManageVehicleListing manageVehicles = new frmManageVehicleListing
                {
                    MdiParent = this
                };

                // Same as...
                //frmManageVehicleListing manageVehicles = new frmManageVehicleListing(); 
                //manageVehicles.MdiParent = this; 

                manageVehicles.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("frmManageRentalRecords"))  
            {
                frmManageRentalRecords manageRentalRecords = new frmManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("frmManageUsers"))
            {
                frmManageUsers manageUsers = new frmManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // If a user has the default password, they need to change it 
            if (_user.Password == Utils.DefaultHashedPassword())
            {
                frmResetPassword resetPassword = new frmResetPassword(_user);
                resetPassword.ShowDialog();
            }
            
            // Shows which user is logged in 
            string username = _user.Username; 
            toolStripStatusLabelMainWindow.Text = $"Logged In As: {username}"; 
            
            // Prevents non-admin users from managing users 
            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmLogin.Close();
        }
    }
}
