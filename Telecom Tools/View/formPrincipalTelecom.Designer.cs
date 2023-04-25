namespace Telecom_Tools
{
    partial class formTelecomTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTelecomTools));
            this.tbEFGen = new System.Windows.Forms.TabPage();
            this.tbQRGen = new System.Windows.Forms.TabPage();
            this.generateButton = new System.Windows.Forms.Button();
            this.errorCorrectionLabel = new System.Windows.Forms.Label();
            this.errorCorrectionDropDown = new System.Windows.Forms.ToolStrip();
            this.versionToolStripMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionDropDown = new System.Windows.Forms.ToolStrip();
            this.errorCorrectiongenerateButton = new System.Windows.Forms.ToolStripSplitButton();
            this.moduleWidthLabel = new System.Windows.Forms.Label();
            this.moduleDropDown = new System.Windows.Forms.ToolStrip();
            this.moduleToolStripMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.pngCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.zipCheckBox = new System.Windows.Forms.CheckBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.tabTelecomTools = new System.Windows.Forms.TabControl();
            this.tbQRGen.SuspendLayout();
            this.errorCorrectionDropDown.SuspendLayout();
            this.versionDropDown.SuspendLayout();
            this.moduleDropDown.SuspendLayout();
            this.tabTelecomTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEFGen
            // 
            this.tbEFGen.Location = new System.Drawing.Point(4, 24);
            this.tbEFGen.Margin = new System.Windows.Forms.Padding(2);
            this.tbEFGen.Name = "tbEFGen";
            this.tbEFGen.Padding = new System.Windows.Forms.Padding(2);
            this.tbEFGen.Size = new System.Drawing.Size(299, 377);
            this.tbEFGen.TabIndex = 1;
            this.tbEFGen.Text = "EF Gen";
            this.tbEFGen.UseVisualStyleBackColor = true;
            // 
            // tbQRGen
            // 
            this.tbQRGen.Controls.Add(this.generateButton);
            this.tbQRGen.Controls.Add(this.errorCorrectionLabel);
            this.tbQRGen.Controls.Add(this.errorCorrectionDropDown);
            this.tbQRGen.Controls.Add(this.versionLabel);
            this.tbQRGen.Controls.Add(this.versionDropDown);
            this.tbQRGen.Controls.Add(this.moduleWidthLabel);
            this.tbQRGen.Controls.Add(this.moduleDropDown);
            this.tbQRGen.Controls.Add(this.openFile);
            this.tbQRGen.Controls.Add(this.openFileTextBox);
            this.tbQRGen.Controls.Add(this.pngCheckBox);
            this.tbQRGen.Controls.Add(this.pdfCheckBox);
            this.tbQRGen.Controls.Add(this.zipCheckBox);
            this.tbQRGen.Controls.Add(this.logoCheckBox);
            this.tbQRGen.Location = new System.Drawing.Point(4, 24);
            this.tbQRGen.Margin = new System.Windows.Forms.Padding(2);
            this.tbQRGen.Name = "tbQRGen";
            this.tbQRGen.Padding = new System.Windows.Forms.Padding(2);
            this.tbQRGen.Size = new System.Drawing.Size(299, 377);
            this.tbQRGen.TabIndex = 0;
            this.tbQRGen.Text = "QR Gen";
            this.tbQRGen.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(95, 222);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 39);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // errorCorrectionLabel
            // 
            this.errorCorrectionLabel.AutoSize = true;
            this.errorCorrectionLabel.Location = new System.Drawing.Point(212, 115);
            this.errorCorrectionLabel.Name = "errorCorrectionLabel";
            this.errorCorrectionLabel.Size = new System.Drawing.Size(59, 15);
            this.errorCorrectionLabel.TabIndex = 1;
            this.errorCorrectionLabel.Text = "ECC Level";
            this.errorCorrectionLabel.Click += new System.EventHandler(this.errorCorrectionLabel_Click);
            // 
            // errorCorrectionDropDown
            // 
            this.errorCorrectionDropDown.Dock = System.Windows.Forms.DockStyle.None;
            this.errorCorrectionDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenu});
            this.errorCorrectionDropDown.Location = new System.Drawing.Point(95, 130);
            this.errorCorrectionDropDown.Name = "errorCorrectionDropDown";
            this.errorCorrectionDropDown.Size = new System.Drawing.Size(75, 25);
            this.errorCorrectionDropDown.TabIndex = 7;
            this.errorCorrectionDropDown.Text = "errorCorrectionDropDown";
            // 
            // versionToolStripMenu
            // 
            this.versionToolStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.versionToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("versionToolStripMenu.Image")));
            this.versionToolStripMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.versionToolStripMenu.Name = "versionToolStripMenu";
            this.versionToolStripMenu.Size = new System.Drawing.Size(63, 22);
            this.versionToolStripMenu.Text = "Auto - 0";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(95, 115);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "Version";
            // 
            // versionDropDown
            // 
            this.versionDropDown.Dock = System.Windows.Forms.DockStyle.None;
            this.versionDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorCorrectiongenerateButton});
            this.versionDropDown.Location = new System.Drawing.Point(212, 130);
            this.versionDropDown.Name = "versionDropDown";
            this.versionDropDown.Size = new System.Drawing.Size(76, 25);
            this.versionDropDown.TabIndex = 1;
            this.versionDropDown.Text = "versionDropDown";
            this.versionDropDown.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.versionDropDown_ItemClicked);
            // 
            // errorCorrectiongenerateButton
            // 
            this.errorCorrectiongenerateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.errorCorrectiongenerateButton.Image = ((System.Drawing.Image)(resources.GetObject("errorCorrectiongenerateButton.Image")));
            this.errorCorrectiongenerateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.errorCorrectiongenerateButton.Name = "errorCorrectiongenerateButton";
            this.errorCorrectiongenerateButton.Size = new System.Drawing.Size(64, 22);
            this.errorCorrectiongenerateButton.Text = "Level M";
            // 
            // moduleWidthLabel
            // 
            this.moduleWidthLabel.AutoSize = true;
            this.moduleWidthLabel.Location = new System.Drawing.Point(15, 115);
            this.moduleWidthLabel.Name = "moduleWidthLabel";
            this.moduleWidthLabel.Size = new System.Drawing.Size(48, 15);
            this.moduleWidthLabel.TabIndex = 5;
            this.moduleWidthLabel.Text = "Module";
            // 
            // moduleDropDown
            // 
            this.moduleDropDown.Dock = System.Windows.Forms.DockStyle.None;
            this.moduleDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduleToolStripMenu});
            this.moduleDropDown.Location = new System.Drawing.Point(20, 130);
            this.moduleDropDown.Name = "moduleDropDown";
            this.moduleDropDown.Size = new System.Drawing.Size(38, 25);
            this.moduleDropDown.TabIndex = 1;
            this.moduleDropDown.Text = "moduleDropDown";
            // 
            // moduleToolStripMenu
            // 
            this.moduleToolStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moduleToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("moduleToolStripMenu.Image")));
            this.moduleToolStripMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moduleToolStripMenu.Name = "moduleToolStripMenu";
            this.moduleToolStripMenu.Size = new System.Drawing.Size(26, 22);
            this.moduleToolStripMenu.Text = "1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(36, 28);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(53, 23);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.Location = new System.Drawing.Point(108, 28);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.Size = new System.Drawing.Size(153, 23);
            this.openFileTextBox.TabIndex = 4;
            // 
            // pngCheckBox
            // 
            this.pngCheckBox.AutoSize = true;
            this.pngCheckBox.Location = new System.Drawing.Point(36, 82);
            this.pngCheckBox.Name = "pngCheckBox";
            this.pngCheckBox.Size = new System.Drawing.Size(53, 19);
            this.pngCheckBox.TabIndex = 0;
            this.pngCheckBox.Text = ".PNG";
            this.pngCheckBox.UseVisualStyleBackColor = true;
            this.pngCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pdfCheckBox
            // 
            this.pdfCheckBox.AutoSize = true;
            this.pdfCheckBox.Location = new System.Drawing.Point(95, 82);
            this.pdfCheckBox.Name = "pdfCheckBox";
            this.pdfCheckBox.Size = new System.Drawing.Size(50, 19);
            this.pdfCheckBox.TabIndex = 1;
            this.pdfCheckBox.Text = ".PDF";
            this.pdfCheckBox.UseVisualStyleBackColor = true;
            this.pdfCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // zipCheckBox
            // 
            this.zipCheckBox.AutoSize = true;
            this.zipCheckBox.Location = new System.Drawing.Point(151, 82);
            this.zipCheckBox.Name = "zipCheckBox";
            this.zipCheckBox.Size = new System.Drawing.Size(46, 19);
            this.zipCheckBox.TabIndex = 2;
            this.zipCheckBox.Text = ".ZIP";
            this.zipCheckBox.UseVisualStyleBackColor = true;
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Location = new System.Drawing.Point(203, 82);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(58, 19);
            this.logoCheckBox.TabIndex = 3;
            this.logoCheckBox.Text = "LOGO";
            this.logoCheckBox.UseVisualStyleBackColor = true;
            this.logoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // tabTelecomTools
            // 
            this.tabTelecomTools.Controls.Add(this.tbQRGen);
            this.tabTelecomTools.Controls.Add(this.tbEFGen);
            this.tabTelecomTools.Location = new System.Drawing.Point(2, 1);
            this.tabTelecomTools.Margin = new System.Windows.Forms.Padding(2);
            this.tabTelecomTools.Name = "tabTelecomTools";
            this.tabTelecomTools.SelectedIndex = 0;
            this.tabTelecomTools.Size = new System.Drawing.Size(307, 405);
            this.tabTelecomTools.TabIndex = 0;
            // 
            // formTelecomTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 405);
            this.Controls.Add(this.tabTelecomTools);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formTelecomTools";
            this.Text = "Telecom Tools";
            this.tbQRGen.ResumeLayout(false);
            this.tbQRGen.PerformLayout();
            this.errorCorrectionDropDown.ResumeLayout(false);
            this.errorCorrectionDropDown.PerformLayout();
            this.versionDropDown.ResumeLayout(false);
            this.versionDropDown.PerformLayout();
            this.moduleDropDown.ResumeLayout(false);
            this.moduleDropDown.PerformLayout();
            this.tabTelecomTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TabPage tbEFGen;
        private TabPage tbQRGen;
        private Button openFile;
        private TextBox openFileTextBox;
        private CheckBox pngCheckBox;
        private CheckBox pdfCheckBox;
        private CheckBox zipCheckBox;
        private CheckBox logoCheckBox;
        private TabControl tabTelecomTools;
        private ToolStrip moduleDropDown;
        private Label moduleWidthLabel;
        private ToolStripDropDownButton moduleToolStripMenu;

        #endregion

        private ToolStrip versionDropDown;
        private Label versionLabel;
        private Label errorCorrectionLabel;
        private ToolStrip errorCorrectionDropDown;
        private ToolStripSplitButton errorCorrectiongenerateButton;
        private ToolStripDropDownButton versionToolStripMenu;
        private Button generateButton;
    }
}