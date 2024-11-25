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
    public partial class frmAddUpdateTuelType : Form
    {

       public  enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;

        int _FuelTypeID;
        clsFuelTypes _FuelType;
        public frmAddUpdateTuelType()
        {
            _Mode = enMode.AddNew;
            InitializeComponent();
        }

        public frmAddUpdateTuelType(int FuelTypeID)
        {
            _FuelTypeID = FuelTypeID;
            _Mode = enMode.Update;
            InitializeComponent();
        }

        private void frmAddUpdateTuelType_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _FuelType = new clsFuelTypes();
                this.Text = "Add New Fuel Type";
            }
            else
            {

                this.Text = "Update Fuel Type";

                _FuelType = clsFuelTypes.Find(_FuelTypeID);

                if (_FuelType == null)
                {
                    MessageBox.Show("No fuel type with ID = " + _FuelTypeID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
                }

                txtFuelType.Text = _FuelType.FuelType.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FuelType.FuelType = txtFuelType.Text.Trim();

            if (_FuelType.Save())
            {
                MessageBox.Show("Fuel type has been saved successfuly!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save fuel type!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFuelType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFuelType.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFuelType, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtFuelType, null);
            }
        }
    }
}
