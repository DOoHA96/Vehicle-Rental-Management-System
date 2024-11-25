namespace Forms2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnVehicles = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnCustomers = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(78, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1350, 814);
            this.pnlHome.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnVehicles);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 814);
            this.panel1.TabIndex = 2;
            // 
            // btnBookings
            // 
            this.btnBookings.ActiveImage = null;
            this.btnBookings.AllowAnimations = true;
            this.btnBookings.AllowBuffering = false;
            this.btnBookings.AllowToggling = false;
            this.btnBookings.AllowZooming = true;
            this.btnBookings.AllowZoomingOnFocus = false;
            this.btnBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnBookings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBookings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBookings.ErrorImage")));
            this.btnBookings.FadeWhenInactive = false;
            this.btnBookings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBookings.Image = global::Forms2.Properties.Resources.booking;
            this.btnBookings.ImageActive = null;
            this.btnBookings.ImageLocation = null;
            this.btnBookings.ImageMargin = 2;
            this.btnBookings.ImageSize = new System.Drawing.Size(33, 35);
            this.btnBookings.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnBookings.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBookings.InitialImage")));
            this.btnBookings.Location = new System.Drawing.Point(22, 492);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Rotation = 0;
            this.btnBookings.ShowActiveImage = true;
            this.btnBookings.ShowCursorChanges = true;
            this.btnBookings.ShowImageBorders = true;
            this.btnBookings.ShowSizeMarkers = false;
            this.btnBookings.Size = new System.Drawing.Size(35, 37);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.ToolTipText = "";
            this.btnBookings.WaitOnLoad = false;
            this.btnBookings.Zoom = 2;
            this.btnBookings.ZoomSpeed = 10;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveImage = null;
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowBuffering = false;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AllowZooming = true;
            this.btnSettings.AllowZoomingOnFocus = false;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ErrorImage")));
            this.btnSettings.FadeWhenInactive = false;
            this.btnSettings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSettings.Image = global::Forms2.Properties.Resources.Settings;
            this.btnSettings.ImageActive = null;
            this.btnSettings.ImageLocation = null;
            this.btnSettings.ImageMargin = 2;
            this.btnSettings.ImageSize = new System.Drawing.Size(33, 35);
            this.btnSettings.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnSettings.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.InitialImage")));
            this.btnSettings.Location = new System.Drawing.Point(22, 571);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0;
            this.btnSettings.ShowActiveImage = true;
            this.btnSettings.ShowCursorChanges = true;
            this.btnSettings.ShowImageBorders = true;
            this.btnSettings.ShowSizeMarkers = false;
            this.btnSettings.Size = new System.Drawing.Size(35, 37);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.ToolTipText = "";
            this.btnSettings.WaitOnLoad = false;
            this.btnSettings.Zoom = 2;
            this.btnSettings.ZoomSpeed = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.ActiveImage = null;
            this.btnVehicles.AllowAnimations = true;
            this.btnVehicles.AllowBuffering = false;
            this.btnVehicles.AllowToggling = false;
            this.btnVehicles.AllowZooming = true;
            this.btnVehicles.AllowZoomingOnFocus = false;
            this.btnVehicles.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVehicles.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnVehicles.ErrorImage")));
            this.btnVehicles.FadeWhenInactive = false;
            this.btnVehicles.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnVehicles.Image = global::Forms2.Properties.Resources.car;
            this.btnVehicles.ImageActive = null;
            this.btnVehicles.ImageLocation = null;
            this.btnVehicles.ImageMargin = 2;
            this.btnVehicles.ImageSize = new System.Drawing.Size(33, 35);
            this.btnVehicles.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnVehicles.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnVehicles.InitialImage")));
            this.btnVehicles.Location = new System.Drawing.Point(22, 414);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Rotation = 0;
            this.btnVehicles.ShowActiveImage = true;
            this.btnVehicles.ShowCursorChanges = true;
            this.btnVehicles.ShowImageBorders = true;
            this.btnVehicles.ShowSizeMarkers = false;
            this.btnVehicles.Size = new System.Drawing.Size(35, 37);
            this.btnVehicles.TabIndex = 3;
            this.btnVehicles.ToolTipText = "";
            this.btnVehicles.WaitOnLoad = false;
            this.btnVehicles.Zoom = 2;
            this.btnVehicles.ZoomSpeed = 10;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.ActiveImage = null;
            this.btnCustomers.AllowAnimations = true;
            this.btnCustomers.AllowBuffering = false;
            this.btnCustomers.AllowToggling = false;
            this.btnCustomers.AllowZooming = true;
            this.btnCustomers.AllowZoomingOnFocus = false;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomers.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.ErrorImage")));
            this.btnCustomers.FadeWhenInactive = false;
            this.btnCustomers.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCustomers.Image = global::Forms2.Properties.Resources.user__6_;
            this.btnCustomers.ImageActive = null;
            this.btnCustomers.ImageLocation = null;
            this.btnCustomers.ImageMargin = 2;
            this.btnCustomers.ImageSize = new System.Drawing.Size(33, 35);
            this.btnCustomers.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnCustomers.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.InitialImage")));
            this.btnCustomers.Location = new System.Drawing.Point(21, 335);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Rotation = 0;
            this.btnCustomers.ShowActiveImage = true;
            this.btnCustomers.ShowCursorChanges = true;
            this.btnCustomers.ShowImageBorders = true;
            this.btnCustomers.ShowSizeMarkers = false;
            this.btnCustomers.Size = new System.Drawing.Size(35, 37);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.ToolTipText = "";
            this.btnCustomers.WaitOnLoad = false;
            this.btnCustomers.Zoom = 2;
            this.btnCustomers.ZoomSpeed = 10;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ActiveImage = null;
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowBuffering = false;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AllowZooming = true;
            this.btnDashboard.AllowZoomingOnFocus = false;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ErrorImage")));
            this.btnDashboard.FadeWhenInactive = false;
            this.btnDashboard.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDashboard.Image = global::Forms2.Properties.Resources.dashboard__1_;
            this.btnDashboard.ImageActive = null;
            this.btnDashboard.ImageLocation = null;
            this.btnDashboard.ImageMargin = 2;
            this.btnDashboard.ImageSize = new System.Drawing.Size(33, 35);
            this.btnDashboard.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnDashboard.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.InitialImage")));
            this.btnDashboard.Location = new System.Drawing.Point(21, 256);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Rotation = 0;
            this.btnDashboard.ShowActiveImage = true;
            this.btnDashboard.ShowCursorChanges = true;
            this.btnDashboard.ShowImageBorders = true;
            this.btnDashboard.ShowSizeMarkers = false;
            this.btnDashboard.Size = new System.Drawing.Size(35, 37);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.ToolTipText = "";
            this.btnDashboard.WaitOnLoad = false;
            this.btnDashboard.Zoom = 2;
            this.btnDashboard.ZoomSpeed = 10;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms2.Properties.Resources.rental;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 814);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnBookings;
        private Bunifu.UI.WinForms.BunifuImageButton btnSettings;
        private Bunifu.UI.WinForms.BunifuImageButton btnVehicles;
        private Bunifu.UI.WinForms.BunifuImageButton btnCustomers;
        private Bunifu.UI.WinForms.BunifuImageButton btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}