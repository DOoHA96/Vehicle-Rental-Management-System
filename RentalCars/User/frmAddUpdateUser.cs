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
    public partial class frmAddUpdateUser : Form
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode = enMode.AddNew;

        int _UserID;
        clsUser _User;

        public frmAddUpdateUser()
        {
            _Mode = enMode.AddNew;
            InitializeComponent();
        }

        public frmAddUpdateUser(int UserID)
        {
            _UserID = UserID;
            _Mode = enMode.Update;
            InitializeComponent();
        }


        void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                this.Text = "Add New User";
            }
            else
            {
                this.Text = "Update User";
            }

            txtAddress.Text = "";
            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            btnRemoveImage.Visible = false;
            chkIsActive.Checked = false;
            pbImage.Image = Resources.man_avatar;
        }

        void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtAddress.Text = _User.Address.Trim();
            txtFullName.Text = _User.Name.Trim();
            txtPhoneNumber.Text = _User.PhoneNumber.Trim();
            txtPassword.Text = _User.Password.Trim();
            txtConfirmPassword.Text = _User.Password.Trim();
            txtUsername.Text = _User.Name.Trim();
            chkIsActive.Checked = (_User.IsActive == true);

            if (_User.ImagePath == null)
                pbImage.Image = Resources.man_avatar;
            else
            {
                pbImage.ImageLocation = _User.ImagePath;
                btnRemoveImage.Visible = true;
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "this field is required!");
                return;
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
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhoneNumber, null);
            };
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhoneNumber, "this field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhoneNumber, null);
            };
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) )
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "this field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            };

            if (_Mode == enMode.AddNew)
            {

                if (clsUser.IsUserNameExist(txtUsername.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUsername, null);
                };
            }
            else
            {

                if (_User.UserName != txtUsername.Text.Trim())
                {
                    if (clsUser.IsUserNameExist(txtUsername.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUsername, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUsername, null);
                    };
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "this field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "this field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };

            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Name = txtFullName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.Address = txtAddress.Text.Trim();
            _User.PhoneNumber = txtPhoneNumber.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
            _User.UserName = txtUsername.Text.Trim();

            if (pbImage.ImageLocation == null)
                _User.ImagePath = null;
            else
                _User.ImagePath = pbImage.ImageLocation;

            if (_User.Save())
            {
                if (_Mode == enMode.AddNew)
                    _ResetDefaultValues();

                MessageBox.Show("User has been saved successfuly!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to save User!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
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
            pbImage.Image = Resources.man_avatar;
            btnRemoveImage.Visible = false;
        }
    }
}
