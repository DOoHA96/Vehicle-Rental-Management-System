namespace Forms2
{
    partial class frmListVehicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListVehicles));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.dgvAllVehicles = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddNewVehicle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlCustomerInfo.Controls.Add(this.dgvAllVehicles);
            this.pnlCustomerInfo.Controls.Add(this.txtFilterValue);
            this.pnlCustomerInfo.Controls.Add(this.btnAddNewVehicle);
            this.pnlCustomerInfo.Controls.Add(this.bunifuSeparator1);
            this.pnlCustomerInfo.Controls.Add(this.label1);
            this.pnlCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(1324, 766);
            this.pnlCustomerInfo.TabIndex = 12;
            // 
            // dgvAllVehicles
            // 
            this.dgvAllVehicles.AllowCustomTheming = true;
            this.dgvAllVehicles.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAllVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllVehicles.ColumnHeadersHeight = 40;
            this.dgvAllVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.Edit,
            this.Delete});
            this.dgvAllVehicles.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAllVehicles.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllVehicles.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllVehicles.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllVehicles.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllVehicles.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAllVehicles.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllVehicles.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllVehicles.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllVehicles.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllVehicles.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllVehicles.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllVehicles.CurrentTheme.Name = null;
            this.dgvAllVehicles.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllVehicles.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllVehicles.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllVehicles.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllVehicles.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllVehicles.EnableHeadersVisualStyles = false;
            this.dgvAllVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllVehicles.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllVehicles.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAllVehicles.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllVehicles.Location = new System.Drawing.Point(51, 255);
            this.dgvAllVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllVehicles.Name = "dgvAllVehicles";
            this.dgvAllVehicles.ReadOnly = true;
            this.dgvAllVehicles.RowHeadersVisible = false;
            this.dgvAllVehicles.RowHeadersWidth = 51;
            this.dgvAllVehicles.RowTemplate.Height = 40;
            this.dgvAllVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllVehicles.Size = new System.Drawing.Size(1247, 460);
            this.dgvAllVehicles.TabIndex = 10;
            this.dgvAllVehicles.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvAllVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllVehicles_CellClick);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AcceptsReturn = false;
            this.txtFilterValue.AcceptsTab = false;
            this.txtFilterValue.AnimationSpeed = 200;
            this.txtFilterValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilterValue.AutoSizeHeight = true;
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFilterValue.BackgroundImage")));
            this.txtFilterValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFilterValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFilterValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderRadius = 35;
            this.txtFilterValue.BorderThickness = 1;
            this.txtFilterValue.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtFilterValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FillColor = System.Drawing.Color.White;
            this.txtFilterValue.HideSelection = true;
            this.txtFilterValue.IconLeft = null;
            this.txtFilterValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.IconPadding = 10;
            this.txtFilterValue.IconRight = null;
            this.txtFilterValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.Lines = new string[0];
            this.txtFilterValue.Location = new System.Drawing.Point(51, 135);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.MaxLength = 32767;
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterValue.Modified = false;
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties4;
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterValue.PlaceholderText = "Name, Category, Fuel Type";
            this.txtFilterValue.ReadOnly = false;
            this.txtFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.SelectionLength = 0;
            this.txtFilterValue.SelectionStart = 0;
            this.txtFilterValue.ShortcutsEnabled = true;
            this.txtFilterValue.Size = new System.Drawing.Size(382, 48);
            this.txtFilterValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterValue.TabIndex = 7;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterValue.TextMarginBottom = 0;
            this.txtFilterValue.TextMarginLeft = 3;
            this.txtFilterValue.TextMarginTop = 0;
            this.txtFilterValue.TextPlaceholder = "Name, Category, Fuel Type";
            this.txtFilterValue.UseSystemPasswordChar = false;
            this.txtFilterValue.WordWrap = true;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.AllowAnimations = true;
            this.btnAddNewVehicle.AllowMouseEffects = true;
            this.btnAddNewVehicle.AllowToggling = false;
            this.btnAddNewVehicle.AnimationSpeed = 200;
            this.btnAddNewVehicle.AutoGenerateColors = false;
            this.btnAddNewVehicle.AutoRoundBorders = false;
            this.btnAddNewVehicle.AutoSizeLeftIcon = true;
            this.btnAddNewVehicle.AutoSizeRightIcon = true;
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewVehicle.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewVehicle.BackgroundImage")));
            this.btnAddNewVehicle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewVehicle.ButtonText = "New";
            this.btnAddNewVehicle.ButtonTextMarginLeft = 0;
            this.btnAddNewVehicle.ColorContrastOnClick = 45;
            this.btnAddNewVehicle.ColorContrastOnHover = 45;
            this.btnAddNewVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddNewVehicle.CustomizableEdges = borderEdges1;
            this.btnAddNewVehicle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewVehicle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewVehicle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewVehicle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewVehicle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.IconLeft = null;
            this.btnAddNewVehicle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewVehicle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewVehicle.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnAddNewVehicle.IconMarginLeft = 11;
            this.btnAddNewVehicle.IconPadding = 10;
            this.btnAddNewVehicle.IconRight = null;
            this.btnAddNewVehicle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewVehicle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewVehicle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewVehicle.IconSize = 35;
            this.btnAddNewVehicle.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.IdleBorderRadius = 35;
            this.btnAddNewVehicle.IdleBorderThickness = 1;
            this.btnAddNewVehicle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.IdleIconLeftImage = null;
            this.btnAddNewVehicle.IdleIconRightImage = null;
            this.btnAddNewVehicle.IndicateFocus = false;
            this.btnAddNewVehicle.Location = new System.Drawing.Point(1120, 135);
            this.btnAddNewVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewVehicle.OnDisabledState.BorderRadius = 35;
            this.btnAddNewVehicle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewVehicle.OnDisabledState.BorderThickness = 1;
            this.btnAddNewVehicle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewVehicle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewVehicle.OnDisabledState.IconLeftImage = null;
            this.btnAddNewVehicle.OnDisabledState.IconRightImage = null;
            this.btnAddNewVehicle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.onHoverState.BorderRadius = 35;
            this.btnAddNewVehicle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewVehicle.onHoverState.BorderThickness = 1;
            this.btnAddNewVehicle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.onHoverState.IconLeftImage = null;
            this.btnAddNewVehicle.onHoverState.IconRightImage = null;
            this.btnAddNewVehicle.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.OnIdleState.BorderRadius = 35;
            this.btnAddNewVehicle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewVehicle.OnIdleState.BorderThickness = 1;
            this.btnAddNewVehicle.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.OnIdleState.IconLeftImage = null;
            this.btnAddNewVehicle.OnIdleState.IconRightImage = null;
            this.btnAddNewVehicle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.OnPressedState.BorderRadius = 35;
            this.btnAddNewVehicle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewVehicle.OnPressedState.BorderThickness = 1;
            this.btnAddNewVehicle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewVehicle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewVehicle.OnPressedState.IconLeftImage = null;
            this.btnAddNewVehicle.OnPressedState.IconRightImage = null;
            this.btnAddNewVehicle.Size = new System.Drawing.Size(178, 48);
            this.btnAddNewVehicle.TabIndex = 8;
            this.btnAddNewVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewVehicle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewVehicle.TextMarginLeft = 0;
            this.btnAddNewVehicle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddNewVehicle.UseDefaultRadiusAndThickness = true;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(51, 207);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1247, 17);
            this.bunifuSeparator1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicles List";
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
            // Edit
            // 
            this.Edit.FillWeight = 89.35146F;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Forms2.Properties.Resources.pencil;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
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
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 766);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Name = "frmVehicles";
            this.Text = "frmVehicles";
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerInfo;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAllVehicles;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewVehicle;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}