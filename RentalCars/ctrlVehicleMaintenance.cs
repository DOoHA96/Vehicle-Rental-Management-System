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
    public partial class ctrlVehicleMaintenance : UserControl
    {
        public ctrlVehicleMaintenance()
        {
            InitializeComponent();
        }

        public frmAddUpdatemaintenance _AddUpdateMaintenance;
        clsVehicle Vehicle;

        public void _LoadVehicleData(int VehicleID)
        {
            Vehicle = clsVehicle.Find(VehicleID);

            if(Vehicle == null )
                _ResetValues();
            else
                _LoadData();
        }

        private void _ResetValues()
        {
            pbVehicleImage.Image = Properties.Resources.car_placeholder;
            lblVehicleName.Text = "[????]";
        }

        private void _LoadData()
        {
            if (Vehicle.ImagePath != null)
            {
                pbVehicleImage.ImageLocation = Vehicle.ImagePath;
                lblVehicleName.Text = Vehicle.Name;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Vehicle = clsVehicle.FindIfAvailable(Vehicle.VehicleID);

            if (Vehicle == null)
            {
                MessageBox.Show("Vehicle Is NOT Available \n (On Rent/Under Maintenance)", "NOT Available",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _AddUpdateMaintenance.tcVehicleMaintenance.SelectedTab =
                _AddUpdateMaintenance.tcVehicleMaintenance.TabPages["tabMaintenanceInfo"];
            _AddUpdateMaintenance.btnSave.Enabled = true;
            _AddUpdateMaintenance.vehicle = Vehicle;
        }
    }
}
