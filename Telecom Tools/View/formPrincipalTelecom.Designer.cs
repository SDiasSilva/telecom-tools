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
            this.tabTelecomTools = new System.Windows.Forms.TabControl();
            this.tbQRGen = new System.Windows.Forms.TabPage();
            this.tbEFGen = new System.Windows.Forms.TabPage();
            this.characterLimitLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.SUMEPathLabel = new System.Windows.Forms.Label();
            this.SUMETabControl = new System.Windows.Forms.TabControl();
            this.SUMEDataTab = new System.Windows.Forms.TabPage();
            this.SUMETextBox = new System.Windows.Forms.TextBox();
            this.SUMECopyButton = new System.Windows.Forms.Button();
            this.SUMESettingsTab = new System.Windows.Forms.TabPage();
            this.SUMEIconNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SUMEIconLabel = new System.Windows.Forms.Label();
            this.SUMEIconQualifierComboBox = new System.Windows.Forms.ComboBox();
            this.SUMEIconQualifierLabel = new System.Windows.Forms.Label();
            this.tabTelecomTools.SuspendLayout();
            this.tbEFGen.SuspendLayout();
            this.SUMETabControl.SuspendLayout();
            this.SUMEDataTab.SuspendLayout();
            this.SUMESettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SUMEIconNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTelecomTools
            // 
            this.tabTelecomTools.Controls.Add(this.tbQRGen);
            this.tabTelecomTools.Controls.Add(this.tbEFGen);
            this.tabTelecomTools.Location = new System.Drawing.Point(3, 2);
            this.tabTelecomTools.Name = "tabTelecomTools";
            this.tabTelecomTools.SelectedIndex = 0;
            this.tabTelecomTools.Size = new System.Drawing.Size(439, 675);
            this.tabTelecomTools.TabIndex = 0;
            // 
            // tbQRGen
            // 
            this.tbQRGen.Location = new System.Drawing.Point(4, 34);
            this.tbQRGen.Name = "tbQRGen";
            this.tbQRGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbQRGen.Size = new System.Drawing.Size(431, 637);
            this.tbQRGen.TabIndex = 0;
            this.tbQRGen.Text = "QR Gen";
            this.tbQRGen.UseVisualStyleBackColor = true;
            // 
            // tbEFGen
            // 
            this.tbEFGen.Controls.Add(this.characterLimitLabel);
            this.tbEFGen.Controls.Add(this.openFileButton);
            this.tbEFGen.Controls.Add(this.inputTextBox);
            this.tbEFGen.Controls.Add(this.inputLabel);
            this.tbEFGen.Controls.Add(this.SUMEPathLabel);
            this.tbEFGen.Controls.Add(this.SUMETabControl);
            this.tbEFGen.Location = new System.Drawing.Point(4, 34);
            this.tbEFGen.Name = "tbEFGen";
            this.tbEFGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbEFGen.Size = new System.Drawing.Size(431, 637);
            this.tbEFGen.TabIndex = 1;
            this.tbEFGen.Text = "EF Gen";
            this.tbEFGen.UseVisualStyleBackColor = true;
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
            // openFileButton
            // 
            this.openFileButton.AccessibleDescription = "Open a file to get the customer info";
            this.openFileButton.AccessibleName = "Open File Button";
            this.openFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFileButton.Location = new System.Drawing.Point(384, 31);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(31, 31);
            this.openFileButton.TabIndex = 21;
            this.openFileButton.Tag = "";
            this.openFileButton.UseVisualStyleBackColor = true;
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
            this.SUMETabControl.Controls.Add(this.SUMEDataTab);
            this.SUMETabControl.Controls.Add(this.SUMESettingsTab);
            this.SUMETabControl.Location = new System.Drawing.Point(6, 127);
            this.SUMETabControl.Name = "SUMETabControl";
            this.SUMETabControl.SelectedIndex = 0;
            this.SUMETabControl.Size = new System.Drawing.Size(419, 111);
            this.SUMETabControl.TabIndex = 17;
            // 
            // SUMEDataTab
            // 
            this.SUMEDataTab.Controls.Add(this.SUMETextBox);
            this.SUMEDataTab.Controls.Add(this.SUMECopyButton);
            this.SUMEDataTab.Location = new System.Drawing.Point(4, 34);
            this.SUMEDataTab.Name = "SUMEDataTab";
            this.SUMEDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.SUMEDataTab.Size = new System.Drawing.Size(411, 73);
            this.SUMEDataTab.TabIndex = 0;
            this.SUMEDataTab.Text = "Data";
            this.SUMEDataTab.UseVisualStyleBackColor = true;
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
            // 
            // SUMESettingsTab
            // 
            this.SUMESettingsTab.Controls.Add(this.SUMEIconNumericUpDown);
            this.SUMESettingsTab.Controls.Add(this.SUMEIconLabel);
            this.SUMESettingsTab.Controls.Add(this.SUMEIconQualifierComboBox);
            this.SUMESettingsTab.Controls.Add(this.SUMEIconQualifierLabel);
            this.SUMESettingsTab.Location = new System.Drawing.Point(4, 34);
            this.SUMESettingsTab.Name = "SUMESettingsTab";
            this.SUMESettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SUMESettingsTab.Size = new System.Drawing.Size(411, 73);
            this.SUMESettingsTab.TabIndex = 1;
            this.SUMESettingsTab.Text = "Icon Settings";
            this.SUMESettingsTab.UseVisualStyleBackColor = true;
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
            this.SUMEIconQualifierComboBox.SelectedIndex = 2;
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
            // formTelecomTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 675);
            this.Controls.Add(this.tabTelecomTools);
            this.Name = "formTelecomTools";
            this.Text = "Telecom Tools";
            this.tabTelecomTools.ResumeLayout(false);
            this.tbEFGen.ResumeLayout(false);
            this.tbEFGen.PerformLayout();
            this.SUMETabControl.ResumeLayout(false);
            this.SUMEDataTab.ResumeLayout(false);
            this.SUMEDataTab.PerformLayout();
            this.SUMESettingsTab.ResumeLayout(false);
            this.SUMESettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SUMEIconNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabTelecomTools;
        private TabPage tbQRGen;
        private TabPage tbEFGen;
        private Button openFileButton;
        private TextBox inputTextBox;
        private Label inputLabel;
        private Label SUMEPathLabel;
        private TabControl SUMETabControl;
        private TabPage SUMEDataTab;
        private TextBox SUMETextBox;
        private Button SUMECopyButton;
        private TabPage SUMESettingsTab;
        private NumericUpDown SUMEIconNumericUpDown;
        private Label SUMEIconLabel;
        private ComboBox SUMEIconQualifierComboBox;
        private Label SUMEIconQualifierLabel;
        private Label characterLimitLabel;
    }
}