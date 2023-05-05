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
            this.tbEFGen = new System.Windows.Forms.TabPage();
            this.tbQRGen = new System.Windows.Forms.TabPage();
            this.errorCorrectionLevelComboBox = new System.Windows.Forms.ComboBox();
            this.versionComboBox = new System.Windows.Forms.ComboBox();
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.errorCorrectionLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.moduleWidthLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.pngCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.zipCheckBox = new System.Windows.Forms.CheckBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.tabTelecomTools = new System.Windows.Forms.TabControl();
            this.tbQRGen.SuspendLayout();
            this.tabTelecomTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEFGen
            // 
            this.tbEFGen.Location = new System.Drawing.Point(4, 34);
            this.tbEFGen.Name = "tbEFGen";
            this.tbEFGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbEFGen.Size = new System.Drawing.Size(431, 637);
            this.tbEFGen.TabIndex = 1;
            this.tbEFGen.Text = "EF Gen";
            this.tbEFGen.UseVisualStyleBackColor = true;
            // 
            // tbQRGen
            // 
            this.tbQRGen.Controls.Add(this.errorCorrectionLevelComboBox);
            this.tbQRGen.Controls.Add(this.versionComboBox);
            this.tbQRGen.Controls.Add(this.moduleComboBox);
            this.tbQRGen.Controls.Add(this.generateButton);
            this.tbQRGen.Controls.Add(this.errorCorrectionLabel);
            this.tbQRGen.Controls.Add(this.versionLabel);
            this.tbQRGen.Controls.Add(this.moduleWidthLabel);
            this.tbQRGen.Controls.Add(this.openFile);
            this.tbQRGen.Controls.Add(this.openFileTextBox);
            this.tbQRGen.Controls.Add(this.pngCheckBox);
            this.tbQRGen.Controls.Add(this.pdfCheckBox);
            this.tbQRGen.Controls.Add(this.zipCheckBox);
            this.tbQRGen.Controls.Add(this.logoCheckBox);
            this.tbQRGen.Location = new System.Drawing.Point(4, 34);
            this.tbQRGen.Name = "tbQRGen";
            this.tbQRGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbQRGen.Size = new System.Drawing.Size(431, 637);
            this.tbQRGen.TabIndex = 0;
            this.tbQRGen.Text = "QR Gen";
            this.tbQRGen.UseVisualStyleBackColor = true;
            // 
            // errorCorrectionLevelComboBox
            // 
            this.errorCorrectionLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorCorrectionLevelComboBox.FormattingEnabled = true;
            this.errorCorrectionLevelComboBox.Location = new System.Drawing.Point(303, 220);
            this.errorCorrectionLevelComboBox.Name = "errorCorrectionLevelComboBox";
            this.errorCorrectionLevelComboBox.Size = new System.Drawing.Size(110, 33);
            this.errorCorrectionLevelComboBox.TabIndex = 11;
            // 
            // versionComboBox
            // 
            this.versionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionComboBox.FormattingEnabled = true;
            this.versionComboBox.Location = new System.Drawing.Point(136, 220);
            this.versionComboBox.Name = "versionComboBox";
            this.versionComboBox.Size = new System.Drawing.Size(128, 33);
            this.versionComboBox.TabIndex = 10;
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(15, 220);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(64, 33);
            this.moduleComboBox.TabIndex = 9;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(136, 310);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(160, 65);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // errorCorrectionLabel
            // 
            this.errorCorrectionLabel.AutoSize = true;
            this.errorCorrectionLabel.Location = new System.Drawing.Point(303, 192);
            this.errorCorrectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorCorrectionLabel.Name = "errorCorrectionLabel";
            this.errorCorrectionLabel.Size = new System.Drawing.Size(87, 25);
            this.errorCorrectionLabel.TabIndex = 1;
            this.errorCorrectionLabel.Text = "ECC Level";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(136, 192);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(70, 25);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "Version";
            // 
            // moduleWidthLabel
            // 
            this.moduleWidthLabel.AutoSize = true;
            this.moduleWidthLabel.Location = new System.Drawing.Point(7, 192);
            this.moduleWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moduleWidthLabel.Name = "moduleWidthLabel";
            this.moduleWidthLabel.Size = new System.Drawing.Size(73, 25);
            this.moduleWidthLabel.TabIndex = 5;
            this.moduleWidthLabel.Text = "Module";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(15, 61);
            this.openFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(76, 38);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.Location = new System.Drawing.Point(114, 65);
            this.openFileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.ReadOnly = true;
            this.openFileTextBox.Size = new System.Drawing.Size(299, 31);
            this.openFileTextBox.TabIndex = 4;
            // 
            // pngCheckBox
            // 
            this.pngCheckBox.AutoSize = true;
            this.pngCheckBox.Location = new System.Drawing.Point(51, 137);
            this.pngCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pngCheckBox.Name = "pngCheckBox";
            this.pngCheckBox.Size = new System.Drawing.Size(77, 29);
            this.pngCheckBox.TabIndex = 0;
            this.pngCheckBox.Text = ".PNG";
            this.pngCheckBox.UseVisualStyleBackColor = true;
            // 
            // pdfCheckBox
            // 
            this.pdfCheckBox.AutoSize = true;
            this.pdfCheckBox.Location = new System.Drawing.Point(136, 137);
            this.pdfCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pdfCheckBox.Name = "pdfCheckBox";
            this.pdfCheckBox.Size = new System.Drawing.Size(74, 29);
            this.pdfCheckBox.TabIndex = 1;
            this.pdfCheckBox.Text = ".PDF";
            this.pdfCheckBox.UseVisualStyleBackColor = true;
            // 
            // zipCheckBox
            // 
            this.zipCheckBox.AutoSize = true;
            this.zipCheckBox.Location = new System.Drawing.Point(216, 137);
            this.zipCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipCheckBox.Name = "zipCheckBox";
            this.zipCheckBox.Size = new System.Drawing.Size(67, 29);
            this.zipCheckBox.TabIndex = 2;
            this.zipCheckBox.Text = ".ZIP";
            this.zipCheckBox.UseVisualStyleBackColor = true;
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Checked = true;
            this.logoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logoCheckBox.Location = new System.Drawing.Point(290, 137);
            this.logoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(85, 29);
            this.logoCheckBox.TabIndex = 3;
            this.logoCheckBox.Text = "LOGO";
            this.logoCheckBox.UseVisualStyleBackColor = true;
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
            // formTelecomTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 675);
            this.Controls.Add(this.tabTelecomTools);
            this.Name = "formTelecomTools";
            this.Text = "Telecom Tools";
            this.tbQRGen.ResumeLayout(false);
            this.tbQRGen.PerformLayout();
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
        protected Label moduleWidthLabel;

        #endregion
        private Label versionLabel;
        private Label errorCorrectionLabel;
        private Button generateButton;
        private ComboBox moduleComboBox;
        private ComboBox errorCorrectionLevelComboBox;
        private ComboBox versionComboBox;
    }
}