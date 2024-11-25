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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        DataTable _dtVehiclesCategory = clsCategories.GetAll();

        DataTable _dtFuelTypes;

        static DataTable _dtAllUsers = clsUser.GetAllUsers();

        static DataTable _dtAllMaintenances;
        static DataTable _dtMaintenances;


        private void btnVehicleCategories_Click(object sender, EventArgs e)
        {
            tcSettings.SelectedTab = tcSettings.TabPages["tabVehicleCategories"];
        }

        private void _LoadVehicleCategoriesData()
        {
            _dtVehiclesCategory = clsCategories.GetAll();
            if(_dtVehiclesCategory.Rows.Count > 0)
            {
                dgvVehicleCategories.DataSource = _dtVehiclesCategory.Rows;

                dgvVehicleCategories.DataSource = _dtVehiclesCategory;

                dgvVehicleCategories.Columns["CategoryID"].DisplayIndex = 0;
                dgvVehicleCategories.Columns["Category"].DisplayIndex = 1;
                dgvVehicleCategories.Columns["EditVehicleCategory"].DisplayIndex = 2;
                dgvVehicleCategories.Columns["DeleteVehicleCategory"].DisplayIndex = 3;
                dgvVehicleCategories.Columns["EditVehicleCategory"].Width = 30;
                dgvVehicleCategories.Columns["DeleteVehicleCategory"].Width = 30;
            }
        }

        private void _LoadFuelTypesData()
        {
            _dtFuelTypes = clsFuelTypes.GetAll();

            if (_dtFuelTypes.Rows.Count > 0)
            {
                dgvFuelTypes.DataSource = _dtFuelTypes;
                dgvFuelTypes.Columns["FuelTypeID"].DisplayIndex = 0;
                dgvFuelTypes.Columns["FuelType"].DisplayIndex = 1;
                dgvFuelTypes.Columns["EditFuelType"].DisplayIndex = 2;
                dgvFuelTypes.Columns["DeleteFuelType"].DisplayIndex = 3;
                dgvFuelTypes.Columns["EditFuelType"].Width = 30;
                dgvFuelTypes.Columns["DeleteFuelType"].Width = 30;
            }
        }

        void _LoadUsersData()
        {
            

            _dtAllUsers = clsUser.GetAllUsers();

            if (_dtAllUsers.Rows.Count > 0)
            {
                _dtAllUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "FullName",
                    "Username", "Status");

                dgvUsers.DataSource = _dtAllUsers;
                dgvUsers.Columns["UserID"].DisplayIndex = 0;
                dgvUsers.Columns["FullName"].DisplayIndex = 1;
                dgvUsers.Columns["Username"].DisplayIndex = 2;
                dgvUsers.Columns["Status"].DisplayIndex = 3;
                dgvUsers.Columns["EditUser"].DisplayIndex = 4;
                dgvUsers.Columns["DeleteUser"].DisplayIndex = 5;
                dgvUsers.Columns["EditUser"].Width = 30;
                dgvUsers.Columns["DeleteUser"].Width = 30;
            }
        }

        void _LoadMaintenanceData()
        {

            _dtAllMaintenances = clsMaintenances.GetAll();

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



        private void frmSettings_Load(object sender, EventArgs e)
        {
            _LoadVehicleCategoriesData();
            _LoadFuelTypesData();
            _LoadUsersData();
            _LoadMaintenanceData();
        }

        private void txtVehicleCategoryFilterValue_TextChanged(object sender, EventArgs e)
        {
            _dtVehiclesCategory.DefaultView.RowFilter = $"Category like '{txtVehicleCategoryFilterValue.Text}%'";
        }

        private void btnAddNewVehicleCategory_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategories frm = new frmAddUpdateCategories();
            frm.ShowDialog();

            _LoadVehicleCategoriesData();
        }

        private void dgvVehicleCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                if(e.ColumnIndex == dgvVehicleCategories.Columns["EditVehicleCategory"].Index)
                {
                    frmAddUpdateCategories frm = new frmAddUpdateCategories
                        ((int)dgvVehicleCategories.CurrentRow.Cells["CategoryID"].Value);

                    frm.ShowDialog();

                    _LoadVehicleCategoriesData();
                }

                else if(e.ColumnIndex == dgvVehicleCategories.Columns["DeleteVehicleCategory"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete Vehicle category [" + dgvVehicleCategories.CurrentRow.Cells["CategoryID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (clsCategories.Delete((int)dgvVehicleCategories.CurrentRow.Cells["CategoryID"].Value))
                        {
                            MessageBox.Show("Vehicle Category Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _LoadVehicleCategoriesData();
                        }

                        else
                            MessageBox.Show("Vehicle category was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFuelTypes_Click(object sender, EventArgs e)
        {
            tcSettings.SelectedTab = tcSettings.TabPages["tabFuelTypes"];
        }

        private void btnAddNewFuelType_Click(object sender, EventArgs e)
        {
            frmAddUpdateTuelType frm = new frmAddUpdateTuelType();

            frm.ShowDialog();

            _LoadFuelTypesData();
        }

        private void txtFuelTypeFilterValue_TextChanged(object sender, EventArgs e)
        {
            _dtFuelTypes.DefaultView.RowFilter = $"FuelType Like '{txtFuelTypeFilterValue.Text}%'";
        }

        private void dgvFuelTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                if (e.ColumnIndex == dgvFuelTypes.Columns["EditFuelType"].Index)
                {
                    frmAddUpdateTuelType frm = new frmAddUpdateTuelType
                        ((int)dgvFuelTypes.CurrentRow.Cells["FuelTypeID"].Value);

                    frm.ShowDialog();

                    _LoadFuelTypesData();
                }

                else if (e.ColumnIndex == dgvFuelTypes.Columns["DeleteFuelType"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete fuel type [" + dgvFuelTypes.CurrentRow.Cells["FuelTypeID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        if (clsFuelTypes.Delete((int)dgvFuelTypes.CurrentRow.Cells["FuelTypeID"].Value))
                        {
                            MessageBox.Show("Fuel Type Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _LoadFuelTypesData();
                        }

                        else
                            MessageBox.Show("Fuel type was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            tcSettings.SelectedTab = tcSettings.TabPages["tabMaintenance"];
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            tcSettings.SelectedTab = tcSettings.TabPages["tabUsers"];
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // update user 
                if (e.ColumnIndex == dgvUsers.Columns["EditUser"].Index)
                {
                    frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
                    frm.ShowDialog();

                    // refresh and view updated data
                    _LoadUsersData();
                }
                else if (e.ColumnIndex == dgvUsers.Columns["DeleteUser"].Index)
                {
                    // delete user
                    if (MessageBox.Show("Are you sure you want to delete User [" + dgvUsers.CurrentRow.Cells["UserID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Perform Delete and refresh
                        if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value))
                        {
                            MessageBox.Show("User Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _LoadUsersData();
                        }

                        else
                            MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();

            _LoadUsersData();
        }

        private void txtUserValueFilter_TextChanged(object sender, EventArgs e)
        {
            _dtAllUsers.DefaultView.RowFilter = $"FullName LIKE '{txtUserValueFilter.Text}%' OR Username LIKE '{txtUserValueFilter.Text}%'";
        }

        private void btnAddNewMaintenance_Click(object sender, EventArgs e)
        {
            frmAddUpdatemaintenance frm = new frmAddUpdatemaintenance();
            frm.ShowDialog();
        }

        private void txtMaintenanceValueFilter_TextChanged(object sender, EventArgs e)
        {
            _dtMaintenances.DefaultView.RowFilter = $"Vehicle Like '{txtMaintenanceValueFilter.Text}%'";
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release the vehicle?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsMaintenances maintenance = clsMaintenances.Find((int)dgvMaintenances.CurrentRow.Cells["MaintenanceID"].Value);

                if (clsMaintenances.ReleaseVehicleAfterMaintenance((int)dgvMaintenances.CurrentRow.Cells["MaintenanceID"].Value, (int)maintenance.VehicleID))
                {
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

        private void cmsReleaseVehicle_Opening(object sender, CancelEventArgs e)
        {
            if (dgvMaintenances.Rows.Count > 0)
                releaseToolStripMenuItem.Enabled = !clsMaintenances.IsMaintenanceCompleted((int)dgvMaintenances.CurrentRow.Cells["MaintenanceID"].Value);
            else
                releaseToolStripMenuItem.Enabled = false;
        }
    }
}
