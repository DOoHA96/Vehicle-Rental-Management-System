namespace Forms2
{
    partial class frmVehicleInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleInfo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlVehicleInfo = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnInfo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbVehicleImage = new System.Windows.Forms.PictureBox();
            this.btnReservations = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tcVehicleDetails = new Bunifu.UI.WinForms.BunifuPages();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lblNumberOfRentals = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMilage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.dgvVehicleReservations = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmsReleaseVehicles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.releaseVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.dgvMaintenances = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnMaintenance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lblIsAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblCategory = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.pnlVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicleImage)).BeginInit();
            this.tcVehicleDetails.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleReservations)).BeginInit();
            this.cmsReleaseVehicles.SuspendLayout();
            this.tabMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenances)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVehicleInfo
            // 
            this.pnlVehicleInfo.Controls.Add(this.pbBack);
            this.pnlVehicleInfo.Controls.Add(this.btnInfo);
            this.pnlVehicleInfo.Controls.Add(this.pbVehicleImage);
            this.pnlVehicleInfo.Controls.Add(this.btnReservations);
            this.pnlVehicleInfo.Controls.Add(this.tcVehicleDetails);
            this.pnlVehicleInfo.Controls.Add(this.btnMaintenance);
            this.pnlVehicleInfo.Controls.Add(this.bunifuShadowPanel1);
            this.pnlVehicleInfo.Controls.Add(this.lblVehicleName);
            this.pnlVehicleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehicleInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlVehicleInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVehicleInfo.Name = "pnlVehicleInfo";
            this.pnlVehicleInfo.Size = new System.Drawing.Size(1319, 768);
            this.pnlVehicleInfo.TabIndex = 39;
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::Forms2.Properties.Resources._return;
            this.pbBack.Location = new System.Drawing.Point(48, 17);
            this.pbBack.Margin = new System.Windows.Forms.Padding(4);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(46, 46);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 37;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AllowAnimations = true;
            this.btnInfo.AllowMouseEffects = true;
            this.btnInfo.AllowToggling = false;
            this.btnInfo.AnimationSpeed = 200;
            this.btnInfo.AutoGenerateColors = false;
            this.btnInfo.AutoRoundBorders = false;
            this.btnInfo.AutoSizeLeftIcon = true;
            this.btnInfo.AutoSizeRightIcon = true;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInfo.ButtonText = "Info";
            this.btnInfo.ButtonTextMarginLeft = 0;
            this.btnInfo.ColorContrastOnClick = 45;
            this.btnInfo.ColorContrastOnHover = 45;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = false;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = false;
            this.btnInfo.CustomizableEdges = borderEdges1;
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInfo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInfo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInfo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInfo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfo.IconLeft = null;
            this.btnInfo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInfo.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnInfo.IconMarginLeft = 11;
            this.btnInfo.IconPadding = 10;
            this.btnInfo.IconRight = null;
            this.btnInfo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInfo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInfo.IconSize = 35;
            this.btnInfo.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnInfo.IdleBorderRadius = 35;
            this.btnInfo.IdleBorderThickness = 1;
            this.btnInfo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.IdleIconLeftImage = null;
            this.btnInfo.IdleIconRightImage = null;
            this.btnInfo.IndicateFocus = false;
            this.btnInfo.Location = new System.Drawing.Point(112, 369);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInfo.OnDisabledState.BorderRadius = 35;
            this.btnInfo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInfo.OnDisabledState.BorderThickness = 1;
            this.btnInfo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInfo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInfo.OnDisabledState.IconLeftImage = null;
            this.btnInfo.OnDisabledState.IconRightImage = null;
            this.btnInfo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.onHoverState.BorderRadius = 35;
            this.btnInfo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInfo.onHoverState.BorderThickness = 1;
            this.btnInfo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInfo.onHoverState.IconLeftImage = null;
            this.btnInfo.onHoverState.IconRightImage = null;
            this.btnInfo.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnInfo.OnIdleState.BorderRadius = 35;
            this.btnInfo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInfo.OnIdleState.BorderThickness = 1;
            this.btnInfo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfo.OnIdleState.IconLeftImage = null;
            this.btnInfo.OnIdleState.IconRightImage = null;
            this.btnInfo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.OnPressedState.BorderRadius = 35;
            this.btnInfo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInfo.OnPressedState.BorderThickness = 1;
            this.btnInfo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnInfo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInfo.OnPressedState.IconLeftImage = null;
            this.btnInfo.OnPressedState.IconRightImage = null;
            this.btnInfo.Size = new System.Drawing.Size(180, 48);
            this.btnInfo.TabIndex = 27;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInfo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInfo.TextMarginLeft = 0;
            this.btnInfo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInfo.UseDefaultRadiusAndThickness = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pbVehicleImage
            // 
            this.pbVehicleImage.Image = global::Forms2.Properties.Resources.car__1_1;
            this.pbVehicleImage.Location = new System.Drawing.Point(117, 38);
            this.pbVehicleImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbVehicleImage.Name = "pbVehicleImage";
            this.pbVehicleImage.Size = new System.Drawing.Size(117, 98);
            this.pbVehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVehicleImage.TabIndex = 36;
            this.pbVehicleImage.TabStop = false;
            // 
            // btnReservations
            // 
            this.btnReservations.AllowAnimations = true;
            this.btnReservations.AllowMouseEffects = true;
            this.btnReservations.AllowToggling = false;
            this.btnReservations.AnimationSpeed = 200;
            this.btnReservations.AutoGenerateColors = false;
            this.btnReservations.AutoRoundBorders = false;
            this.btnReservations.AutoSizeLeftIcon = true;
            this.btnReservations.AutoSizeRightIcon = true;
            this.btnReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnReservations.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReservations.BackgroundImage")));
            this.btnReservations.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservations.ButtonText = "Reservations";
            this.btnReservations.ButtonTextMarginLeft = 0;
            this.btnReservations.ColorContrastOnClick = 45;
            this.btnReservations.ColorContrastOnHover = 45;
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnReservations.CustomizableEdges = borderEdges2;
            this.btnReservations.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservations.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReservations.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReservations.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReservations.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.IconLeft = null;
            this.btnReservations.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReservations.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnReservations.IconMarginLeft = 11;
            this.btnReservations.IconPadding = 10;
            this.btnReservations.IconRight = null;
            this.btnReservations.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservations.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReservations.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReservations.IconSize = 35;
            this.btnReservations.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnReservations.IdleBorderRadius = 1;
            this.btnReservations.IdleBorderThickness = 1;
            this.btnReservations.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.IdleIconLeftImage = null;
            this.btnReservations.IdleIconRightImage = null;
            this.btnReservations.IndicateFocus = false;
            this.btnReservations.Location = new System.Drawing.Point(292, 369);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReservations.OnDisabledState.BorderRadius = 1;
            this.btnReservations.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservations.OnDisabledState.BorderThickness = 1;
            this.btnReservations.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReservations.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReservations.OnDisabledState.IconLeftImage = null;
            this.btnReservations.OnDisabledState.IconRightImage = null;
            this.btnReservations.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.onHoverState.BorderRadius = 1;
            this.btnReservations.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservations.onHoverState.BorderThickness = 1;
            this.btnReservations.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReservations.onHoverState.IconLeftImage = null;
            this.btnReservations.onHoverState.IconRightImage = null;
            this.btnReservations.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnReservations.OnIdleState.BorderRadius = 1;
            this.btnReservations.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservations.OnIdleState.BorderThickness = 1;
            this.btnReservations.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReservations.OnIdleState.IconLeftImage = null;
            this.btnReservations.OnIdleState.IconRightImage = null;
            this.btnReservations.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.OnPressedState.BorderRadius = 1;
            this.btnReservations.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReservations.OnPressedState.BorderThickness = 1;
            this.btnReservations.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnReservations.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReservations.OnPressedState.IconLeftImage = null;
            this.btnReservations.OnPressedState.IconRightImage = null;
            this.btnReservations.Size = new System.Drawing.Size(180, 48);
            this.btnReservations.TabIndex = 28;
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReservations.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReservations.TextMarginLeft = 0;
            this.btnReservations.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReservations.UseDefaultRadiusAndThickness = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // tcVehicleDetails
            // 
            this.tcVehicleDetails.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcVehicleDetails.AllowTransitions = true;
            this.tcVehicleDetails.Controls.Add(this.tabInfo);
            this.tcVehicleDetails.Controls.Add(this.tabReservations);
            this.tcVehicleDetails.Controls.Add(this.tabMaintenance);
            this.tcVehicleDetails.Location = new System.Drawing.Point(112, 421);
            this.tcVehicleDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tcVehicleDetails.Multiline = true;
            this.tcVehicleDetails.Name = "tcVehicleDetails";
            this.tcVehicleDetails.Page = this.tabMaintenance;
            this.tcVehicleDetails.PageIndex = 2;
            this.tcVehicleDetails.PageName = "tabMaintenance";
            this.tcVehicleDetails.PageTitle = "tabPage3";
            //this.tcVehicleDetails.SelectedIndex = 2;
            this.tcVehicleDetails.Size = new System.Drawing.Size(1087, 350);
            this.tcVehicleDetails.TabIndex = 35;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.tcVehicleDetails.Transition = animation1;
            this.tcVehicleDetails.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabInfo.Controls.Add(this.lblNumberOfRentals);
            this.tabInfo.Controls.Add(this.label4);
            this.tabInfo.Controls.Add(this.lblPricePerDay);
            this.tabInfo.Controls.Add(this.label3);
            this.tabInfo.Controls.Add(this.lblMilage);
            this.tabInfo.Controls.Add(this.label9);
            this.tabInfo.Location = new System.Drawing.Point(4, 4);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(1079, 321);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "tabPage1";
            // 
            // lblNumberOfRentals
            // 
            this.lblNumberOfRentals.AutoSize = true;
            this.lblNumberOfRentals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblNumberOfRentals.Location = new System.Drawing.Point(65, 182);
            this.lblNumberOfRentals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfRentals.Name = "lblNumberOfRentals";
            this.lblNumberOfRentals.Size = new System.Drawing.Size(21, 24);
            this.lblNumberOfRentals.TabIndex = 55;
            this.lblNumberOfRentals.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(63, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 33);
            this.label4.TabIndex = 54;
            this.label4.Text = "Number Of Rentals";
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblPricePerDay.Location = new System.Drawing.Point(314, 84);
            this.lblPricePerDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(53, 24);
            this.lblPricePerDay.TabIndex = 53;
            this.lblPricePerDay.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(312, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 33);
            this.label3.TabIndex = 52;
            this.label3.Text = "Price Per Day";
            // 
            // lblMilage
            // 
            this.lblMilage.AutoSize = true;
            this.lblMilage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblMilage.Location = new System.Drawing.Point(65, 84);
            this.lblMilage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilage.Name = "lblMilage";
            this.lblMilage.Size = new System.Drawing.Size(68, 24);
            this.lblMilage.TabIndex = 51;
            this.lblMilage.Text = "Milage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(63, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 33);
            this.label9.TabIndex = 50;
            this.label9.Text = "Milage";
            // 
            // tabReservations
            // 
            this.tabReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabReservations.Controls.Add(this.dgvVehicleReservations);
            this.tabReservations.Location = new System.Drawing.Point(4, 4);
            this.tabReservations.Margin = new System.Windows.Forms.Padding(4);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(4);
            this.tabReservations.Size = new System.Drawing.Size(1079, 321);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "tabPage2";
            // 
            // dgvVehicleReservations
            // 
            this.dgvVehicleReservations.AllowCustomTheming = true;
            this.dgvVehicleReservations.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvVehicleReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicleReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicleReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicleReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehicleReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicleReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicleReservations.ColumnHeadersHeight = 40;
            this.dgvVehicleReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.Delete});
            this.dgvVehicleReservations.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvVehicleReservations.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvVehicleReservations.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVehicleReservations.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvVehicleReservations.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVehicleReservations.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvVehicleReservations.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvVehicleReservations.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            this.dgvVehicleReservations.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvVehicleReservations.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehicleReservations.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            this.dgvVehicleReservations.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVehicleReservations.CurrentTheme.Name = null;
            this.dgvVehicleReservations.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehicleReservations.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvVehicleReservations.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVehicleReservations.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvVehicleReservations.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicleReservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehicleReservations.EnableHeadersVisualStyles = false;
            this.dgvVehicleReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvVehicleReservations.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            this.dgvVehicleReservations.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvVehicleReservations.HeaderForeColor = System.Drawing.Color.White;
            this.dgvVehicleReservations.Location = new System.Drawing.Point(7, 22);
            this.dgvVehicleReservations.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehicleReservations.Name = "dgvVehicleReservations";
            this.dgvVehicleReservations.ReadOnly = true;
            this.dgvVehicleReservations.RowHeadersVisible = false;
            this.dgvVehicleReservations.RowHeadersWidth = 51;
            this.dgvVehicleReservations.RowTemplate.Height = 40;
            this.dgvVehicleReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicleReservations.Size = new System.Drawing.Size(1064, 287);
            this.dgvVehicleReservations.TabIndex = 9;
            this.dgvVehicleReservations.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvVehicleReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleReservations_CellClick);
            // 
            // View
            // 
            this.View.FillWeight = 58.36425F;
            this.View.HeaderText = "";
            this.View.Image = global::Forms2.Properties.Resources.view;
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 152.2843F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Forms2.Properties.Resources.delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // cmsReleaseVehicles
            // 
            this.cmsReleaseVehicles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReleaseVehicles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.releaseVehiclesToolStripMenuItem});
            this.cmsReleaseVehicles.Name = "cmsReleaseVehicles";
            this.cmsReleaseVehicles.Size = new System.Drawing.Size(187, 28);
            this.cmsReleaseVehicles.Opening += new System.ComponentModel.CancelEventHandler(this.cmsReleaseVehicles_Opening);
            // 
            // releaseVehiclesToolStripMenuItem
            // 
            this.releaseVehiclesToolStripMenuItem.Name = "releaseVehiclesToolStripMenuItem";
            this.releaseVehiclesToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.releaseVehiclesToolStripMenuItem.Text = "Release Vehicles";
            this.releaseVehiclesToolStripMenuItem.Click += new System.EventHandler(this.releaseVehiclesToolStripMenuItem_Click);
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabMaintenance.Controls.Add(this.dgvMaintenances);
            this.tabMaintenance.Location = new System.Drawing.Point(4, 4);
            this.tabMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Padding = new System.Windows.Forms.Padding(4);
            this.tabMaintenance.Size = new System.Drawing.Size(1079, 321);
            this.tabMaintenance.TabIndex = 2;
            this.tabMaintenance.Text = "tabPage3";
            // 
            // dgvMaintenances
            // 
            this.dgvMaintenances.AllowCustomTheming = true;
            this.dgvMaintenances.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvMaintenances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaintenances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenances.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaintenances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaintenances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaintenances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMaintenances.ColumnHeadersHeight = 40;
            this.dgvMaintenances.ContextMenuStrip = this.cmsReleaseVehicles;
            this.dgvMaintenances.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvMaintenances.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMaintenances.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMaintenances.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMaintenances.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMaintenances.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvMaintenances.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMaintenances.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            this.dgvMaintenances.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvMaintenances.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMaintenances.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            this.dgvMaintenances.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMaintenances.CurrentTheme.Name = null;
            this.dgvMaintenances.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaintenances.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvMaintenances.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMaintenances.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvMaintenances.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaintenances.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMaintenances.EnableHeadersVisualStyles = false;
            this.dgvMaintenances.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMaintenances.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(136)))), ((int)(((byte)(159)))));
            this.dgvMaintenances.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMaintenances.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMaintenances.Location = new System.Drawing.Point(7, 22);
            this.dgvMaintenances.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaintenances.Name = "dgvMaintenances";
            this.dgvMaintenances.ReadOnly = true;
            this.dgvMaintenances.RowHeadersVisible = false;
            this.dgvMaintenances.RowHeadersWidth = 51;
            this.dgvMaintenances.RowTemplate.Height = 40;
            this.dgvMaintenances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenances.Size = new System.Drawing.Size(1064, 287);
            this.dgvMaintenances.TabIndex = 10;
            this.dgvMaintenances.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.AllowAnimations = true;
            this.btnMaintenance.AllowMouseEffects = true;
            this.btnMaintenance.AllowToggling = false;
            this.btnMaintenance.AnimationSpeed = 200;
            this.btnMaintenance.AutoGenerateColors = false;
            this.btnMaintenance.AutoRoundBorders = false;
            this.btnMaintenance.AutoSizeLeftIcon = true;
            this.btnMaintenance.AutoSizeRightIcon = true;
            this.btnMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintenance.BackgroundImage")));
            this.btnMaintenance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaintenance.ButtonText = "Maintenance";
            this.btnMaintenance.ButtonTextMarginLeft = 0;
            this.btnMaintenance.ColorContrastOnClick = 45;
            this.btnMaintenance.ColorContrastOnHover = 45;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = false;
            borderEdges3.TopRight = true;
            this.btnMaintenance.CustomizableEdges = borderEdges3;
            this.btnMaintenance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaintenance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMaintenance.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMaintenance.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMaintenance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.IconLeft = null;
            this.btnMaintenance.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMaintenance.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnMaintenance.IconMarginLeft = 11;
            this.btnMaintenance.IconPadding = 10;
            this.btnMaintenance.IconRight = null;
            this.btnMaintenance.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaintenance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMaintenance.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMaintenance.IconSize = 35;
            this.btnMaintenance.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnMaintenance.IdleBorderRadius = 35;
            this.btnMaintenance.IdleBorderThickness = 1;
            this.btnMaintenance.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.IdleIconLeftImage = null;
            this.btnMaintenance.IdleIconRightImage = null;
            this.btnMaintenance.IndicateFocus = false;
            this.btnMaintenance.Location = new System.Drawing.Point(471, 369);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMaintenance.OnDisabledState.BorderRadius = 35;
            this.btnMaintenance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaintenance.OnDisabledState.BorderThickness = 1;
            this.btnMaintenance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMaintenance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMaintenance.OnDisabledState.IconLeftImage = null;
            this.btnMaintenance.OnDisabledState.IconRightImage = null;
            this.btnMaintenance.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.onHoverState.BorderRadius = 35;
            this.btnMaintenance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaintenance.onHoverState.BorderThickness = 1;
            this.btnMaintenance.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.onHoverState.IconLeftImage = null;
            this.btnMaintenance.onHoverState.IconRightImage = null;
            this.btnMaintenance.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnMaintenance.OnIdleState.BorderRadius = 35;
            this.btnMaintenance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaintenance.OnIdleState.BorderThickness = 1;
            this.btnMaintenance.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.OnIdleState.IconLeftImage = null;
            this.btnMaintenance.OnIdleState.IconRightImage = null;
            this.btnMaintenance.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.OnPressedState.BorderRadius = 35;
            this.btnMaintenance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMaintenance.OnPressedState.BorderThickness = 1;
            this.btnMaintenance.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnMaintenance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.OnPressedState.IconLeftImage = null;
            this.btnMaintenance.OnPressedState.IconRightImage = null;
            this.btnMaintenance.Size = new System.Drawing.Size(180, 48);
            this.btnMaintenance.TabIndex = 31;
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaintenance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMaintenance.TextMarginLeft = 0;
            this.btnMaintenance.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMaintenance.UseDefaultRadiusAndThickness = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.lblIsAvailable);
            this.bunifuShadowPanel1.Controls.Add(this.label8);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuSeparator3);
            this.bunifuShadowPanel1.Controls.Add(this.lblFuelType);
            this.bunifuShadowPanel1.Controls.Add(this.label5);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuSeparator2);
            this.bunifuShadowPanel1.Controls.Add(this.lblCategory);
            this.bunifuShadowPanel1.Controls.Add(this.Category);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuShadowPanel1.Controls.Add(this.lblPlateNumber);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(112, 169);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1087, 162);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 34;
            // 
            // lblIsAvailable
            // 
            this.lblIsAvailable.AutoSize = true;
            this.lblIsAvailable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblIsAvailable.Location = new System.Drawing.Point(881, 92);
            this.lblIsAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsAvailable.Name = "lblIsAvailable";
            this.lblIsAvailable.Size = new System.Drawing.Size(42, 24);
            this.lblIsAvailable.TabIndex = 36;
            this.lblIsAvailable.Text = "Yes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(878, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 33);
            this.label8.TabIndex = 35;
            this.label8.Text = "Is Available";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(793, 39);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator3.Size = new System.Drawing.Size(28, 92);
            this.bunifuSeparator3.TabIndex = 34;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblFuelType.Location = new System.Drawing.Point(356, 92);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(91, 24);
            this.lblFuelType.TabIndex = 33;
            this.lblFuelType.Text = "FuelType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(354, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fuel Type";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(536, 39);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator2.Size = new System.Drawing.Size(28, 92);
            this.bunifuSeparator2.TabIndex = 31;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblCategory.Location = new System.Drawing.Point(623, 92);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 30;
            this.lblCategory.Text = "Category";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.Category.Location = new System.Drawing.Point(621, 42);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 33);
            this.Category.TabIndex = 29;
            this.Category.Text = "Category";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(270, 39);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(28, 92);
            this.bunifuSeparator1.TabIndex = 28;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblPlateNumber.Location = new System.Drawing.Point(58, 92);
            this.lblPlateNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(125, 24);
            this.lblPlateNumber.TabIndex = 27;
            this.lblPlateNumber.Text = "PlateNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Plate Number";
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.lblVehicleName.Location = new System.Drawing.Point(240, 70);
            this.lblVehicleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(224, 41);
            this.lblVehicleName.TabIndex = 33;
            this.lblVehicleName.Text = "Vehicle Name";
            // 
            // frmVehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 768);
            this.Controls.Add(this.pnlVehicleInfo);
            this.Name = "frmVehicleInfo";
            this.Text = "frmVehicleInfo";
            this.Load += new System.EventHandler(this.frmVehicleInfo_Load);
            this.pnlVehicleInfo.ResumeLayout(false);
            this.pnlVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicleImage)).EndInit();
            this.tcVehicleDetails.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleReservations)).EndInit();
            this.cmsReleaseVehicles.ResumeLayout(false);
            this.tabMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenances)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVehicleInfo;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbVehicleImage;
        private Bunifu.UI.WinForms.BunifuPages tcVehicleDetails;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label lblNumberOfRentals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMilage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabReservations;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvVehicleReservations;
        private System.Windows.Forms.TabPage tabMaintenance;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMaintenances;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label lblIsAvailable;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label Category;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVehicleName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInfo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReservations;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMaintenance;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ContextMenuStrip cmsReleaseVehicles;
        private System.Windows.Forms.ToolStripMenuItem releaseVehiclesToolStripMenuItem;
    }
}