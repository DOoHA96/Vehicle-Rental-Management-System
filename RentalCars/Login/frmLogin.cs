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

namespace Forms2.User
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUsername.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (User != null)
            {
                if (chkRememberMe.Checked)
                {

                    clsGlobal.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {

                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                clsGlobal.CurrentUser = User;

                this.Hide();

                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
