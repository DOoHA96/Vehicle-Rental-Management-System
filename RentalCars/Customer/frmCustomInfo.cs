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
using System.Xml.Linq;

namespace Forms2
{
    public partial class frmCustomInfo : Form
    {
        public frmCustomInfo(int CustomerID)
        {
            _CustomerID = CustomerID;
            InitializeComponent();
        }

        private int _CustomerID;
        clsCustomer _Customer;
        clsBookings _Bookings;
        clsDocuments _Documents;

        private static DataTable _dtAllCustomerBookings;
        private DataTable _dtCustomerBookings;

        private static DataTable _dtAllDocuments;
        private DataTable _dtDocuments;


        private void _LoadData()
        {
            _Customer = clsCustomer.Find(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("No customer with ID = " + _CustomerID, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblCustomerName.Text = _Customer.Name;
            lblPhoneNumber.Text = _Customer.PhoneNumber;
            lblEmail.Text = _Customer.Email;
            lblAddress.Text = _Customer.Address;
            lblLicenseNo.Text = _Customer.LicenseNumber;
            lblDateOfBirth.Text = _Customer.DateOfBirth.ToString("d");
            if (_Customer.Gender == 1)
                lblGender.Text = "Male";
            else
                lblGender.Text = "Female";

            if(_Customer.ImagePath != null)
                pbImage.ImageLocation = _Customer.ImagePath;
            else
            {
                if (_Customer.Gender == 1)
                    pbImage.Image = Properties.Resources.man_avatar;
                else
                    pbImage.Image = Properties.Resources.woman_avatar;
            }

            
        }

        private void _LoadCustomerBookingData()
        {
            _dtAllCustomerBookings = clsBookings.GetAllByCustomer(_Customer.Name);

            if(_dtAllCustomerBookings.Rows.Count > 0)
            {
                _dtCustomerBookings = _dtAllCustomerBookings.DefaultView.ToTable(false, "BookingID", "Vehicle",
                    "Start Date", "End Date", "Status", "Created By");

                dgvCustomerBookings.DataSource = _dtCustomerBookings;

                dgvCustomerBookings.Columns["BookingID"].DisplayIndex = 0;
                dgvCustomerBookings.Columns["Vehicle"].DisplayIndex = 1;
                dgvCustomerBookings.Columns["Start Date"].DisplayIndex = 2;
                dgvCustomerBookings.Columns["End Date"].DisplayIndex = 3;
                dgvCustomerBookings.Columns["Status"].DisplayIndex = 4;
                dgvCustomerBookings.Columns["Created By"].DisplayIndex = 5;
                dgvCustomerBookings.Columns["View"].DisplayIndex = 6;
                dgvCustomerBookings.Columns["Delete"].DisplayIndex = 7;

                dgvCustomerBookings.Columns["BookingID"].Width = 80;
                dgvCustomerBookings.Columns["Created By"].Width = 90;
                dgvCustomerBookings.Columns["Vehicle"].Width = 150;
                dgvCustomerBookings.Columns["View"].Width = 30;
                dgvCustomerBookings.Columns["Delete"].Width = 30;
            }
        }

        private void _LoadDocumentsData()
        {
            _dtAllDocuments = clsDocuments.GetAll(_CustomerID);

            if (_dtAllDocuments.Rows.Count > 0)
            {
                _dtDocuments = _dtAllDocuments.DefaultView.ToTable(false, "DocumentID",
                    "Name", "Path", "Created By");

                dgvDocuments.DataSource = _dtDocuments;

                dgvDocuments.Columns["DocumentID"].DisplayIndex = 0;
                dgvDocuments.Columns["Name"].DisplayIndex = 1;
                dgvDocuments.Columns["Path"].DisplayIndex = 2;
                dgvDocuments.Columns["Created By"].DisplayIndex = 3;
                dgvDocuments.Columns["ViewDocument"].DisplayIndex = 4;
                dgvDocuments.Columns["DeleteDocument"].DisplayIndex = 5;

                dgvDocuments.Columns["ViewDocument"].Width = 30;
                dgvDocuments.Columns["DeleteDocument"].Width = 30;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            tcCustomerDetails.SelectedTab = tcCustomerDetails.TabPages["tabSummary"];
        }

        private void frmCustomInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
            _LoadCustomerBookingData();
            _LoadDocumentsData();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenChildForm(Form frm)
        {
            frm.TopLevel = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlCustomerInfo.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void dgvCustomerBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvCustomerBookings.Columns["View"].Index)
                {
                    //OpenChildForm(new frmBookingInfo((int)dgvCustomerBookings.CurrentRow.Cells["BookingID"].Value));
                }
                else if (e.ColumnIndex == dgvCustomerBookings.Columns["Delete"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete booking [" + dgvCustomerBookings.CurrentRow.Cells["BookingID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Perform Delete and refresh
                        if (clsBookings.Delete((int)dgvCustomerBookings.CurrentRow.Cells["BookingID"].Value))
                        {
                            MessageBox.Show("Booking Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _LoadData();
                        }

                        else
                            MessageBox.Show("Booking was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDocuments.Columns["ViewDocument"].Index)
                {
                    //_Document = clsDocuments.Find((int)dgvDocuments.CurrentRow.Cells["DocumentID"].Value);
                    //frmViewDocument frm = new frmViewDocument(_Document);
                    //frm.ShowDialog();
                }
                else if (e.ColumnIndex == dgvDocuments.Columns["DeleteDocument"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete document [" + dgvDocuments.CurrentRow.Cells["DocumentID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Perform Delete and refresh
                        if (clsDocuments.Delete((int)dgvDocuments.CurrentRow.Cells["DocumentID"].Value))
                        {
                            MessageBox.Show("Document Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _LoadData();

                            _LoadDocumentsData();
                        }

                        else
                            MessageBox.Show("Document was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            tcCustomerDetails.SelectedTab = tcCustomerDetails.TabPages["tabBookings"];
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            tcCustomerDetails.SelectedTab = tcCustomerDetails.TabPages["tabDocuments"];
        }

        private void txtDocumentFilterValue_TextChanged(object sender, EventArgs e)
        {
            _dtDocuments.DefaultView.RowFilter = $"Name LIKE '%{txtDocumentFilterValue.Text}%'";
        }
    }
}
