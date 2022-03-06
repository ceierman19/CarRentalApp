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
    public partial class frmManageVehicleListing : Form
    {
        private readonly CarRentalEntities1 _db = new CarRentalEntities1();  
        // Whatever you call this object is inconsequential, just have one consistent naming convention 
       
        public frmManageVehicleListing()
        {
            InitializeComponent(); 
        }

        private void frmManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
                // Populates the grid when the form is loaded
                // Also used to populate grid whenever the Refresh button is clicked 
                PopulateVehicleGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}"); 
            }
        }

        public void PopulateVehicleGrid()  // Notice public access modifier
        {
            // SELECT * FROM TypesofCars 
            //var cars = _db.TypesOfCars.ToList();

            // SELECT id AS CarID, name AS CarName FROM TypesofCars 
            //var cars = _db.TypesOfCars.Select(q => new { CarId = q.Id, CarName = q.Make }).ToList();  
            // aliasing in LINQ 
            // lambda expression
            // alias = lambda-expression.column


            // Select a custom model collection of cars from database 
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,  // Can simplify to just q.Make...same column name
                    q.Model,
                    q.VIN,
                    q.LicensePlateNumber, 
                    q.Year,
                    q.Id
                })
                .ToList();

            dgvVehicleList.DataSource = cars;
            dgvVehicleList.Columns[3].HeaderText = "License Plate Number";  // Changed column name from previously
                                                                            // hard-coded value 
            dgvVehicleList.Columns[5].Visible = false;  // Hide the column for ID 
        }

        // The grid is automatically populated when the form is loaded and when changes are made through the form
        // Refresh button is included so changes made to the database can be seen 
        private void btnRefreshVehicleList_Click(object sender, EventArgs e)
        {
            PopulateVehicleGrid();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            // Prevents user from adding/editing on multiple forms at once 
            frmAddEditVehicle addVehicle = new frmAddEditVehicle(this);
            addVehicle.ShowDialog();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row 
                int id = (int)dgvVehicleList.SelectedRows[0].Cells["Id"].Value;

                // Query database for record 
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                // Launch AddEditVehicle window with data 
                // Prevents user from adding/editing on multiple forms at once
                frmAddEditVehicle editVehicle = new frmAddEditVehicle(car, this);
                editVehicle.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row."); 
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row 
                int id = (int)dgvVehicleList.SelectedRows[0].Cells["Id"].Value;

                // Query database for record 
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                // Dialog Box
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this vehicle?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 

                if (dialogResult == DialogResult.Yes)
                {
                    // Delete vehicle from table 
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                    MessageBox.Show("Vehicle successfully deleted.");
                }

                PopulateVehicleGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nMake sure you have selected a row.\n" +
                    "Note: Cascaded deletion is not enabled so related data cannot be deleted.");
            }
        }
    }
}
