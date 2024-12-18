﻿using Forms2.Properties;
using Forms2.VehicleCategories;
using RentalBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    public partial class frmVehicleInfo : Form
    {   
        public frmVehicleInfo(int vehiclesID)
        {
            _VehicleID = vehiclesID;
            InitializeComponent();
        }
        int _VehicleID;
        clsVehicle _Vehicle;

        static DataTable _dtAllVehicleReservations;
        DataTable _dtVehicleReservations;

        static DataTable _dtAllMaintenances;
        static DataTable _dtMaintenances;
        

        private void _loadData()
        {
            _Vehicle = clsVehicle.Find(_VehicleID);

            if (_Vehicle == null)
            {
                MessageBox.Show("The vehicle with ID " + _VehicleID + " was not found!", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblVehicleName.Text = _Vehicle.Name;
            lblPlateNumber.Text = _Vehicle.PlateNumber.Trim();
            lblIsAvailable.Text = (_Vehicle.IsAvailable == true) ? "Yes" : "NO";
            lblFuelType.Text = clsFuelTypes.Find(_Vehicle.FuelTypeID).FuelType;
            lblCategory.Text = clsCategories.Find(_Vehicle.VehicleCategoryID).CategoryName;
            lblMilage.Text = Convert.ToInt32(_Vehicle.Milage).ToString();
            lblPricePerDay.Text = Convert.ToDecimal(_Vehicle.PricePerDay).ToString();
            lblNumberOfRentals.Text = clsVehicle.GetNumberOfRentals(_Vehicle.VehicleID).ToString();

            if (_Vehicle.ImagePath != null)
                pbVehicleImage.ImageLocation = _Vehicle.ImagePath;
            else
                pbVehicleImage.Image = Resources.car_placeholder;
        }

        void _LoadReservations()
        {
            _dtAllVehicleReservations = clsVehicle.GetAllReservationsByVehicleID(_VehicleID);

            if (_dtAllVehicleReservations.Rows.Count > 0)
            {
                _dtVehicleReservations = _dtAllVehicleReservations.DefaultView.ToTable(false,
                    "BookingID", "Customer", "End Date", "Start Date", "Status", "Created By");

                dgvVehicleReservations.DataSource = _dtVehicleReservations;

                dgvVehicleReservations.Columns["BookingID"].DisplayIndex = 0;
                dgvVehicleReservations.Columns["Customer"].DisplayIndex = 1;
                dgvVehicleReservations.Columns["End Date"].DisplayIndex = 2;
                dgvVehicleReservations.Columns["Start Date"].DisplayIndex = 3;
                dgvVehicleReservations.Columns["Status"].DisplayIndex = 4;
                dgvVehicleReservations.Columns["Created By"].DisplayIndex = 5;

                dgvVehicleReservations.Columns["Customer"].Width = 150;
                dgvVehicleReservations.Columns["View"].Width = 30;
                dgvVehicleReservations.Columns["Delete"].Width = 30;
            }
        }

        void _LoadMaintenanceData()
        {

            _dtAllMaintenances = clsMaintenances.GetAllByVehicleID(_VehicleID);

            if (_dtAllMaintenances.Rows.Count > 0)
            {
                _dtMaintenances = _dtAllMaintenances.DefaultView.ToTable(false, "MaintenanceID",
                    "Vehicle", "Description", "Cost", "Status");

                dgvMaintenances.DataSource = _dtMaintenances;
                dgvMaintenances.Columns["MaintenanceID"].DisplayIndex = 0;
                dgvMaintenances.Columns["Vehicle"].DisplayIndex = 1;
                dgvMaintenances.Columns["Description"].DisplayIndex = 2;
                dgvMaintenances.Columns["Cost"].DisplayIndex = 3;
                dgvMaintenances.Columns["Status"].DisplayIndex = 4;
            }
        }

        void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlVehicleInfo.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void frmVehicleInfo_Load(object sender, EventArgs e)
        {
            _loadData();
            _LoadReservations();
            _LoadMaintenanceData();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            tcVehicleDetails.SelectedTab = tcVehicleDetails.TabPages["tabInfo"];
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            tcVehicleDetails.SelectedTab = tcVehicleDetails.TabPages["tabReservations"];
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            tcVehicleDetails.SelectedTab = tcVehicleDetails.TabPages["tabMaintenance"];
        }

        private void releaseVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release the vehicle?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsMaintenances.ReleaseVehicleAfterMaintenance((int)dgvMaintenances.CurrentRow.Cells["MaintenanceID"].Value, _VehicleID))
                {
                    lblIsAvailable.Text =  "Yes" ;
                    MessageBox.Show("Vehicle Released From Maintenance Successfully", "Released",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    _LoadMaintenanceData();
                }
                else
                {
                    MessageBox.Show("Failed To Release Vehicle", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmsReleaseVehicles_Opening(object sender, CancelEventArgs e)
        {
            if (dgvMaintenances.Rows.Count > 0)
                releaseVehiclesToolStripMenuItem.Enabled = !clsMaintenances.IsMaintenanceCompleted
                    ((int)dgvMaintenances.CurrentRow.Cells["MaintenanceID"].Value);
            else
                releaseVehiclesToolStripMenuItem.Enabled = false;
        }

        private void dgvVehicleReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvVehicleReservations.Columns["View"].Index)
                {
                    OpenChildForm(new frmBookingInfo((int)dgvVehicleReservations.CurrentRow.Cells["BookingID"].Value));
                }
                else if (e.ColumnIndex == dgvVehicleReservations.Columns["Delete"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete booking [" + dgvVehicleReservations.CurrentRow.Cells["BookingID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Perform Delete and refresh
                        if (clsBookings.Delete((int)dgvVehicleReservations.CurrentRow.Cells["BookingID"].Value))
                        {
                            MessageBox.Show("Booking Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _loadData();
                        }

                        else
                            MessageBox.Show("Booking was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
