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
    public partial class frmManageRentalRecords : Form
    {
        private readonly CarRentalEntities1 _db = new CarRentalEntities1(); 

        public frmManageRentalRecords()
        {
            InitializeComponent();
        }

        private void frmManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                // Populates the grid when the form is loaded
                // Also used to populate grid whenever the Refresh button is clicked 
                PopulateRentalRecordsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateRentalRecordsGrid()  // Notice public access modifier 
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                q.Id,
                q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();

            dgvRentalRecords.DataSource = records;
            dgvRentalRecords.Columns["DateOut"].HeaderText = "Date Out";
            dgvRentalRecords.Columns["DateIn"].HeaderText = "Date In";
            dgvRentalRecords.Columns["Id"].Visible = false;
        }

        // The grid is automatically populated when the form is loaded and when changes are made through the form
        // Refresh button is included so changes made to the database can be seen 
        private void btnRefreshRentalRecords_Click(object sender, EventArgs e)
        {
            PopulateRentalRecordsGrid();
        }

        private void btnAddNewRentalRecord_Click(object sender, EventArgs e)
        {
            // Prevents user from adding/editing on multiple forms at once 
            frmAddEditRentalRecord addRentalRecord = new frmAddEditRentalRecord(this);
            addRentalRecord.ShowDialog();
        }

        private void btnEditRentalRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row 
                int id = (int)dgvRentalRecords.SelectedRows[0].Cells["Id"].Value;

                // Query database for record 
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.Id == id);

                // Launch AddEditRentalRecord window with data 
                // Prevents user from adding/editing on multiple forms at once 
                frmAddEditRentalRecord editRentalRecord = new frmAddEditRentalRecord(record, this);
                editRentalRecord.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }

        private void btnDeleteRentalRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row 
                int id = (int)dgvRentalRecords.SelectedRows[0].Cells["Id"].Value;

                // Query database for record 
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.Id == id);

                // Dialog Box
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this record?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Delete record from table 
                    _db.CarRentalRecords.Remove(record);
                    _db.SaveChanges();
                    MessageBox.Show("Rental Record successfully deleted.");
                }

                PopulateRentalRecordsGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }
    }
}
