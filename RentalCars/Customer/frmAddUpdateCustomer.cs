using Forms2.Properties;
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
    public partial class frmAddUpdateCustomer : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _CustomerID ;
        clsCustomer _Customer;
        public frmAddUpdateCustomer()
        {
            _Mode = enMode.AddNew;
            InitializeComponent();
        }

        public frmAddUpdateCustomer(int customerID)
        {
            _CustomerID = customerID;
            _Mode = enMode.Update;
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            if(_Mode == enMode.AddNew)
            {
                this.Text = "Adding New Customer";
                _Customer = new clsCustomer();
            }
            else
            {
                this.Text = "Update Customer";
            }
            txtFullName.Text= string.Empty;
            txtPhoneNumber.Text= string.Empty;
            txtEmail.Text= string.Empty;
            txtAddress.Text= string.Empty;
            txtLicenseNo.Text= string.Empty;
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-16);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            rbMale.Checked = true;
            pbImage.Image = Properties.Resources.man_avatar;
            btnRemoveImage.Visible = false;
        }

        private void _LoadDate()
        {
            _Customer = clsCustomer.Find(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("No customer with ID = " + _CustomerID, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtFullName.Text = _Customer.Name;
            txtPhoneNumber.Text = _Customer.PhoneNumber;
            txtEmail.Text = _Customer.Email;
            txtAddress.Text = _Customer.Address;
            txtLicenseNo.Text = _Customer.LicenseNumber;
            dtpDateOfBirth.Value =_Customer.DateOfBirth;


            if (_Customer.Gender == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            btnRemoveImage.Enabled = (_Customer.ImagePath != null);

            if (_Customer.ImagePath != null)

                pbImage.ImageLocation = _Customer.ImagePath;


        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if(_Mode ==enMode.Update)
                _LoadDate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Customer.Email = txtEmail.Text.Trim();
            _Customer.Name = txtFullName.Text.Trim();
            _Customer.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Customer.Address = txtAddress.Text.Trim();
            _Customer.LicenseNumber = txtLicenseNo.Text.Trim();
            _Customer.DateOfBirth = dtpDateOfBirth.Value;

            if (rbFemale.Checked)
                _Customer.Gender = 0;
            else
                _Customer.Gender = 1;

            if (pbImage.ImageLocation != null)
                _Customer.ImagePath = pbImage.ImageLocation.ToString();
            else
                _Customer.ImagePath = null;

            if (_Customer.Save())
            {
                if (_Mode == enMode.AddNew)
                    _ResetDefualtValues();

                MessageBox.Show("Customer has been saved successfuly!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save Customer!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbImage.Load(selectedFilePath);
                btnRemoveImage.Visible = true;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbImage.ImageLocation = null;
            if (rbFemale.Checked)
            {
                pbImage.Image = Resources.woman_avatar;
            }
            else
            {
                pbImage.Image = Resources.man_avatar;
            }
            btnRemoveImage.Visible = false;
        }

        private void rbMale_CheckedChanged2(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Properties.Resources.man_avatar;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Properties.Resources.woman_avatar;
        }

        private void txtFullName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFullName, null);
            };
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhoneNumber, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtPhoneNumber, null);
            };
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtAddress, null);
            };
        }

        private void txtLicenseNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseNo, "this field is required!");
            }
            else
            {
                errorProvider1.SetError(txtLicenseNo, null);
            };
        }
    }
}
