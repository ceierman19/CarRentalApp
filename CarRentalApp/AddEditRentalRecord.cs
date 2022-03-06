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
    public partial class frmAddEditRentalRecord : Form
    {
        private bool isEditMode;
        private frmManageRentalRecords _frmManageRentalRecords;
        private readonly CarRentalEntities1 _db = new CarRentalEntities1(); 

        public frmAddEditRentalRecord(frmManageRentalRecords frmManageRentalRecords = null)  // Notice nullability 
        {
            InitializeComponent();
            this.Text = "Add Rental Record";  // Changes form name 
            lblAddEditRentalRecord.Text = "Add Rental Record";  // Changes label/title 
            isEditMode = false;
            _frmManageRentalRecords = frmManageRentalRecords;
        }
        
        public frmAddEditRentalRecord(CarRentalRecord rentalRecordToEdit, 
            frmManageRentalRecords frmManageRentalRecords = null)
        {
            InitializeComponent();
            this.Text = "Edit Rental Record"; 
            lblAddEditRentalRecord.Text = "Edit Rental Record";
            _frmManageRentalRecords = frmManageRentalRecords;
            isEditMode = true;
            PopulateFields(rentalRecordToEdit); 
        }

        private void PopulateFields(CarRentalRecord rentalRecordToEdit)
        {
            txtCustomerName.Text = rentalRecordToEdit.CustomerName;
            dtpRented.Value = (DateTime)rentalRecordToEdit.DateRented;
            dtpReturned.Value = (DateTime)rentalRecordToEdit.DateReturned;
            txtCost.Text = rentalRecordToEdit.Cost.ToString();
            lblRecordId.Text = rentalRecordToEdit.Id.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // var data type tells the compiler to figure out the variable type at compilation 
                // Try not to overuse var data type 
                string customerName = txtCustomerName.Text;
                var dateOut = dtpRented.Value;
                var dateIn = dtpReturned.Value;
                double cost = Convert.ToDouble(txtCost.Text);  // Consider using numericUpDown control for cost and
                                                               // editing decimal places property 
                var carType = cboTypeOfCar.Text;
                bool isValid = true;
                string errorMessage = "";

                // Logic checking for valid input 
                // Having separate if statements catches all the possible errors 
                // if/elseif/else would only check for missing data OR invalid date 
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing name.\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Invalid Date Selection\n\r";
                }

                if (string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please choose a car type.\n\r";
                }

                if (isValid)  // if (isValid == true)
                {
                    // Declare an object of the record to be added 
                    CarRentalRecord rentalRecord = new CarRentalRecord();
                    
                    // If editing, get the Id and retrieve the record from the database and place 
                    // the result in the rentalRecord object 
                    if (isEditMode)
                    {
                        int id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.Id == id);
                    }

                    // Populate rentalRecord object with values from the form 
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cboTypeOfCar.SelectedValue;

                    // If not editing, add the rentalRecord object to the database 
                    if (!isEditMode)
                    {
                        _db.CarRentalRecords.Add(rentalRecord);
                    }
                    
                    // Save changes made to the database and repopulate grid
                    _db.SaveChanges();
                    _frmManageRentalRecords.PopulateRentalRecordsGrid();

                    MessageBox.Show($"Operation completed.\n\r" +
                        $"Customer Name: {customerName}\n\r" +
                        $"Date Rented: {dateOut}\n\r" +
                        $"Date Returned: {dateIn}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Car Type: {carType}\n\r");
                    
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Please enter a cost."); 
            }
        }

        private void frmAddEditRentalRecord_Load(object sender, EventArgs e)
        {
            // Same thing as SELECT * FROM <table> in SQL 
            //var cars = carRentalEntities1.TypesOfCars.ToList();  // Querying database for list of cars using LINQ and
            // storing this list in a variable 

            var cars = _db.TypesOfCars.Select(q => new 
            { 
                q.Id, 
                Name = q.Make + " " + q.Model 
            }).ToList();

            // Fills the combo box / dropdown with list of cars from database 
            cboTypeOfCar.DisplayMember = "Name";  // Displays the names 
            cboTypeOfCar.ValueMember = "Id";  // Stores the ids 
            cboTypeOfCar.DataSource = cars;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}