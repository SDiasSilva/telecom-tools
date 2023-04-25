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
            //-------------------------------------GENERATE QR CODE---------------------------------------------
            this.tbQRGen = new System.Windows.Forms.TabPage();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.pngCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.zipCheckBox = new System.Windows.Forms.CheckBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbQRGen.SuspendLayout();
            //-------------------------------------FIM GENERATE QR CODE---------------------------------------------


            this.tabTelecomTools = new System.Windows.Forms.TabControl();
            this.tbEFGen = new System.Windows.Forms.TabPage();
            this.tabTelecomTools.SuspendLayout();
            this.SuspendLayout();


            //-------------------------------------GENERATE QR CODE---------------------------------------------
            // 
            // tbQRGen
            // 
            this.tbQRGen.Controls.Add(this.openFile);
            this.tbQRGen.Controls.Add(this.openFileTextBox);
            this.tbQRGen.Controls.Add(this.pngCheckBox);
            this.tbQRGen.Controls.Add(this.pdfCheckBox);
            this.tbQRGen.Controls.Add(this.zipCheckBox);
            this.tbQRGen.Controls.Add(this.logoCheckBox);
            this.tbQRGen.Controls.Add(this.comboBox1);
            this.tbQRGen.Location = new System.Drawing.Point(4, 24);
            this.tbQRGen.Margin = new System.Windows.Forms.Padding(2);
            this.tbQRGen.Name = "tbQRGen";
            this.tbQRGen.Padding = new System.Windows.Forms.Padding(2);
            this.tbQRGen.Size = new System.Drawing.Size(299, 377);
            this.tbQRGen.TabIndex = 0;
            this.tbQRGen.Text = "QR Gen";
            this.tbQRGen.UseVisualStyleBackColor = true;
            this.tbQRGen.Click += new System.EventHandler(this.tbQRGen_Click);
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
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(36, 28);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(53, 23);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "File";
            this.openFile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.openFileTextBox.Location = new System.Drawing.Point(108, 28);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.Size = new System.Drawing.Size(153, 23);
            this.openFileTextBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            //-------------------------------------FIM GENERATE QR CODE---------------------------------------------
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
            this.tabTelecomTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabTelecomTools;
        private TabPage tbEFGen;

        //-------------------------------------GENERATE QR CODE---------------------------------------------
        private TabPage tbQRGen;
        private Button openFile;
        private TextBox openFileTextBox;
        private CheckBox pngCheckBox;
        private CheckBox pdfCheckBox;
        private CheckBox zipCheckBox;
        private CheckBox logoCheckBox;
        private ComboBox comboBox1;
        //-------------------------------------FIM GENERATE QR CODE---------------------------------------------

    }
}