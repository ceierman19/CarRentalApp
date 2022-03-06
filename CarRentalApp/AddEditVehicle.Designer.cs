namespace CarRentalApp
{
    partial class frmAddEditVehicle
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
            this.tlpAddEditVehicle = new System.Windows.Forms.TableLayoutPanel();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblVin = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLIC = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtLIC = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tlpAddEditVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAddEditVehicle
            // 
            this.tlpAddEditVehicle.ColumnCount = 2;
            this.tlpAddEditVehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddEditVehicle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddEditVehicle.Controls.Add(this.txtVIN, 1, 2);
            this.tlpAddEditVehicle.Controls.Add(this.txtModel, 1, 1);
            this.tlpAddEditVehicle.Controls.Add(this.txtMake, 1, 0);
            this.tlpAddEditVehicle.Controls.Add(this.lblVin, 0, 2);
            this.tlpAddEditVehicle.Controls.Add(this.lblModel, 0, 1);
            this.tlpAddEditVehicle.Controls.Add(this.lblMake, 0, 0);
            this.tlpAddEditVehicle.Controls.Add(this.lblYear, 0, 4);
            this.tlpAddEditVehicle.Controls.Add(this.lblLIC, 0, 3);
            this.tlpAddEditVehicle.Controls.Add(this.txtYear, 1, 4);
            this.tlpAddEditVehicle.Controls.Add(this.txtLIC, 1, 3);
            this.tlpAddEditVehicle.Location = new System.Drawing.Point(12, 100);
            this.tlpAddEditVehicle.Name = "tlpAddEditVehicle";
            this.tlpAddEditVehicle.RowCount = 5;
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddEditVehicle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddEditVehicle.Size = new System.Drawing.Size(776, 250);
            this.tlpAddEditVehicle.TabIndex = 0;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(391, 103);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(261, 22);
            this.txtVIN.TabIndex = 17;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(391, 53);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(261, 22);
            this.txtModel.TabIndex = 16;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(391, 3);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(261, 22);
            this.txtMake.TabIndex = 15;
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVin.Location = new System.Drawing.Point(3, 100);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(33, 28);
            this.lblVin.TabIndex = 14;
            this.lblVin.Text = "VIN";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(3, 50);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 28);
            this.lblModel.TabIndex = 14;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(3, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(47, 28);
            this.lblMake.TabIndex = 12;
            this.lblMake.Text = "Make";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(3, 200);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 28);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year";
            // 
            // lblLIC
            // 
            this.lblLIC.AutoSize = true;
            this.lblLIC.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIC.Location = new System.Drawing.Point(3, 150);
            this.lblLIC.Name = "lblLIC";
            this.lblLIC.Size = new System.Drawing.Size(157, 28);
            this.lblLIC.TabIndex = 14;
            this.lblLIC.Text = "License Plate Number";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(391, 203);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(261, 22);
            this.txtYear.TabIndex = 18;
            // 
            // txtLIC
            // 
            this.txtLIC.Location = new System.Drawing.Point(391, 153);
            this.txtLIC.Name = "txtLIC";
            this.txtLIC.Size = new System.Drawing.Size(261, 22);
            this.txtLIC.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(88, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 54);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(508, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 54);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.Location = new System.Drawing.Point(230, 9);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(345, 73);
            this.lblAddEditTitle.TabIndex = 13;
            this.lblAddEditTitle.Text = "Add/Edit Vehicle";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 28);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Hidden ID";
            this.lblId.Visible = false;
            // 
            // frmAddEditVehicle
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tlpAddEditVehicle);
            this.Name = "frmAddEditVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditVehicle";
            this.tlpAddEditVehicle.ResumeLayout(false);
            this.tlpAddEditVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddEditVehicle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblLIC;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtLIC;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblId;
    }
}