using RentalBusinessLayer;
using RentalDataAccess;
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
    public partial class frmReturnVehicle : Form
    {
        public frmReturnVehicle(clsBookings Book,clsPayments payment)
        {
            _Booking = Book;
            _Payment = payment;
            InitializeComponent();
        }

        clsBookings _Booking;
        clsPayments _Payment;
        clsReturnAndUpdate _Return = new clsReturnAndUpdate();

        private void frmReturnVehicle_Load(object sender, EventArgs e)
        {
            dtpReturnDate.Value = DateTime.Now;
            txtActualTotalDueAmount.Text = ((dtpReturnDate.Value.Date - _Booking.StartDate).Days * _Booking.PricePerDay).ToString();
        }

        private void txtConsumedMilage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConsumedMilage.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConsumedMilage, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtConsumedMilage, null);
            }
        }

        private void txtAdditionalCharges_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(!string.IsNullOrWhiteSpace(txtAdditionalCharges.Text))
                {
                    txtActualTotalDueAmount.Text = (Convert.ToDecimal(txtActualTotalDueAmount.Text) + Convert.ToDecimal(txtAdditionalCharges.Text)).ToString();
                }
            }
        }

        private void txtAdditionalCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpReturnDate.Value.Date == _Booking.EndDate.Date)
            {
                txtActualRentalDays.Text = _Booking.ActualRentalDays().ToString();
                txtActualTotalDueAmount.Text = Convert.ToSingle(_Booking.InitialTotalDueAmount + txtAdditionalCharges.Text).ToString();
            }
            else
            {
                txtActualRentalDays.Text = (dtpReturnDate.Value.Date -  _Booking.StartDate).Days.ToString();
                txtActualTotalDueAmount.Text = ((dtpReturnDate.Value.Date - _Booking.StartDate.Date).Days * _Booking.PricePerDay).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Return.ActualReturnDate=dtpReturnDate.Value;
            _Return.ActualRentalDays = byte.Parse(txtActualRentalDays.Text);
            _Return.ConsumedMilage = int.Parse(txtConsumedMilage.Text);
            _Return.FinalCheckNotes = txtFinalCheckNotes.Text;
            _Return.AdditionalCharges = !string.IsNullOrWhiteSpace(txtAdditionalCharges.Text) ? decimal.Parse(txtAdditionalCharges.Text) : 0;
            _Return.ActualTotalDueAmount = decimal.Parse(txtActualTotalDueAmount.Text);
            _Return.CreatedByUserID = 1;
            _Return.InitialPaidTotalDueAmount=_Payment.InitialPaidTotalDueAmount;
            _Return.VehicleID=_Booking.VehicleID;
            _Return.Milage=_Booking.VehicleInfo.Milage;
            _Return.PaymentID=_Payment.PaymentID;
            _Return.BookingID=_Booking.BookingID;

            if (_Return.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save data", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
