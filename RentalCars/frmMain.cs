using Forms2.Booking;
using Forms2.Dashboard;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.btnDashboard.PerformClick();
        }

        void OpenChildForm(Form CurrentForm)
        {

            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;

            pnlHome.Controls.Add(CurrentForm);
            CurrentForm.BringToFront();
            CurrentForm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListCustomers());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListVehicles());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListBookings(this));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSettings());
        }
    }
}
