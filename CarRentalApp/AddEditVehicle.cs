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
    public partial class frmAddEditVehicle : Form
    {
        private bool isEditMode;
        private frmManageVehicleListing _frmManageVehicleListing;
        private readonly CarRentalEntities1 _db = new CarRentalEntities1();

        public frmAddEditVehicle(frmManageVehicleListing frmManageVehicleListing = null)  // Notice nullability 
        {
            InitializeComponent();
            this.Text = "Add Vehicle";  // Changes form name 
            lblAddEditTitle.Text = "Add New Vehicle";  // Changes label/title 
            isEditMode = false;
            _frmManageVehicleListing = frmManageVehicleListing;
        }

        public frmAddEditVehicle(TypesOfCar carToEdit, frmManageVehicleListing frmManageVehicleListing = null)
        {
            InitializeComponent();
            this.Text = "Edit Vehicle";
            lblAddEditTitle.Text = "Edit Vehicle";
            _frmManageVehicleListing = frmManageVehicleListing;
            isEditMode = true;
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypesOfCar car)
        {
            lblId.Text = car.Id.ToString();
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtVIN.Text = car.VIN;
            txtYear.Text = car.Year.ToString(); 
            txtLIC.Text = car.LicensePlateNumber;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for Make and Model inputs 
                if (string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    MessageBox.Show("Please enter a make and a model.");
                }
                else
                {
                    if (isEditMode)
                    {
                        // Edit Code here 
                        int id = int.Parse(lblId.Text);
                        var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                        car.Make = txtMake.Text;
                        car.Model = txtModel.Text;
                        car.VIN = txtVIN.Text;
                        car.Year = int.Parse(txtYear.Text);
                        car.LicensePlateNumber = txtLIC.Text;
                    }
                    else
                    {
                        // Add Code here 
                        TypesOfCar newCar = new TypesOfCar
                        {
                            Make = txtMake.Text,
                            Model = txtModel.Text,
                            VIN = txtVIN.Text,
                            Year = int.Parse(txtYear.Text),
                            LicensePlateNumber = txtLIC.Text
                        };

                        _db.TypesOfCars.Add(newCar);
                    }

                    // Save changes made to the database and repopulate grid 
                    _db.SaveChanges();
                    _frmManageVehicleListing.PopulateVehicleGrid();

                    MessageBox.Show("Operation completed.");
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please enter a year.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
