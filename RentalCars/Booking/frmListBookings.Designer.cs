namespace Forms2.Booking
{
    partial class frmListBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBookings));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllBookings = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtBookingFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddNewBooking = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvAllBookings);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.txtBookingFilterValue);
            this.panel1.Controls.Add(this.btnAddNewBooking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 766);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bookings";
            // 
            // dgvAllBookings
            // 
            this.dgvAllBookings.AllowCustomTheming = true;
            this.dgvAllBookings.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAllBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllBookings.ColumnHeadersHeight = 40;
            this.dgvAllBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.Delete});
            this.dgvAllBookings.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAllBookings.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllBookings.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllBookings.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllBookings.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllBookings.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAllBookings.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllBookings.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllBookings.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllBookings.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllBookings.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllBookings.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllBookings.CurrentTheme.Name = null;
            this.dgvAllBookings.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllBookings.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllBookings.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllBookings.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllBookings.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllBookings.EnableHeadersVisualStyles = false;
            this.dgvAllBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllBookings.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllBookings.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAllBookings.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllBookings.Location = new System.Drawing.Point(51, 255);
            this.dgvAllBookings.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllBookings.Name = "dgvAllBookings";
            this.dgvAllBookings.ReadOnly = true;
            this.dgvAllBookings.RowHeadersVisible = false;
            this.dgvAllBookings.RowHeadersWidth = 51;
            this.dgvAllBookings.RowTemplate.Height = 40;
            this.dgvAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllBookings.Size = new System.Drawing.Size(1247, 460);
            this.dgvAllBookings.TabIndex = 8;
            this.dgvAllBookings.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvAllBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBookings_CellClick);
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
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(51, 206);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(1247, 17);
            this.bunifuSeparator2.TabIndex = 7;
            // 
            // txtBookingFilterValue
            // 
            this.txtBookingFilterValue.AcceptsReturn = false;
            this.txtBookingFilterValue.AcceptsTab = false;
            this.txtBookingFilterValue.AnimationSpeed = 200;
            this.txtBookingFilterValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBookingFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBookingFilterValue.AutoSizeHeight = true;
            this.txtBookingFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtBookingFilterValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBookingFilterValue.BackgroundImage")));
            this.txtBookingFilterValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBookingFilterValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBookingFilterValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBookingFilterValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBookingFilterValue.BorderRadius = 35;
            this.txtBookingFilterValue.BorderThickness = 1;
            this.txtBookingFilterValue.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBookingFilterValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBookingFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingFilterValue.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingFilterValue.DefaultText = "";
            this.txtBookingFilterValue.FillColor = System.Drawing.Color.White;
            this.txtBookingFilterValue.HideSelection = true;
            this.txtBookingFilterValue.IconLeft = null;
            this.txtBookingFilterValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingFilterValue.IconPadding = 10;
            this.txtBookingFilterValue.IconRight = null;
            this.txtBookingFilterValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingFilterValue.Lines = new string[0];
            this.txtBookingFilterValue.Location = new System.Drawing.Point(51, 135);
            this.txtBookingFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingFilterValue.MaxLength = 32767;
            this.txtBookingFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBookingFilterValue.Modified = false;
            this.txtBookingFilterValue.Multiline = false;
            this.txtBookingFilterValue.Name = "txtBookingFilterValue";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBookingFilterValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBookingFilterValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBookingFilterValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBookingFilterValue.OnIdleState = stateProperties4;
            this.txtBookingFilterValue.Padding = new System.Windows.Forms.Padding(4);
            this.txtBookingFilterValue.PasswordChar = '\0';
            this.txtBookingFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBookingFilterValue.PlaceholderText = "Full Name, License No.";
            this.txtBookingFilterValue.ReadOnly = false;
            this.txtBookingFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookingFilterValue.SelectedText = "";
            this.txtBookingFilterValue.SelectionLength = 0;
            this.txtBookingFilterValue.SelectionStart = 0;
            this.txtBookingFilterValue.ShortcutsEnabled = true;
            this.txtBookingFilterValue.Size = new System.Drawing.Size(382, 48);
            this.txtBookingFilterValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBookingFilterValue.TabIndex = 1;
            this.txtBookingFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBookingFilterValue.TextMarginBottom = 0;
            this.txtBookingFilterValue.TextMarginLeft = 3;
            this.txtBookingFilterValue.TextMarginTop = 0;
            this.txtBookingFilterValue.TextPlaceholder = "Full Name, License No.";
            this.txtBookingFilterValue.UseSystemPasswordChar = false;
            this.txtBookingFilterValue.WordWrap = true;
            this.txtBookingFilterValue.TextChanged += new System.EventHandler(this.txtBookingFilterValue_TextChanged);
            // 
            // btnAddNewBooking
            // 
            this.btnAddNewBooking.AllowAnimations = true;
            this.btnAddNewBooking.AllowMouseEffects = true;
            this.btnAddNewBooking.AllowToggling = false;
            this.btnAddNewBooking.AnimationSpeed = 200;
            this.btnAddNewBooking.AutoGenerateColors = false;
            this.btnAddNewBooking.AutoRoundBorders = false;
            this.btnAddNewBooking.AutoSizeLeftIcon = true;
            this.btnAddNewBooking.AutoSizeRightIcon = true;
            this.btnAddNewBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewBooking.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewBooking.BackgroundImage")));
            this.btnAddNewBooking.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBooking.ButtonText = "New";
            this.btnAddNewBooking.ButtonTextMarginLeft = 0;
            this.btnAddNewBooking.ColorContrastOnClick = 45;
            this.btnAddNewBooking.ColorContrastOnHover = 45;
            this.btnAddNewBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddNewBooking.CustomizableEdges = borderEdges1;
            this.btnAddNewBooking.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewBooking.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewBooking.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewBooking.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewBooking.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewBooking.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.IconLeft = null;
            this.btnAddNewBooking.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBooking.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewBooking.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnAddNewBooking.IconMarginLeft = 11;
            this.btnAddNewBooking.IconPadding = 10;
            this.btnAddNewBooking.IconRight = null;
            this.btnAddNewBooking.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewBooking.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewBooking.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewBooking.IconSize = 35;
            this.btnAddNewBooking.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.IdleBorderRadius = 35;
            this.btnAddNewBooking.IdleBorderThickness = 1;
            this.btnAddNewBooking.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.IdleIconLeftImage = null;
            this.btnAddNewBooking.IdleIconRightImage = null;
            this.btnAddNewBooking.IndicateFocus = false;
            this.btnAddNewBooking.Location = new System.Drawing.Point(1120, 135);
            this.btnAddNewBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewBooking.Name = "btnAddNewBooking";
            this.btnAddNewBooking.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewBooking.OnDisabledState.BorderRadius = 35;
            this.btnAddNewBooking.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBooking.OnDisabledState.BorderThickness = 1;
            this.btnAddNewBooking.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewBooking.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewBooking.OnDisabledState.IconLeftImage = null;
            this.btnAddNewBooking.OnDisabledState.IconRightImage = null;
            this.btnAddNewBooking.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.onHoverState.BorderRadius = 35;
            this.btnAddNewBooking.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBooking.onHoverState.BorderThickness = 1;
            this.btnAddNewBooking.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.onHoverState.IconLeftImage = null;
            this.btnAddNewBooking.onHoverState.IconRightImage = null;
            this.btnAddNewBooking.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.OnIdleState.BorderRadius = 35;
            this.btnAddNewBooking.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBooking.OnIdleState.BorderThickness = 1;
            this.btnAddNewBooking.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.OnIdleState.IconLeftImage = null;
            this.btnAddNewBooking.OnIdleState.IconRightImage = null;
            this.btnAddNewBooking.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.OnPressedState.BorderRadius = 35;
            this.btnAddNewBooking.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBooking.OnPressedState.BorderThickness = 1;
            this.btnAddNewBooking.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewBooking.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooking.OnPressedState.IconLeftImage = null;
            this.btnAddNewBooking.OnPressedState.IconRightImage = null;
            this.btnAddNewBooking.Size = new System.Drawing.Size(178, 48);
            this.btnAddNewBooking.TabIndex = 2;
            this.btnAddNewBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewBooking.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewBooking.TextMarginLeft = 0;
            this.btnAddNewBooking.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddNewBooking.UseDefaultRadiusAndThickness = true;
            this.btnAddNewBooking.Click += new System.EventHandler(this.btnAddNewBooking_Click);
            // 
            // frmListBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 766);
            this.Controls.Add(this.panel1);
            this.Name = "frmListBookings";
            this.Text = "frmListBookings";
            this.Load += new System.EventHandler(this.frmListBookings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAllBookings;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuTextBox txtBookingFilterValue;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewBooking;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}