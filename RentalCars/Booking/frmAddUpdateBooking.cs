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
    public partial class frmAddUpdateBooking : Form
    {
        public frmAddUpdateBooking()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllCustomers;
        DataTable _dtCustomers;

        clsBookings _Booking = new clsBookings();
        clsPayments _Payment = new clsPayments();
        public clsVehicle _Vehicle;
        ctrlVehicles ctrl;
        DataTable dtVehicles = clsVehicle.GetAll();

        private void _LoadCustomerData()
        {
            _dtAllCustomers = clsCustomer.GetAllCustomers();


            if (_dtAllCustomers.Rows.Count > 0)
            {
                _dtCustomers = _dtAllCustomers.DefaultView.ToTable(false,
                "CustomerID", "Name", "LicenseNumber", "PhoneNumber");

                dgvAllCustomers.DataSource = _dtCustomers;

                dgvAllCustomers.Columns["CustomerID"].DisplayIndex = 0;
                dgvAllCustomers.Columns["Name"].DisplayIndex = 1;
                dgvAllCustomers.Columns["LicenseNumber"].DisplayIndex = 2;
                dgvAllCustomers.Columns["PhoneNumber"].DisplayIndex = 3;


            }
        }

        private void frmAddUpdateBooking_Load(object sender, EventArgs e)
        {
            _LoadCustomerData();
            _LoadVehicleData();
            
            txtDays.Text = (dtpEndDate.Value - dtpStartDate.Value).Days.ToString();

        }

        public void _LoadRentalInfo()
        {
            txtTotalAmount.Text = (Convert.ToInt32(txtDays.Text) * Convert.ToInt32(txtPricePerDays.Text)).ToString();
            txtInitialPaidTotalAmount.Text=txtTotalAmount.Text;

        }

        private void _LoadVehicleData()
        {

            if(dtVehicles.Rows.Count > 0)
            {
                for (int i = 0; i < dtVehicles.Rows.Count; i++) 
                {
                    ctrl = new ctrlVehicles();
                    pnlVehicles.Controls.Add(ctrl);
                    ctrl.LoadVehicleData(Convert.ToInt32(dtVehicles.Rows[i][0]));

                    ctrl._frm = this;
                }
            }
        }
        private void dgvAllCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _Booking.CustomerID = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;
                tabBookingSteps.SelectedTab = tabBookingSteps.TabPages["StepTwo"];
                lblCustomer.Visible = true;
                lblCustomer.Text = (string)dgvAllCustomers.CurrentRow.Cells["Name"].Value;
                pbStepTwo.Image = Properties.Resources.car__1_2;
            }
        }

        private void txtPickUPLocation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPickupLocation.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPickupLocation, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtPickupLocation, null);
            };
        }

        private void txtDropOffLocation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDropOffLocation.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDropOffLocation, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtDropOffLocation, null);
            };
        }

        private void tabBookingSteps_Enter(object sender, EventArgs e)
        {
            /*dtpStartDate.MinDate = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(1);
            txtDays.Text = (dtpEndDate.Value - dtpStartDate.Value).Days.ToString();
            //txtPricePerDays.Text = "1";
            txtTotalAmount.Text = (Convert.ToInt32(txtDays.Text) * Convert.ToInt32(txtPricePerDays.Text)).ToString();
            txtInitialPaidTotalAmount.Text = txtTotalAmount.Text;*/
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            txtDays.Text = (dtpEndDate.Value - dtpStartDate.Value).Days.ToString();
            txtTotalAmount.Text = (Convert.ToInt32(txtDays.Text) * Convert.ToInt32(txtPricePerDays.Text)).ToString();
            txtInitialPaidTotalAmount.Text = txtTotalAmount.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some validate is requred ", "Error");
                return;
            }


            _Booking.VehicleID = _Vehicle.VehicleID;
            _Booking.StartDate=dtpStartDate.Value;
            _Booking.EndDate=dtpEndDate.Value;
            _Booking.DropoffLocation = txtDropOffLocation.Text;
            _Booking.PickupLocation = txtPickupLocation.Text;
            _Booking.PricePerDay=_Vehicle.PricePerDay;
            _Booking.InitialTotalDueAmount = int.Parse(txtTotalAmount.Text);
            _Booking.Status = "Ongoing";
            _Booking.Notes = txtNotes.Text;
            _Booking.CreatedByUserID = 1;

            _Payment.Details=txtPaymentDetails.Text;
            _Payment.PaymentDate = DateTime.Now;
            _Payment.UpdatedPaymentDate = DateTime.Now;
            _Payment.InitialPaidTotalDueAmount = int.Parse(txtInitialPaidTotalAmount.Text);
            _Payment.CreatedByUserID = 1;

            _Vehicle.IsAvailable = false;
            
            if(_Booking.Save())
            {
                _Payment.BookingID= _Booking.BookingID;

                if (_Payment.Save() && _Vehicle.Save())
                {
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
                else
                    MessageBox.Show("_Payment Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("_Booking Not Saved","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
