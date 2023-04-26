namespace Telecom_Tools
{
    partial class FormTelecomTools
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelecomTools));
            this.TelecomToolsTabControl = new System.Windows.Forms.TabControl();
            this.QRGeneratorTabPage = new System.Windows.Forms.TabPage();
            this.EFDataGenTabPage = new System.Windows.Forms.TabPage();
            this.PNNCopyButton = new System.Windows.Forms.Button();
            this.PNNTextBox = new System.Windows.Forms.TextBox();
            this.PNNPathLabel = new System.Windows.Forms.Label();
            this.SPNTabControl = new System.Windows.Forms.TabControl();
            this.SPNDataTabPage = new System.Windows.Forms.TabPage();
            this.SPNTextBox = new System.Windows.Forms.TextBox();
            this.SPNCopyButton = new System.Windows.Forms.Button();
            this.SPNSettingsTabPage = new System.Windows.Forms.TabPage();
            this.SPNamePLMNRequiredComboBox = new System.Windows.Forms.ComboBox();
            this.SPNRequiredLabel = new System.Windows.Forms.Label();
            this.SPNRegisteredPLMNRequiredComboBox = new System.Windows.Forms.ComboBox();
            this.SPNRegRequiredLabel = new System.Windows.Forms.Label();
            this.SPNPathLabel = new System.Windows.Forms.Label();
            this.MenuTitleTabControl = new System.Windows.Forms.TabControl();
            this.MenuTitleDataTabPage = new System.Windows.Forms.TabPage();
            this.MenuTitleTextBox = new System.Windows.Forms.TextBox();
            this.MenuTitleCopyButton = new System.Windows.Forms.Button();
            this.MenuTitleSettingsTabPage = new System.Windows.Forms.TabPage();
            this.MenuTitleEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.MenuTitleEncodingLabel = new System.Windows.Forms.Label();
            this.MenuTitlePathLabel = new System.Windows.Forms.Label();
            this.characterLimitLabel = new System.Windows.Forms.Label();
            this.efGenOpenFileButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.SUMEPathLabel = new System.Windows.Forms.Label();
            this.SUMETabControl = new System.Windows.Forms.TabControl();
            this.SUMEDataTabPage = new System.Windows.Forms.TabPage();
            this.SUMETextBox = new System.Windows.Forms.TextBox();
            this.SUMECopyButton = new System.Windows.Forms.Button();
            this.SUMESettingsTabPage = new System.Windows.Forms.TabPage();
            this.SUMEIconNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SUMEIconLabel = new System.Windows.Forms.Label();
            this.SUMEIconQualifierComboBox = new System.Windows.Forms.ComboBox();
            this.SUMEIconQualifierLabel = new System.Windows.Forms.Label();
            this.efGenOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TelecomToolsTabControl.SuspendLayout();
            this.EFDataGenTabPage.SuspendLayout();
            this.SPNTabControl.SuspendLayout();
            this.SPNDataTabPage.SuspendLayout();
            this.SPNSettingsTabPage.SuspendLayout();
            this.MenuTitleTabControl.SuspendLayout();
            this.MenuTitleDataTabPage.SuspendLayout();
            this.MenuTitleSettingsTabPage.SuspendLayout();
            this.SUMETabControl.SuspendLayout();
            this.SUMEDataTabPage.SuspendLayout();
            this.SUMESettingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SUMEIconNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TelecomToolsTabControl
            // 
            this.TelecomToolsTabControl.Controls.Add(this.QRGeneratorTabPage);
            this.TelecomToolsTabControl.Controls.Add(this.EFDataGenTabPage);
            this.TelecomToolsTabControl.Location = new System.Drawing.Point(3, 2);
            this.TelecomToolsTabControl.Name = "TelecomToolsTabControl";
            this.TelecomToolsTabControl.SelectedIndex = 0;
            this.TelecomToolsTabControl.Size = new System.Drawing.Size(439, 675);
            this.TelecomToolsTabControl.TabIndex = 0;
            // 
            // QRGeneratorTabPage
            // 
            this.QRGeneratorTabPage.Location = new System.Drawing.Point(4, 34);
            this.QRGeneratorTabPage.Name = "QRGeneratorTabPage";
            this.QRGeneratorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.QRGeneratorTabPage.Size = new System.Drawing.Size(431, 637);
            this.QRGeneratorTabPage.TabIndex = 0;
            this.QRGeneratorTabPage.Text = "QR Gen";
            this.QRGeneratorTabPage.UseVisualStyleBackColor = true;
            // 
            // EFDataGenTabPage
            // 
            this.EFDataGenTabPage.Controls.Add(this.PNNCopyButton);
            this.EFDataGenTabPage.Controls.Add(this.PNNTextBox);
            this.EFDataGenTabPage.Controls.Add(this.PNNPathLabel);
            this.EFDataGenTabPage.Controls.Add(this.SPNTabControl);
            this.EFDataGenTabPage.Controls.Add(this.SPNPathLabel);
            this.EFDataGenTabPage.Controls.Add(this.MenuTitleTabControl);
            this.EFDataGenTabPage.Controls.Add(this.MenuTitlePathLabel);
            this.EFDataGenTabPage.Controls.Add(this.characterLimitLabel);
            this.EFDataGenTabPage.Controls.Add(this.efGenOpenFileButton);
            this.EFDataGenTabPage.Controls.Add(this.inputTextBox);
            this.EFDataGenTabPage.Controls.Add(this.inputLabel);
            this.EFDataGenTabPage.Controls.Add(this.SUMEPathLabel);
            this.EFDataGenTabPage.Controls.Add(this.SUMETabControl);
            this.EFDataGenTabPage.Location = new System.Drawing.Point(4, 34);
            this.EFDataGenTabPage.Name = "EFDataGenTabPage";
            this.EFDataGenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EFDataGenTabPage.Size = new System.Drawing.Size(431, 637);
            this.EFDataGenTabPage.TabIndex = 1;
            this.EFDataGenTabPage.Text = "EF Gen";
            this.EFDataGenTabPage.UseVisualStyleBackColor = true;
            // 
            // PNNCopyButton
            // 
            this.PNNCopyButton.AccessibleDescription = "Copy content in the PNN field.";
            this.PNNCopyButton.AccessibleName = "Copy PNN to clipboard";
            this.PNNCopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNNCopyButton.BackgroundImage")));
            this.PNNCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNNCopyButton.Enabled = false;
            this.PNNCopyButton.Location = new System.Drawing.Point(384, 553);
            this.PNNCopyButton.Name = "PNNCopyButton";
            this.PNNCopyButton.Size = new System.Drawing.Size(31, 31);
            this.PNNCopyButton.TabIndex = 29;
            this.PNNCopyButton.Tag = "";
            this.PNNCopyButton.UseVisualStyleBackColor = true;
            this.PNNCopyButton.Click += new System.EventHandler(this.PNNCopyButton_Click);
            // 
            // PNNTextBox
            // 
            this.PNNTextBox.AccessibleDescription = "PNN field content";
            this.PNNTextBox.AccessibleName = "PNN";
            this.PNNTextBox.Location = new System.Drawing.Point(16, 553);
            this.PNNTextBox.MaxLength = 100;
            this.PNNTextBox.Multiline = true;
            this.PNNTextBox.Name = "PNNTextBox";
            this.PNNTextBox.ReadOnly = true;
            this.PNNTextBox.Size = new System.Drawing.Size(362, 62);
            this.PNNTextBox.TabIndex = 28;
            this.PNNTextBox.TextChanged += new System.EventHandler(this.PNNTextBox_TextChanged);
            // 
            // PNNPathLabel
            // 
            this.PNNPathLabel.AutoSize = true;
            this.PNNPathLabel.Location = new System.Drawing.Point(10, 525);
            this.PNNPathLabel.Name = "PNNPathLabel";
            this.PNNPathLabel.Size = new System.Drawing.Size(198, 25);
            this.PNNPathLabel.TabIndex = 27;
            this.PNNPathLabel.Text = "3F00/7F20/6FC5 | PNN:";
            // 
            // SPNTabControl
            // 
            this.SPNTabControl.Controls.Add(this.SPNDataTabPage);
            this.SPNTabControl.Controls.Add(this.SPNSettingsTabPage);
            this.SPNTabControl.Location = new System.Drawing.Point(6, 411);
            this.SPNTabControl.Name = "SPNTabControl";
            this.SPNTabControl.SelectedIndex = 0;
            this.SPNTabControl.Size = new System.Drawing.Size(419, 111);
            this.SPNTabControl.TabIndex = 26;
            // 
            // SPNDataTabPage
            // 
            this.SPNDataTabPage.Controls.Add(this.SPNTextBox);
            this.SPNDataTabPage.Controls.Add(this.SPNCopyButton);
            this.SPNDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.SPNDataTabPage.Name = "SPNDataTabPage";
            this.SPNDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SPNDataTabPage.Size = new System.Drawing.Size(411, 73);
            this.SPNDataTabPage.TabIndex = 0;
            this.SPNDataTabPage.Text = "Data";
            this.SPNDataTabPage.UseVisualStyleBackColor = true;
            // 
            // SPNTextBox
            // 
            this.SPNTextBox.AccessibleDescription = "SPN field content";
            this.SPNTextBox.Location = new System.Drawing.Point(6, 6);
            this.SPNTextBox.MaxLength = 100;
            this.SPNTextBox.Multiline = true;
            this.SPNTextBox.Name = "SPNTextBox";
            this.SPNTextBox.ReadOnly = true;
            this.SPNTextBox.Size = new System.Drawing.Size(362, 62);
            this.SPNTextBox.TabIndex = 11;
            this.SPNTextBox.TextChanged += new System.EventHandler(this.SPNTextBox_TextChanged);
            // 
            // SPNCopyButton
            // 
            this.SPNCopyButton.AccessibleDescription = "Copy content in the SPN field.";
            this.SPNCopyButton.AccessibleName = "Copy SPN to clipboard";
            this.SPNCopyButton.BackgroundImage = global::Telecom_Tools.Properties.Resources.Copy;
            this.SPNCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SPNCopyButton.Enabled = false;
            this.SPNCopyButton.Location = new System.Drawing.Point(374, 6);
            this.SPNCopyButton.Name = "SPNCopyButton";
            this.SPNCopyButton.Size = new System.Drawing.Size(31, 31);
            this.SPNCopyButton.TabIndex = 12;
            this.SPNCopyButton.Tag = "";
            this.SPNCopyButton.UseVisualStyleBackColor = true;
            this.SPNCopyButton.Click += new System.EventHandler(this.SPNCopyButton_Click);
            // 
            // SPNSettingsTabPage
            // 
            this.SPNSettingsTabPage.Controls.Add(this.SPNamePLMNRequiredComboBox);
            this.SPNSettingsTabPage.Controls.Add(this.SPNRequiredLabel);
            this.SPNSettingsTabPage.Controls.Add(this.SPNRegisteredPLMNRequiredComboBox);
            this.SPNSettingsTabPage.Controls.Add(this.SPNRegRequiredLabel);
            this.SPNSettingsTabPage.Location = new System.Drawing.Point(4, 34);
            this.SPNSettingsTabPage.Name = "SPNSettingsTabPage";
            this.SPNSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SPNSettingsTabPage.Size = new System.Drawing.Size(411, 73);
            this.SPNSettingsTabPage.TabIndex = 1;
            this.SPNSettingsTabPage.Text = "Display Settings";
            this.SPNSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // SPNamePLMNRequiredComboBox
            // 
            this.SPNamePLMNRequiredComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPNamePLMNRequiredComboBox.FormattingEnabled = true;
            this.SPNamePLMNRequiredComboBox.Items.AddRange(new object[] {
            "True",
            "False",
            "Nothing selected"});
            this.SPNamePLMNRequiredComboBox.Location = new System.Drawing.Point(333, 37);
            this.SPNamePLMNRequiredComboBox.Name = "SPNamePLMNRequiredComboBox";
            this.SPNamePLMNRequiredComboBox.Size = new System.Drawing.Size(72, 33);
            this.SPNamePLMNRequiredComboBox.TabIndex = 7;
            this.SPNamePLMNRequiredComboBox.SelectedIndexChanged += new System.EventHandler(this.SPNamePLMNRequiredComboBox_SelectedIndexChanged);
            // 
            // SPNRequiredLabel
            // 
            this.SPNRequiredLabel.AutoSize = true;
            this.SPNRequiredLabel.Location = new System.Drawing.Point(15, 42);
            this.SPNRequiredLabel.Name = "SPNRequiredLabel";
            this.SPNRequiredLabel.Size = new System.Drawing.Size(315, 25);
            this.SPNRequiredLabel.TabIndex = 6;
            this.SPNRequiredLabel.Text = "Service provider name PLMN required:";
            // 
            // SPNRegisteredPLMNRequiredComboBox
            // 
            this.SPNRegisteredPLMNRequiredComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPNRegisteredPLMNRequiredComboBox.FormattingEnabled = true;
            this.SPNRegisteredPLMNRequiredComboBox.Items.AddRange(new object[] {
            "True",
            "False",
            "Nothing selected"});
            this.SPNRegisteredPLMNRequiredComboBox.Location = new System.Drawing.Point(333, 3);
            this.SPNRegisteredPLMNRequiredComboBox.Name = "SPNRegisteredPLMNRequiredComboBox";
            this.SPNRegisteredPLMNRequiredComboBox.Size = new System.Drawing.Size(72, 33);
            this.SPNRegisteredPLMNRequiredComboBox.TabIndex = 5;
            this.SPNRegisteredPLMNRequiredComboBox.SelectedIndexChanged += new System.EventHandler(this.SPNRegisteredPLMNRequiredComboBox_SelectedIndexChanged);
            // 
            // SPNRegRequiredLabel
            // 
            this.SPNRegRequiredLabel.AutoSize = true;
            this.SPNRegRequiredLabel.Location = new System.Drawing.Point(108, 6);
            this.SPNRegRequiredLabel.Name = "SPNRegRequiredLabel";
            this.SPNRegRequiredLabel.Size = new System.Drawing.Size(222, 25);
            this.SPNRegRequiredLabel.TabIndex = 4;
            this.SPNRegRequiredLabel.Text = "Registered PLMN required:";
            // 
            // SPNPathLabel
            // 
            this.SPNPathLabel.AutoSize = true;
            this.SPNPathLabel.Location = new System.Drawing.Point(6, 383);
            this.SPNPathLabel.Name = "SPNPathLabel";
            this.SPNPathLabel.Size = new System.Drawing.Size(194, 25);
            this.SPNPathLabel.TabIndex = 25;
            this.SPNPathLabel.Text = "3F00/7F20/6F46 | SPN:";
            // 
            // MenuTitleTabControl
            // 
            this.MenuTitleTabControl.Controls.Add(this.MenuTitleDataTabPage);
            this.MenuTitleTabControl.Controls.Add(this.MenuTitleSettingsTabPage);
            this.MenuTitleTabControl.Location = new System.Drawing.Point(6, 269);
            this.MenuTitleTabControl.Name = "MenuTitleTabControl";
            this.MenuTitleTabControl.SelectedIndex = 0;
            this.MenuTitleTabControl.Size = new System.Drawing.Size(419, 111);
            this.MenuTitleTabControl.TabIndex = 23;
            // 
            // MenuTitleDataTabPage
            // 
            this.MenuTitleDataTabPage.Controls.Add(this.MenuTitleTextBox);
            this.MenuTitleDataTabPage.Controls.Add(this.MenuTitleCopyButton);
            this.MenuTitleDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.MenuTitleDataTabPage.Name = "MenuTitleDataTabPage";
            this.MenuTitleDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MenuTitleDataTabPage.Size = new System.Drawing.Size(411, 73);
            this.MenuTitleDataTabPage.TabIndex = 0;
            this.MenuTitleDataTabPage.Text = "Data";
            this.MenuTitleDataTabPage.UseVisualStyleBackColor = true;
            // 
            // MenuTitleTextBox
            // 
            this.MenuTitleTextBox.AccessibleDescription = "Menu Title field content";
            this.MenuTitleTextBox.AccessibleName = "Menu Title";
            this.MenuTitleTextBox.Location = new System.Drawing.Point(6, 6);
            this.MenuTitleTextBox.MaxLength = 100;
            this.MenuTitleTextBox.Multiline = true;
            this.MenuTitleTextBox.Name = "MenuTitleTextBox";
            this.MenuTitleTextBox.ReadOnly = true;
            this.MenuTitleTextBox.Size = new System.Drawing.Size(362, 62);
            this.MenuTitleTextBox.TabIndex = 8;
            this.MenuTitleTextBox.TextChanged += new System.EventHandler(this.MenuTitleTextBox_TextChanged);
            // 
            // MenuTitleCopyButton
            // 
            this.MenuTitleCopyButton.AccessibleDescription = "Copy content in the Menu Title field.";
            this.MenuTitleCopyButton.AccessibleName = "Copy Menu Title to clipboard";
            this.MenuTitleCopyButton.BackgroundImage = global::Telecom_Tools.Properties.Resources.Copy;
            this.MenuTitleCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuTitleCopyButton.Enabled = false;
            this.MenuTitleCopyButton.Location = new System.Drawing.Point(374, 3);
            this.MenuTitleCopyButton.Name = "MenuTitleCopyButton";
            this.MenuTitleCopyButton.Size = new System.Drawing.Size(31, 31);
            this.MenuTitleCopyButton.TabIndex = 9;
            this.MenuTitleCopyButton.Tag = "";
            this.MenuTitleCopyButton.UseVisualStyleBackColor = true;
            this.MenuTitleCopyButton.Click += new System.EventHandler(this.MenuTitleCopyButton_Click);
            // 
            // MenuTitleSettingsTabPage
            // 
            this.MenuTitleSettingsTabPage.Controls.Add(this.MenuTitleEncodingComboBox);
            this.MenuTitleSettingsTabPage.Controls.Add(this.MenuTitleEncodingLabel);
            this.MenuTitleSettingsTabPage.Location = new System.Drawing.Point(4, 34);
            this.MenuTitleSettingsTabPage.Name = "MenuTitleSettingsTabPage";
            this.MenuTitleSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MenuTitleSettingsTabPage.Size = new System.Drawing.Size(411, 73);
            this.MenuTitleSettingsTabPage.TabIndex = 1;
            this.MenuTitleSettingsTabPage.Text = "Encoding Settings";
            this.MenuTitleSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // MenuTitleEncodingComboBox
            // 
            this.MenuTitleEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuTitleEncodingComboBox.FormattingEnabled = true;
            this.MenuTitleEncodingComboBox.Items.AddRange(new object[] {
            "GSM 03.38 Default",
            "GSM 11.11/1",
            "GSM 11.11/2",
            "GSM 11.11/3"});
            this.MenuTitleEncodingComboBox.Location = new System.Drawing.Point(129, 20);
            this.MenuTitleEncodingComboBox.Name = "MenuTitleEncodingComboBox";
            this.MenuTitleEncodingComboBox.Size = new System.Drawing.Size(251, 33);
            this.MenuTitleEncodingComboBox.TabIndex = 3;
            this.MenuTitleEncodingComboBox.SelectedIndexChanged += new System.EventHandler(this.MenuTitleEncodingComboBox_SelectedIndexChanged);
            // 
            // MenuTitleEncodingLabel
            // 
            this.MenuTitleEncodingLabel.AutoSize = true;
            this.MenuTitleEncodingLabel.Location = new System.Drawing.Point(36, 23);
            this.MenuTitleEncodingLabel.Name = "MenuTitleEncodingLabel";
            this.MenuTitleEncodingLabel.Size = new System.Drawing.Size(90, 25);
            this.MenuTitleEncodingLabel.TabIndex = 2;
            this.MenuTitleEncodingLabel.Text = "Encoding:";
            // 
            // MenuTitlePathLabel
            // 
            this.MenuTitlePathLabel.AutoSize = true;
            this.MenuTitlePathLabel.Location = new System.Drawing.Point(6, 241);
            this.MenuTitlePathLabel.Name = "MenuTitlePathLabel";
            this.MenuTitlePathLabel.Size = new System.Drawing.Size(243, 25);
            this.MenuTitlePathLabel.TabIndex = 24;
            this.MenuTitlePathLabel.Text = "3F00/2700/6F1E | Menu Title:";
            // 
            // characterLimitLabel
            // 
            this.characterLimitLabel.AutoSize = true;
            this.characterLimitLabel.Location = new System.Drawing.Point(10, 65);
            this.characterLimitLabel.Name = "characterLimitLabel";
            this.characterLimitLabel.Size = new System.Drawing.Size(158, 25);
            this.characterLimitLabel.TabIndex = 22;
            this.characterLimitLabel.Text = "Character Limit: 16";
            // 
            // efGenOpenFileButton
            // 
            this.efGenOpenFileButton.AccessibleDescription = "Open a file to get the customer info";
            this.efGenOpenFileButton.AccessibleName = "Open File Button";
            this.efGenOpenFileButton.BackgroundImage = global::Telecom_Tools.Properties.Resources.Open_File;
            this.efGenOpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.efGenOpenFileButton.Location = new System.Drawing.Point(384, 31);
            this.efGenOpenFileButton.Name = "efGenOpenFileButton";
            this.efGenOpenFileButton.Size = new System.Drawing.Size(31, 31);
            this.efGenOpenFileButton.TabIndex = 21;
            this.efGenOpenFileButton.Tag = "";
            this.efGenOpenFileButton.UseVisualStyleBackColor = true;
            this.efGenOpenFileButton.Click += new System.EventHandler(this.efGenOpenFileButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(10, 31);
            this.inputTextBox.MaxLength = 16;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(368, 31);
            this.inputTextBox.TabIndex = 20;
            this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(10, 3);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(58, 25);
            this.inputLabel.TabIndex = 19;
            this.inputLabel.Text = "Input:";
            // 
            // SUMEPathLabel
            // 
            this.SUMEPathLabel.AutoSize = true;
            this.SUMEPathLabel.Location = new System.Drawing.Point(6, 99);
            this.SUMEPathLabel.Name = "SUMEPathLabel";
            this.SUMEPathLabel.Size = new System.Drawing.Size(208, 25);
            this.SUMEPathLabel.TabIndex = 18;
            this.SUMEPathLabel.Text = "3F00/7F10/6F54 | SUME:";
            // 
            // SUMETabControl
            // 
            this.SUMETabControl.Controls.Add(this.SUMEDataTabPage);
            this.SUMETabControl.Controls.Add(this.SUMESettingsTabPage);
            this.SUMETabControl.Location = new System.Drawing.Point(6, 127);
            this.SUMETabControl.Name = "SUMETabControl";
            this.SUMETabControl.SelectedIndex = 0;
            this.SUMETabControl.Size = new System.Drawing.Size(419, 111);
            this.SUMETabControl.TabIndex = 17;
            // 
            // SUMEDataTabPage
            // 
            this.SUMEDataTabPage.Controls.Add(this.SUMETextBox);
            this.SUMEDataTabPage.Controls.Add(this.SUMECopyButton);
            this.SUMEDataTabPage.Location = new System.Drawing.Point(4, 34);
            this.SUMEDataTabPage.Name = "SUMEDataTabPage";
            this.SUMEDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SUMEDataTabPage.Size = new System.Drawing.Size(411, 73);
            this.SUMEDataTabPage.TabIndex = 0;
            this.SUMEDataTabPage.Text = "Data";
            this.SUMEDataTabPage.UseVisualStyleBackColor = true;
            // 
            // SUMETextBox
            // 
            this.SUMETextBox.AccessibleDescription = "SUME Elementary File Content";
            this.SUMETextBox.AccessibleName = "SUME Text Box";
            this.SUMETextBox.Location = new System.Drawing.Point(6, 6);
            this.SUMETextBox.MaxLength = 100;
            this.SUMETextBox.Multiline = true;
            this.SUMETextBox.Name = "SUMETextBox";
            this.SUMETextBox.ReadOnly = true;
            this.SUMETextBox.Size = new System.Drawing.Size(362, 62);
            this.SUMETextBox.TabIndex = 5;
            this.SUMETextBox.TextChanged += new System.EventHandler(this.SUMETextBox_TextChanged);
            // 
            // SUMECopyButton
            // 
            this.SUMECopyButton.AccessibleDescription = "Copy content in the SUME field.";
            this.SUMECopyButton.AccessibleName = "SUME Copy Button";
            this.SUMECopyButton.BackgroundImage = global::Telecom_Tools.Properties.Resources.Copy;
            this.SUMECopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SUMECopyButton.Enabled = false;
            this.SUMECopyButton.Location = new System.Drawing.Point(374, 6);
            this.SUMECopyButton.Name = "SUMECopyButton";
            this.SUMECopyButton.Size = new System.Drawing.Size(31, 31);
            this.SUMECopyButton.TabIndex = 6;
            this.SUMECopyButton.Tag = "";
            this.SUMECopyButton.UseVisualStyleBackColor = true;
            this.SUMECopyButton.Click += new System.EventHandler(this.SUMECopyButton_Click);
            // 
            // SUMESettingsTabPage
            // 
            this.SUMESettingsTabPage.Controls.Add(this.SUMEIconNumericUpDown);
            this.SUMESettingsTabPage.Controls.Add(this.SUMEIconLabel);
            this.SUMESettingsTabPage.Controls.Add(this.SUMEIconQualifierComboBox);
            this.SUMESettingsTabPage.Controls.Add(this.SUMEIconQualifierLabel);
            this.SUMESettingsTabPage.Location = new System.Drawing.Point(4, 34);
            this.SUMESettingsTabPage.Name = "SUMESettingsTabPage";
            this.SUMESettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SUMESettingsTabPage.Size = new System.Drawing.Size(411, 73);
            this.SUMESettingsTabPage.TabIndex = 1;
            this.SUMESettingsTabPage.Text = "Icon Settings";
            this.SUMESettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // SUMEIconNumericUpDown
            // 
            this.SUMEIconNumericUpDown.Location = new System.Drawing.Point(133, 39);
            this.SUMEIconNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SUMEIconNumericUpDown.Name = "SUMEIconNumericUpDown";
            this.SUMEIconNumericUpDown.Size = new System.Drawing.Size(251, 31);
            this.SUMEIconNumericUpDown.TabIndex = 3;
            this.SUMEIconNumericUpDown.ValueChanged += new System.EventHandler(this.SUMEIconNumericUpDown_ValueChanged);
            // 
            // SUMEIconLabel
            // 
            this.SUMEIconLabel.AutoSize = true;
            this.SUMEIconLabel.Location = new System.Drawing.Point(6, 41);
            this.SUMEIconLabel.Name = "SUMEIconLabel";
            this.SUMEIconLabel.Size = new System.Drawing.Size(125, 25);
            this.SUMEIconLabel.TabIndex = 2;
            this.SUMEIconLabel.Text = "Icon Identifier:";
            // 
            // SUMEIconQualifierComboBox
            // 
            this.SUMEIconQualifierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUMEIconQualifierComboBox.FormattingEnabled = true;
            this.SUMEIconQualifierComboBox.Items.AddRange(new object[] {
            "Self-explanatory",
            "Not self-explanatory",
            "Not present"});
            this.SUMEIconQualifierComboBox.Location = new System.Drawing.Point(133, 3);
            this.SUMEIconQualifierComboBox.Name = "SUMEIconQualifierComboBox";
            this.SUMEIconQualifierComboBox.Size = new System.Drawing.Size(251, 33);
            this.SUMEIconQualifierComboBox.TabIndex = 1;
            this.SUMEIconQualifierComboBox.SelectedIndexChanged += new System.EventHandler(this.SUMEIconQualifierComboBox_SelectedIndexChanged);
            // 
            // SUMEIconQualifierLabel
            // 
            this.SUMEIconQualifierLabel.AutoSize = true;
            this.SUMEIconQualifierLabel.Location = new System.Drawing.Point(9, 6);
            this.SUMEIconQualifierLabel.Name = "SUMEIconQualifierLabel";
            this.SUMEIconQualifierLabel.Size = new System.Drawing.Size(121, 25);
            this.SUMEIconQualifierLabel.TabIndex = 0;
            this.SUMEIconQualifierLabel.Text = "Icon Qualifier:";
            // 
            // efGenOpenFileDialog
            // 
            this.efGenOpenFileDialog.Filter = "Input Files (INP)|*.INP";
            // 
            // FormTelecomTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 675);
            this.Controls.Add(this.TelecomToolsTabControl);
            this.Name = "FormTelecomTools";
            this.Text = "Telecom Tools";
            this.TelecomToolsTabControl.ResumeLayout(false);
            this.EFDataGenTabPage.ResumeLayout(false);
            this.EFDataGenTabPage.PerformLayout();
            this.SPNTabControl.ResumeLayout(false);
            this.SPNDataTabPage.ResumeLayout(false);
            this.SPNDataTabPage.PerformLayout();
            this.SPNSettingsTabPage.ResumeLayout(false);
            this.SPNSettingsTabPage.PerformLayout();
            this.MenuTitleTabControl.ResumeLayout(false);
            this.MenuTitleDataTabPage.ResumeLayout(false);
            this.MenuTitleDataTabPage.PerformLayout();
            this.MenuTitleSettingsTabPage.ResumeLayout(false);
            this.MenuTitleSettingsTabPage.PerformLayout();
            this.SUMETabControl.ResumeLayout(false);
            this.SUMEDataTabPage.ResumeLayout(false);
            this.SUMEDataTabPage.PerformLayout();
            this.SUMESettingsTabPage.ResumeLayout(false);
            this.SUMESettingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SUMEIconNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TelecomToolsTabControl;
        private TabPage QRGeneratorTabPage;
        private TabPage EFDataGenTabPage;
        private Button efGenOpenFileButton;
        private TextBox inputTextBox;
        private Label inputLabel;
        private Label SUMEPathLabel;
        private TabControl SUMETabControl;
        private TabPage SUMEDataTabPage;
        private TextBox SUMETextBox;
        private Button SUMECopyButton;
        private TabPage SUMESettingsTabPage;
        private NumericUpDown SUMEIconNumericUpDown;
        private Label SUMEIconLabel;
        private ComboBox SUMEIconQualifierComboBox;
        private Label SUMEIconQualifierLabel;
        private Label characterLimitLabel;
        private TabControl MenuTitleTabControl;
        private TabPage MenuTitleDataTabPage;
        private TextBox MenuTitleTextBox;
        private Button MenuTitleCopyButton;
        private TabPage MenuTitleSettingsTabPage;
        private ComboBox MenuTitleEncodingComboBox;
        private Label MenuTitleEncodingLabel;
        private Label MenuTitlePathLabel;
        private TabControl SPNTabControl;
        private TabPage SPNDataTabPage;
        private TextBox SPNTextBox;
        private Button SPNCopyButton;
        private TabPage SPNSettingsTabPage;
        private ComboBox SPNamePLMNRequiredComboBox;
        private Label SPNRequiredLabel;
        private ComboBox SPNRegisteredPLMNRequiredComboBox;
        private Label SPNRegRequiredLabel;
        private Label SPNPathLabel;
        private Button PNNCopyButton;
        private TextBox PNNTextBox;
        private Label PNNPathLabel;
        private OpenFileDialog efGenOpenFileDialog;
    }
}