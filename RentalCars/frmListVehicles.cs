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
    public partial class frmListVehicles : Form
    {
        public frmListVehicles()
        {
            InitializeComponent();
        }

        static DataTable _dtAllVehicles = clsVehicle.GetAll();
        DataTable _dtVehicles = _dtAllVehicles.DefaultView.ToTable(false, "VehicleID",
            "Name", "Milage", "FuelType", "PlateNumber", "Category", "PricePerDay");

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            _dtAllVehicles = clsVehicle.GetAll();
            _dtVehicles = _dtAllVehicles.DefaultView.ToTable(false, "VehicleID",
            "Name", "Milage", "FuelType", "PlateNumber", "Category", "PricePerDay");

            if (_dtVehicles.Rows.Count > 0)
            {
                dgvAllVehicles.DataSource = _dtVehicles;
                dgvAllVehicles.Columns["VehicleID"].DisplayIndex = 0;
                dgvAllVehicles.Columns["Name"].DisplayIndex = 1;
                dgvAllVehicles.Columns["Milage"].DisplayIndex = 2;
                dgvAllVehicles.Columns["FuelType"].DisplayIndex = 3;
                dgvAllVehicles.Columns["PlateNumber"].DisplayIndex = 4;
                dgvAllVehicles.Columns["Category"].DisplayIndex = 5;
                dgvAllVehicles.Columns["PricePerDay"].DisplayIndex = 6;
                //dgvAllVehicles.Columns["IsAvailable"].DisplayIndex = 7;
                dgvAllVehicles.Columns["View"].DisplayIndex = 7;
                dgvAllVehicles.Columns["Edit"].DisplayIndex = 8;
                dgvAllVehicles.Columns["Delete"].DisplayIndex = 9;
                dgvAllVehicles.Columns["Name"].Width = 150;
                dgvAllVehicles.Columns["View"].Width = 30;
                dgvAllVehicles.Columns["Edit"].Width = 30;
                dgvAllVehicles.Columns["Delete"].Width = 30;
            }
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle();

            frm.ShowDialog();

            frmVehicles_Load(null, null);
        }

        private void OpenChildForm(Form ChildForm)
        {
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.TopLevel = false;

            pnlCustomerInfo.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void dgvAllVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == dgvAllVehicles.Columns["View"].Index)
                {
                    OpenChildForm(new frmVehicleInfo((int)dgvAllVehicles.CurrentRow.Cells["VehicleID"].Value));
                }
                else if (e.ColumnIndex == dgvAllVehicles.Columns["Edit"].Index)
                {
                    frmAddUpdateVehicle frm = new frmAddUpdateVehicle
                        ((int)dgvAllVehicles.CurrentRow.Cells["VehicleID"].Value);

                    frmVehicles_Load(null, null);
                }
                else if (e.ColumnIndex == dgvAllVehicles.Columns["Delete"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete Vehicle [" + dgvAllVehicles.CurrentRow.Cells["VehicleID"].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //Perform Delete and refresh
                        if (clsVehicle.Delete((int)dgvAllVehicles.CurrentRow.Cells["VehicleID"].Value))
                        {
                            MessageBox.Show("Vehicle Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmVehicles_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Vehicle was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _dtVehicles.DefaultView.RowFilter = $@"Name like '{txtFilterValue.Text}%' or 
                        Category LIKE '%{txtFilterValue.Text}%' OR FuelType LIKE '%{txtFilterValue.Text}%'";
        }
    }
}
