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
using System.Xml.Linq;

namespace Forms2
{
    public partial class frmAddUpdateDocument : Form
    {
        public enum enMode  {Update,AddNew};
        enMode Mode = enMode.Update;

        int? CustomerID = null;
        int?DocumentID=null;

        clsDocuments _Documents;
        public frmAddUpdateDocument(int CustomerID,int DocumentID)
        {
            this.CustomerID = CustomerID;
            this.DocumentID = DocumentID;
            Mode = enMode.Update;
            InitializeComponent();
        }

        public frmAddUpdateDocument(int CustomerID)
        {
            this.CustomerID = CustomerID;
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        private void _ResetDefualtValues()
        {
            if (Mode == enMode.AddNew)
            {
                this.Text = "Add New Docuemnt";
                _Documents = new clsDocuments();
            }
            else
                this.Text = "Update Document";

            txtDocumentName.Text = string.Empty;
            txtDocumentPath.Text = string.Empty;
        }

        private void _LoadData()
        {
            _Documents = clsDocuments.Find(DocumentID);

            if( _Documents == null )
            {
                MessageBox.Show("Failed To Find Document With ID [" + DocumentID + "]", "Failed",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtDocumentName.Text = _Documents.Name;
            txtDocumentPath.Text= _Documents.Path;
        }

        private void frmAddUpdateDocument_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if(Mode ==enMode.Update)
                _LoadData();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDocumentPath.Text = openFileDialog1.FileName;
            }
        }

        private void txtDocumentPath_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentPath.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDocumentPath, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtDocumentPath, null);
            }
        }

        private void txtDocumentName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDocumentName, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtDocumentName, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Documents.Name = txtDocumentName.Text.Trim();
            _Documents.Path = txtDocumentPath.Text;
            _Documents.CustomerID = CustomerID;
            _Documents.CreatedBy = 1;

            if (_Documents.Save())
            {
                btnSave.Enabled = false;

                MessageBox.Show("Data Saved Successfully", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Save Data", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
