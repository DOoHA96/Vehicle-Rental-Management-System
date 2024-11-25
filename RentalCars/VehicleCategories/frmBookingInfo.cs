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

namespace Forms2.VehicleCategories
{
    public partial class frmBookingInfo : Form
    {
        public frmBookingInfo(int bookingID)
        {
            _bookingID = bookingID;
            InitializeComponent();
        }

        private int _bookingID;
        clsBookings _Booking;
        clsPayments _Payment;
        clsReturns _Return;

        private void _LoadData()
        {
            _Booking = clsBookings.Find(_bookingID);
            _Payment = clsPayments.FindByBookingID(_bookingID);

            if (_Booking == null || _Payment == null)
            {
                MessageBox.Show("An error has occurred while finding booking with ID [" + _bookingID + "]", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblVehicleName.Text = _Booking.VehicleInfo.Name;
            lblBookingID.Text = _Booking.BookingID.ToString();
            lblStartDate.Text = _Booking.StartDate.ToString("d");
            lblEndDate.Text = _Booking.EndDate.ToString("d");
            lblFullName.Text = _Booking.CustomerInfo.Name;
            lblPhone.Text = _Booking.CustomerInfo.PhoneNumber;
            lblEmail.Text = _Booking.CustomerInfo.Email;
            lblRentalDays.Text = (_Booking.EndDate - _Booking.StartDate).Days.ToString();
            lblPricePerDay.Text = _Booking.PricePerDay.ToString();
            lblTotalAmount.Text = _Booking.InitialTotalDueAmount.ToString();
            lblPickupLocation.Text = _Booking.PickupLocation.ToString();
            lblDropoffLocation.Text = _Booking.DropoffLocation.ToString();
            if (_Booking.Notes != null)
                lblNotes.Text = _Booking.Notes.ToString();
            else
                lblNotes.Text = "NO Notes";

            if (_Booking.Status == "Completed")
                lblStatus.Text = "Completed";
            else
                lblStatus.Text = "Ongoing";

            if(_Booking.VehicleInfo.ImagePath != null)
                pbVehicleImage.ImageLocation = _Booking.VehicleInfo.ImagePath;

            lblInitialPaidTotalDueAmount.Text=_Payment.InitialPaidTotalDueAmount.ToString();
            lblPaymentDate.Text = _Payment.PaymentDate.ToString();
            lblUpdatedPaymentDate.Text= _Payment.UpdatedPaymentDate.ToString();
            lblUsername.Text=_Payment.UserInfo.UserName;
            if (_Payment.Details != null)
                lblDetails.Text = _Payment.Details.ToString();
            else
                lblDetails.Text = "No Details";

            if (_Payment.ActualTotalDueAmount.HasValue)
                lblActualTotalAmount.Text = _Payment.ActualTotalDueAmount.ToString();
            else
                lblActualTotalAmount.Text = "Not calculated yet";

            if (_Payment.TotalRemaining.HasValue)
                lblTotalRemaining.Text = _Payment.TotalRemaining.ToString();
            else
                lblTotalRemaining.Text = "Not Calculated yet";

            if (_Payment.TotalRefundedAmount.HasValue)
                lblTotalRefundedAmount.Text = _Payment.TotalRefundedAmount.ToString();
            else
                lblTotalRefundedAmount.Text = "Not calculated yet";

            btnReturnVehicle.Enabled = (!_Payment.ReturnID.HasValue);

            if (_Payment.ReturnID.HasValue )
            {
                pnlReturn.Visible = true;
                pnlVehicleOnRent.Visible = false;

                _Return=clsReturns.Find(_Payment.ReturnID);

                if( _Return!=null )
                {
                    lblActualRentalDays.Text = _Return.ActualRentalDays.ToString();
                    lblActualReturnDate.Text = _Return.ActualReturnDate.ToString();
                    lblConsumedMilage.Text = _Return.ConsumedMilage.ToString();
                    lblAdditionalCharges.Text = _Return.AdditionalCharges.ToString();
                    lblFinalCheckNotes.Text = _Return.FinalCheckNotes;
                    lblCreatedBy.Text = _Return.UserInfo.UserName;
                }
            }
            else
            {
                pnlReturn.Visible = false;
                pnlVehicleOnRent.Visible = true;
            }


        }

        private void frmBookingInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            tcBookingDetails.SelectedTab = tcBookingDetails.TabPages["tabInfo"];
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            tcBookingDetails.SelectedTab = tcBookingDetails.TabPages["tabPayments"];
        }

        private void btnReturnTab_Click(object sender, EventArgs e)
        {
            tcBookingDetails.SelectedTab = tcBookingDetails.TabPages["tabReturn"];
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            frmReturnVehicle frm = new frmReturnVehicle(_Booking, _Payment);

            frm.ShowDialog();

            _LoadData();
        }
    }
}
