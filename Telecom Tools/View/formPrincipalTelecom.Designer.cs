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
            this.tabTelecomTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTelecomTools
            // 
            this.tabTelecomTools.Controls.Add(this.tbQRGen);
            this.tabTelecomTools.Controls.Add(this.tbEFGen);
            this.tabTelecomTools.Location = new System.Drawing.Point(2, 1);
            this.tabTelecomTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTelecomTools.Name = "tabTelecomTools";
            this.tabTelecomTools.SelectedIndex = 0;
            this.tabTelecomTools.Size = new System.Drawing.Size(307, 405);
            this.tabTelecomTools.TabIndex = 0;
            // 
            // tbQRGen
            // 
            this.tbQRGen.Location = new System.Drawing.Point(4, 24);
            this.tbQRGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQRGen.Name = "tbQRGen";
            this.tbQRGen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQRGen.Size = new System.Drawing.Size(815, 480);
            this.tbQRGen.TabIndex = 0;
            this.tbQRGen.Text = "QR Gen";
            this.tbQRGen.UseVisualStyleBackColor = true;
            // 
            // tbEFGen
            // 
            this.tbEFGen.Location = new System.Drawing.Point(4, 24);
            this.tbEFGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEFGen.Name = "tbEFGen";
            this.tbEFGen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formTelecomTools";
            this.Text = "Telecom Tools";
            this.tabTelecomTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabTelecomTools;
        private TabPage tbQRGen;
        private TabPage tbEFGen;
    }
}