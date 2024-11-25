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
    public partial class frmAddUpdateCategories : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;

        int _VehicleCategoryID;
        clsCategories _VehicleCategory;
        public frmAddUpdateCategories()
        {
            _Mode = enMode.AddNew;
            InitializeComponent();
        }

        public frmAddUpdateCategories(int VehicleCategoryID)
        {
            _VehicleCategoryID = VehicleCategoryID;
            _Mode = enMode.Update;
            InitializeComponent();
        }

        private void frmAddUpdateCategories_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                
                _VehicleCategory = new clsCategories();
                this.Text = "Add New Vehicle Category";
            }
            else
            {
                this.Text = "Update Vehicle Category";

                _VehicleCategory = clsCategories.Find(_VehicleCategoryID);

                if (_VehicleCategory == null)
                {
                    MessageBox.Show("No vehicle category with ID = " + _VehicleCategoryID, "Vehicle Type Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
                }

                txtVehicleCategoryName.Text = _VehicleCategory.CategoryName.Trim();
            }
        }



        private void txtVehicleCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleCategoryName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVehicleCategoryName, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtVehicleCategoryName, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            _VehicleCategory.CategoryName = txtVehicleCategoryName.Text.Trim();

            if (_VehicleCategory.Save())
            {
                MessageBox.Show("Vehicle category has been saved successfuly!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save vehicle category!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
