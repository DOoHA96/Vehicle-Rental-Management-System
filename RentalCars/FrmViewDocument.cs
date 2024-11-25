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
    public partial class FrmViewDocument : Form
    {
        int? _DocumentID = null;

        clsDocuments _Document;
        private int v;

        public FrmViewDocument(clsDocuments Document)
        {
            _Document = Document;
            InitializeComponent();
        }

        public FrmViewDocument(int v)
        {
            this.v = v;
        }

        private void FrmViewDocument_Load(object sender, EventArgs e)
        {
            if (_Document != null)
            {
                pbDocument.ImageLocation = _Document.Path;
                lblDocumentName.Text = _Document.Name;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
