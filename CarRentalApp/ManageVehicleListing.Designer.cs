namespace CarRentalApp
{
    partial class frmManageVehicleListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.lblManageVehicleListing = new System.Windows.Forms.Label();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnRefreshVehicleList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.Location = new System.Drawing.Point(20, 167);
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.RowHeadersWidth = 51;
            this.dgvVehicleList.RowTemplate.Height = 24;
            this.dgvVehicleList.Size = new System.Drawing.Size(760, 170);
            this.dgvVehicleList.TabIndex = 0;
            // 
            // lblManageVehicleListing
            // 
            this.lblManageVehicleListing.AutoSize = true;
            this.lblManageVehicleListing.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageVehicleListing.Location = new System.Drawing.Point(150, 9);
            this.lblManageVehicleListing.Name = "lblManageVehicleListing";
            this.lblManageVehicleListing.Size = new System.Drawing.Size(459, 73);
            this.lblManageVehicleListing.TabIndex = 1;
            this.lblManageVehicleListing.Text = "Manage Vehicle Listing";
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewCar.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.Location = new System.Drawing.Point(52, 368);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(181, 54);
            this.btnAddNewCar.TabIndex = 10;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = false;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.BackColor = System.Drawing.Color.Gold;
            this.btnEditCar.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(311, 368);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(181, 54);
            this.btnEditCar.TabIndex = 11;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = false;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteCar.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(571, 368);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteCar.TabIndex = 12;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnRefreshVehicleList
            // 
            this.btnRefreshVehicleList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshVehicleList.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshVehicleList.Location = new System.Drawing.Point(52, 95);
            this.btnRefreshVehicleList.Name = "btnRefreshVehicleList";
            this.btnRefreshVehicleList.Size = new System.Drawing.Size(181, 54);
            this.btnRefreshVehicleList.TabIndex = 13;
            this.btnRefreshVehicleList.Text = "Refresh";
            this.btnRefreshVehicleList.UseVisualStyleBackColor = false;
            this.btnRefreshVehicleList.Click += new System.EventHandler(this.btnRefreshVehicleList_Click);
            // 
            // frmManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshVehicleList);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.lblManageVehicleListing);
            this.Controls.Add(this.dgvVehicleList);
            this.Name = "frmManageVehicleListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.frmManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleList;
        private System.Windows.Forms.Label lblManageVehicleListing;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnRefreshVehicleList;
    }
}