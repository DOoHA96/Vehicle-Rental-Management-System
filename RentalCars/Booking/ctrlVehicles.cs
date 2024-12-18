﻿using Forms2.Properties;
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

namespace Forms2.Booking
{
    public partial class ctrlVehicles : UserControl
    {
        public ctrlVehicles()
        {
            InitializeComponent();
        }

        clsVehicle _Vehicle;
        public frmAddUpdateBooking _frm;

        public clsVehicle Vehicle
        { get { return _Vehicle; } }


        void _SetDefaultValues()
        {
            pbVehicleImage.Image = Resources.car_placeholder;
            lblPricePerDay.Text = "[????]";
            lblVehicleName.Text = "[????]";
        }

        void _LoadData()
        {
            pbVehicleImage.ImageLocation = _Vehicle.ImagePath;
            lblVehicleName.Text = _Vehicle.Name;
            lblPricePerDay.Text = _Vehicle.PricePerDay + " Per Day";
        }

        public void LoadVehicleData(int VehicleID)
        {
            _Vehicle = clsVehicle.Find(VehicleID);

            if (_Vehicle == null)
                _SetDefaultValues();
            else
                _LoadData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _Vehicle = clsVehicle.FindIfAvailable(_Vehicle.VehicleID);

            if (_Vehicle == null)
            {
                MessageBox.Show("Vehicle Is NOT Available \n (On Rent/Under Maintenance)", "NOT Available",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _frm.tabBookingSteps.SelectedTab = _frm.tabBookingSteps.TabPages["StepThree"];
            _frm._Vehicle = _Vehicle;
            _frm.txtPricePerDays.Text = Vehicle.PricePerDay.ToString();
            _frm._LoadRentalInfo();
            _frm.lblVehicle.Visible = true;
            _frm.lblVehicle.Text = _Vehicle.Name;
            _frm.pbBookingImage.Image = Resources.ColoredAppointment;
        }
    }
}
