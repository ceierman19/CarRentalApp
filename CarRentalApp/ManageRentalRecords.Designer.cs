namespace CarRentalApp
{
    partial class frmManageRentalRecords
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
            this.btnRefreshRentalRecords = new System.Windows.Forms.Button();
            this.btnDeleteRentalRecord = new System.Windows.Forms.Button();
            this.btnEditRentalRecord = new System.Windows.Forms.Button();
            this.btnAddNewRentalRecord = new System.Windows.Forms.Button();
            this.lblManageRentalRecords = new System.Windows.Forms.Label();
            this.dgvRentalRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshRentalRecords
            // 
            this.btnRefreshRentalRecords.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshRentalRecords.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshRentalRecords.Location = new System.Drawing.Point(49, 86);
            this.btnRefreshRentalRecords.Name = "btnRefreshRentalRecords";
            this.btnRefreshRentalRecords.Size = new System.Drawing.Size(181, 54);
            this.btnRefreshRentalRecords.TabIndex = 19;
            this.btnRefreshRentalRecords.Text = "Refresh";
            this.btnRefreshRentalRecords.UseVisualStyleBackColor = false;
            this.btnRefreshRentalRecords.Click += new System.EventHandler(this.btnRefreshRentalRecords_Click);
            // 
            // btnDeleteRentalRecord
            // 
            this.btnDeleteRentalRecord.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteRentalRecord.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRentalRecord.Location = new System.Drawing.Point(576, 378);
            this.btnDeleteRentalRecord.Name = "btnDeleteRentalRecord";
            this.btnDeleteRentalRecord.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteRentalRecord.TabIndex = 18;
            this.btnDeleteRentalRecord.Text = "Delete Record";
            this.btnDeleteRentalRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRentalRecord.Click += new System.EventHandler(this.btnDeleteRentalRecord_Click);
            // 
            // btnEditRentalRecord
            // 
            this.btnEditRentalRecord.BackColor = System.Drawing.Color.Gold;
            this.btnEditRentalRecord.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRentalRecord.Location = new System.Drawing.Point(312, 378);
            this.btnEditRentalRecord.Name = "btnEditRentalRecord";
            this.btnEditRentalRecord.Size = new System.Drawing.Size(181, 54);
            this.btnEditRentalRecord.TabIndex = 17;
            this.btnEditRentalRecord.Text = "Edit Record";
            this.btnEditRentalRecord.UseVisualStyleBackColor = false;
            this.btnEditRentalRecord.Click += new System.EventHandler(this.btnEditRentalRecord_Click);
            // 
            // btnAddNewRentalRecord
            // 
            this.btnAddNewRentalRecord.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewRentalRecord.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRentalRecord.Location = new System.Drawing.Point(49, 378);
            this.btnAddNewRentalRecord.Name = "btnAddNewRentalRecord";
            this.btnAddNewRentalRecord.Size = new System.Drawing.Size(181, 54);
            this.btnAddNewRentalRecord.TabIndex = 16;
            this.btnAddNewRentalRecord.Text = "Add New";
            this.btnAddNewRentalRecord.UseVisualStyleBackColor = false;
            this.btnAddNewRentalRecord.Click += new System.EventHandler(this.btnAddNewRentalRecord_Click);
            // 
            // lblManageRentalRecords
            // 
            this.lblManageRentalRecords.AutoSize = true;
            this.lblManageRentalRecords.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRentalRecords.Location = new System.Drawing.Point(147, 19);
            this.lblManageRentalRecords.Name = "lblManageRentalRecords";
            this.lblManageRentalRecords.Size = new System.Drawing.Size(480, 73);
            this.lblManageRentalRecords.TabIndex = 15;
            this.lblManageRentalRecords.Text = "Manage Rental Records";
            // 
            // dgvRentalRecords
            // 
            this.dgvRentalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentalRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecords.Location = new System.Drawing.Point(25, 146);
            this.dgvRentalRecords.Name = "dgvRentalRecords";
            this.dgvRentalRecords.RowHeadersWidth = 51;
            this.dgvRentalRecords.RowTemplate.Height = 24;
            this.dgvRentalRecords.Size = new System.Drawing.Size(754, 226);
            this.dgvRentalRecords.TabIndex = 14;
            // 
            // frmManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshRentalRecords);
            this.Controls.Add(this.btnDeleteRentalRecord);
            this.Controls.Add(this.btnEditRentalRecord);
            this.Controls.Add(this.btnAddNewRentalRecord);
            this.Controls.Add(this.lblManageRentalRecords);
            this.Controls.Add(this.dgvRentalRecords);
            this.Name = "frmManageRentalRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.frmManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshRentalRecords;
        private System.Windows.Forms.Button btnDeleteRentalRecord;
        private System.Windows.Forms.Button btnEditRentalRecord;
        private System.Windows.Forms.Button btnAddNewRentalRecord;
        private System.Windows.Forms.Label lblManageRentalRecords;
        private System.Windows.Forms.DataGridView dgvRentalRecords;
    }
}