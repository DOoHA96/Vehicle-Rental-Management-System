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
    public partial class frmAddUpdatemaintenance : Form
    {
        public frmAddUpdatemaintenance()
        {
            InitializeComponent();
        }

        public clsVehicle vehicle;
        clsMaintenances _Maintenance = new clsMaintenances();

        DataTable dtVehicles = clsVehicle.GetAll();
        ctrlVehicleMaintenance ctrl;

        private void _ListVehicles()
        {
            if (dtVehicles.Rows.Count > 0)
            {
                for (int i = 0; i < dtVehicles.Rows.Count; i ++)
                {
                    ctrl = new ctrlVehicleMaintenance();
                    pnlListVehicles.Controls.Add(ctrl);
                    ctrl._LoadVehicleData(Convert.ToInt32(dtVehicles.Rows[i][0]));

                    ctrl._AddUpdateMaintenance = this;
                }
            }
        }

        private void frmAddUpdatemaintenance_Load(object sender, EventArgs e)
        {
            _ListVehicles();
            dtpMaintenanceDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCost, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtCost, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Maintenance.VehicleID = vehicle.VehicleID;
            _Maintenance.Description = txtDescription.Text.Trim();
            _Maintenance.Cost = int.Parse(txtCost.Text.Trim());
            _Maintenance.MaintenanceDate = dtpMaintenanceDate.Value;
            _Maintenance.Status = "On Process";
            _Maintenance.CreatedByUserID = 1;
            vehicle.IsAvailable = false;

            if (_Maintenance.Save())
            if (vehicle.Save())
            {
                
                MessageBox.Show("Data Saved Successfully", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed To Save Data", "Failed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
