namespace CarRentalApp
{
    partial class frmAddEditRentalRecord
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
            this.lblAddEditRentalRecord = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dtpRented = new System.Windows.Forms.DateTimePicker();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.cboTypeOfCar = new System.Windows.Forms.ComboBox();
            this.lblTypeOfCar = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddEditRentalRecord
            // 
            this.lblAddEditRentalRecord.AutoSize = true;
            this.lblAddEditRentalRecord.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditRentalRecord.Location = new System.Drawing.Point(113, 9);
            this.lblAddEditRentalRecord.Name = "lblAddEditRentalRecord";
            this.lblAddEditRentalRecord.Size = new System.Drawing.Size(476, 73);
            this.lblAddEditRentalRecord.TabIndex = 0;
            this.lblAddEditRentalRecord.Text = "Add/Edit Rental Record";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(32, 128);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(261, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(27, 97);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(121, 28);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // dtpRented
            // 
            this.dtpRented.Location = new System.Drawing.Point(32, 227);
            this.dtpRented.Name = "dtpRented";
            this.dtpRented.Size = new System.Drawing.Size(261, 22);
            this.dtpRented.TabIndex = 3;
            // 
            // dtpReturned
            // 
            this.dtpReturned.Location = new System.Drawing.Point(366, 227);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(261, 22);
            this.dtpReturned.TabIndex = 4;
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRented.Location = new System.Drawing.Point(27, 196);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(93, 28);
            this.lblDateRented.TabIndex = 5;
            this.lblDateRented.Text = "Date Rented";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(361, 196);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(108, 28);
            this.lblDateReturned.TabIndex = 6;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // cboTypeOfCar
            // 
            this.cboTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfCar.FormattingEnabled = true;
            this.cboTypeOfCar.Location = new System.Drawing.Point(32, 332);
            this.cboTypeOfCar.Name = "cboTypeOfCar";
            this.cboTypeOfCar.Size = new System.Drawing.Size(267, 24);
            this.cboTypeOfCar.TabIndex = 7;
            // 
            // lblTypeOfCar
            // 
            this.lblTypeOfCar.AutoSize = true;
            this.lblTypeOfCar.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfCar.Location = new System.Drawing.Point(27, 301);
            this.lblTypeOfCar.Name = "lblTypeOfCar";
            this.lblTypeOfCar.Size = new System.Drawing.Size(90, 28);
            this.lblTypeOfCar.TabIndex = 8;
            this.lblTypeOfCar.Text = "Type of Car";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(63, 384);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 54);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(366, 128);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(261, 22);
            this.txtCost.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(361, 100);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(42, 28);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Cost";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordId.Location = new System.Drawing.Point(12, 9);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(74, 28);
            this.lblRecordId.TabIndex = 15;
            this.lblRecordId.Text = "Hidden ID";
            this.lblRecordId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(408, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 54);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEditRentalRecord
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTypeOfCar);
            this.Controls.Add(this.cboTypeOfCar);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.dtpReturned);
            this.Controls.Add(this.dtpRented);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblAddEditRentalRecord);
            this.Name = "frmAddEditRentalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Rental Record";
            this.Load += new System.EventHandler(this.frmAddEditRentalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditRentalRecord;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DateTimePicker dtpRented;
        private System.Windows.Forms.DateTimePicker dtpReturned;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.ComboBox cboTypeOfCar;
        private System.Windows.Forms.Label lblTypeOfCar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.Button btnCancel;
    }
}

