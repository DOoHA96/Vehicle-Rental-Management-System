namespace Forms2
{
    partial class frmListCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListCustomers));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.btnAddNewCustomer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvAllCustomers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.Controls.Add(this.btnAddNewCustomer);
            this.pnlCustomerInfo.Controls.Add(this.label1);
            this.pnlCustomerInfo.Controls.Add(this.txtFilterValue);
            this.pnlCustomerInfo.Controls.Add(this.dgvAllCustomers);
            this.pnlCustomerInfo.Controls.Add(this.bunifuSeparator1);
            this.pnlCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(1324, 766);
            this.pnlCustomerInfo.TabIndex = 6;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.AllowAnimations = true;
            this.btnAddNewCustomer.AllowMouseEffects = true;
            this.btnAddNewCustomer.AllowToggling = false;
            this.btnAddNewCustomer.AnimationSpeed = 200;
            this.btnAddNewCustomer.AutoGenerateColors = false;
            this.btnAddNewCustomer.AutoRoundBorders = false;
            this.btnAddNewCustomer.AutoSizeLeftIcon = true;
            this.btnAddNewCustomer.AutoSizeRightIcon = true;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.BackgroundImage")));
            this.btnAddNewCustomer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewCustomer.ButtonText = "New";
            this.btnAddNewCustomer.ButtonTextMarginLeft = 0;
            this.btnAddNewCustomer.ColorContrastOnClick = 45;
            this.btnAddNewCustomer.ColorContrastOnHover = 45;
            this.btnAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddNewCustomer.CustomizableEdges = borderEdges2;
            this.btnAddNewCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewCustomer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewCustomer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewCustomer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewCustomer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.IconLeft = null;
            this.btnAddNewCustomer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewCustomer.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnAddNewCustomer.IconMarginLeft = 11;
            this.btnAddNewCustomer.IconPadding = 10;
            this.btnAddNewCustomer.IconRight = null;
            this.btnAddNewCustomer.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewCustomer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewCustomer.IconSize = 35;
            this.btnAddNewCustomer.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.IdleBorderRadius = 35;
            this.btnAddNewCustomer.IdleBorderThickness = 1;
            this.btnAddNewCustomer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.IdleIconLeftImage = null;
            this.btnAddNewCustomer.IdleIconRightImage = null;
            this.btnAddNewCustomer.IndicateFocus = false;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(1068, 120);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewCustomer.OnDisabledState.BorderRadius = 35;
            this.btnAddNewCustomer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewCustomer.OnDisabledState.BorderThickness = 1;
            this.btnAddNewCustomer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewCustomer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewCustomer.OnDisabledState.IconLeftImage = null;
            this.btnAddNewCustomer.OnDisabledState.IconRightImage = null;
            this.btnAddNewCustomer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.onHoverState.BorderRadius = 35;
            this.btnAddNewCustomer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewCustomer.onHoverState.BorderThickness = 1;
            this.btnAddNewCustomer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.onHoverState.IconLeftImage = null;
            this.btnAddNewCustomer.onHoverState.IconRightImage = null;
            this.btnAddNewCustomer.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.OnIdleState.BorderRadius = 35;
            this.btnAddNewCustomer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewCustomer.OnIdleState.BorderThickness = 1;
            this.btnAddNewCustomer.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.OnIdleState.IconLeftImage = null;
            this.btnAddNewCustomer.OnIdleState.IconRightImage = null;
            this.btnAddNewCustomer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.OnPressedState.BorderRadius = 35;
            this.btnAddNewCustomer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewCustomer.OnPressedState.BorderThickness = 1;
            this.btnAddNewCustomer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnAddNewCustomer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.OnPressedState.IconLeftImage = null;
            this.btnAddNewCustomer.OnPressedState.IconRightImage = null;
            this.btnAddNewCustomer.Size = new System.Drawing.Size(178, 48);
            this.btnAddNewCustomer.TabIndex = 8;
            this.btnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewCustomer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewCustomer.TextMarginLeft = 0;
            this.btnAddNewCustomer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddNewCustomer.UseDefaultRadiusAndThickness = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customers";
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
            this.txtFilterValue.Location = new System.Drawing.Point(39, 120);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.MaxLength = 32767;
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterValue.Modified = false;
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties8;
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterValue.PlaceholderText = "Full Name, License No.";
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
            this.txtFilterValue.TextPlaceholder = "Full Name, License No.";
            this.txtFilterValue.UseSystemPasswordChar = false;
            this.txtFilterValue.WordWrap = true;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dgvAllCustomers
            // 
            this.dgvAllCustomers.AllowCustomTheming = true;
            this.dgvAllCustomers.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllCustomers.ColumnHeadersHeight = 40;
            this.dgvAllCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.Edit,
            this.Delete});
            this.dgvAllCustomers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAllCustomers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllCustomers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllCustomers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAllCustomers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllCustomers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllCustomers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllCustomers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllCustomers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllCustomers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllCustomers.CurrentTheme.Name = null;
            this.dgvAllCustomers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllCustomers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllCustomers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllCustomers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllCustomers.EnableHeadersVisualStyles = false;
            this.dgvAllCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllCustomers.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.dgvAllCustomers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAllCustomers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllCustomers.Location = new System.Drawing.Point(51, 247);
            this.dgvAllCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllCustomers.Name = "dgvAllCustomers";
            this.dgvAllCustomers.ReadOnly = true;
            this.dgvAllCustomers.RowHeadersVisible = false;
            this.dgvAllCustomers.RowHeadersWidth = 51;
            this.dgvAllCustomers.RowTemplate.Height = 40;
            this.dgvAllCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCustomers.Size = new System.Drawing.Size(1247, 460);
            this.dgvAllCustomers.TabIndex = 5;
            this.dgvAllCustomers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvAllCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllCustomers_CellClick);
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
            this.bunifuSeparator1.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 58.36425F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Forms2.Properties.Resources.view;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 243;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 89.35146F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Forms2.Properties.Resources.pencil;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 371;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 152.2843F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Forms2.Properties.Resources.delete;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 633;
            // 
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 766);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Name = "frmListCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListCustomers";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerInfo;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAllCustomers;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewCustomer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
    }
}