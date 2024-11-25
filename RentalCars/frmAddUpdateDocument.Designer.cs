namespace Forms2
{
    partial class frmAddUpdateDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateDocument));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtDocumentPath = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBrowse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(35, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Document Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "Document Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(85, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 41);
            this.label1.TabIndex = 26;
            this.label1.Text = "Document Details";
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.AcceptsReturn = false;
            this.txtDocumentName.AcceptsTab = false;
            this.txtDocumentName.AnimationSpeed = 200;
            this.txtDocumentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDocumentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDocumentName.AutoSizeHeight = true;
            this.txtDocumentName.BackColor = System.Drawing.Color.Transparent;
            this.txtDocumentName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDocumentName.BackgroundImage")));
            this.txtDocumentName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDocumentName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDocumentName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDocumentName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDocumentName.BorderRadius = 35;
            this.txtDocumentName.BorderThickness = 1;
            this.txtDocumentName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtDocumentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocumentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentName.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentName.DefaultText = "";
            this.txtDocumentName.FillColor = System.Drawing.Color.White;
            this.txtDocumentName.HideSelection = true;
            this.txtDocumentName.IconLeft = null;
            this.txtDocumentName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentName.IconPadding = 10;
            this.txtDocumentName.IconRight = null;
            this.txtDocumentName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentName.Lines = new string[0];
            this.txtDocumentName.Location = new System.Drawing.Point(20, 307);
            this.txtDocumentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentName.MaxLength = 32767;
            this.txtDocumentName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDocumentName.Modified = false;
            this.txtDocumentName.Multiline = false;
            this.txtDocumentName.Name = "txtDocumentName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDocumentName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDocumentName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDocumentName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDocumentName.OnIdleState = stateProperties4;
            this.txtDocumentName.Padding = new System.Windows.Forms.Padding(4);
            this.txtDocumentName.PasswordChar = '\0';
            this.txtDocumentName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDocumentName.PlaceholderText = "";
            this.txtDocumentName.ReadOnly = false;
            this.txtDocumentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumentName.SelectedText = "";
            this.txtDocumentName.SelectionLength = 0;
            this.txtDocumentName.SelectionStart = 0;
            this.txtDocumentName.ShortcutsEnabled = true;
            this.txtDocumentName.Size = new System.Drawing.Size(379, 49);
            this.txtDocumentName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDocumentName.TabIndex = 33;
            this.txtDocumentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumentName.TextMarginBottom = 0;
            this.txtDocumentName.TextMarginLeft = 3;
            this.txtDocumentName.TextMarginTop = 0;
            this.txtDocumentName.TextPlaceholder = "";
            this.txtDocumentName.UseSystemPasswordChar = false;
            this.txtDocumentName.WordWrap = true;
            this.txtDocumentName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocumentName_Validating);
            // 
            // txtDocumentPath
            // 
            this.txtDocumentPath.AcceptsReturn = false;
            this.txtDocumentPath.AcceptsTab = false;
            this.txtDocumentPath.AnimationSpeed = 200;
            this.txtDocumentPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDocumentPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDocumentPath.AutoSizeHeight = true;
            this.txtDocumentPath.BackColor = System.Drawing.Color.Transparent;
            this.txtDocumentPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDocumentPath.BackgroundImage")));
            this.txtDocumentPath.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDocumentPath.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDocumentPath.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDocumentPath.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDocumentPath.BorderRadius = 35;
            this.txtDocumentPath.BorderThickness = 1;
            this.txtDocumentPath.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtDocumentPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocumentPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentPath.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentPath.DefaultText = "";
            this.txtDocumentPath.FillColor = System.Drawing.Color.White;
            this.txtDocumentPath.HideSelection = true;
            this.txtDocumentPath.IconLeft = null;
            this.txtDocumentPath.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentPath.IconPadding = 10;
            this.txtDocumentPath.IconRight = null;
            this.txtDocumentPath.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumentPath.Lines = new string[0];
            this.txtDocumentPath.Location = new System.Drawing.Point(20, 193);
            this.txtDocumentPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentPath.MaxLength = 32767;
            this.txtDocumentPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDocumentPath.Modified = false;
            this.txtDocumentPath.Multiline = false;
            this.txtDocumentPath.Name = "txtDocumentPath";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDocumentPath.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDocumentPath.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDocumentPath.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDocumentPath.OnIdleState = stateProperties8;
            this.txtDocumentPath.Padding = new System.Windows.Forms.Padding(4);
            this.txtDocumentPath.PasswordChar = '\0';
            this.txtDocumentPath.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDocumentPath.PlaceholderText = "";
            this.txtDocumentPath.ReadOnly = false;
            this.txtDocumentPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumentPath.SelectedText = "";
            this.txtDocumentPath.SelectionLength = 0;
            this.txtDocumentPath.SelectionStart = 0;
            this.txtDocumentPath.ShortcutsEnabled = true;
            this.txtDocumentPath.Size = new System.Drawing.Size(723, 49);
            this.txtDocumentPath.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDocumentPath.TabIndex = 29;
            this.txtDocumentPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumentPath.TextMarginBottom = 0;
            this.txtDocumentPath.TextMarginLeft = 3;
            this.txtDocumentPath.TextMarginTop = 0;
            this.txtDocumentPath.TextPlaceholder = "";
            this.txtDocumentPath.UseSystemPasswordChar = false;
            this.txtDocumentPath.WordWrap = true;
            this.txtDocumentPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocumentPath_Validating);
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
            this.bunifuSeparator2.Location = new System.Drawing.Point(20, 105);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(880, 18);
            this.bunifuSeparator2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms2.Properties.Resources.google_docs;
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeft = null;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRight = null;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 35;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnSave.IdleBorderRadius = 35;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(768, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 35;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.onHoverState.BorderRadius = 35;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnSave.OnIdleState.BorderRadius = 35;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.OnPressedState.BorderRadius = 35;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(144, 42);
            this.btnSave.TabIndex = 30;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AllowAnimations = true;
            this.btnBrowse.AllowMouseEffects = true;
            this.btnBrowse.AllowToggling = false;
            this.btnBrowse.AnimationSpeed = 200;
            this.btnBrowse.AutoGenerateColors = false;
            this.btnBrowse.AutoRoundBorders = false;
            this.btnBrowse.AutoSizeLeftIcon = true;
            this.btnBrowse.AutoSizeRightIcon = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.ButtonTextMarginLeft = 0;
            this.btnBrowse.ColorContrastOnClick = 45;
            this.btnBrowse.ColorContrastOnHover = 45;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnBrowse.CustomizableEdges = borderEdges2;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBrowse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBrowse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBrowse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.IconLeft = null;
            this.btnBrowse.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnBrowse.IconMarginLeft = 11;
            this.btnBrowse.IconPadding = 10;
            this.btnBrowse.IconRight = null;
            this.btnBrowse.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBrowse.IconSize = 35;
            this.btnBrowse.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnBrowse.IdleBorderRadius = 35;
            this.btnBrowse.IdleBorderThickness = 1;
            this.btnBrowse.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.IdleIconLeftImage = null;
            this.btnBrowse.IdleIconRightImage = null;
            this.btnBrowse.IndicateFocus = false;
            this.btnBrowse.Location = new System.Drawing.Point(756, 193);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBrowse.OnDisabledState.BorderRadius = 35;
            this.btnBrowse.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnDisabledState.BorderThickness = 1;
            this.btnBrowse.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBrowse.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBrowse.OnDisabledState.IconLeftImage = null;
            this.btnBrowse.OnDisabledState.IconRightImage = null;
            this.btnBrowse.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.onHoverState.BorderRadius = 35;
            this.btnBrowse.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.onHoverState.BorderThickness = 1;
            this.btnBrowse.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.onHoverState.IconLeftImage = null;
            this.btnBrowse.onHoverState.IconRightImage = null;
            this.btnBrowse.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(202)))));
            this.btnBrowse.OnIdleState.BorderRadius = 35;
            this.btnBrowse.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnIdleState.BorderThickness = 1;
            this.btnBrowse.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnIdleState.IconLeftImage = null;
            this.btnBrowse.OnIdleState.IconRightImage = null;
            this.btnBrowse.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.OnPressedState.BorderRadius = 35;
            this.btnBrowse.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnPressedState.BorderThickness = 1;
            this.btnBrowse.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.btnBrowse.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnPressedState.IconLeftImage = null;
            this.btnBrowse.OnPressedState.IconRightImage = null;
            this.btnBrowse.Size = new System.Drawing.Size(144, 49);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.TextMarginLeft = 0;
            this.btnBrowse.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBrowse.UseDefaultRadiusAndThickness = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 447);
            this.Controls.Add(this.txtDocumentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDocumentPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAddUpdateDocument";
            this.Text = "frmAddUpdateDocument";
            this.Load += new System.EventHandler(this.frmAddUpdateDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtDocumentName;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txtDocumentPath;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}