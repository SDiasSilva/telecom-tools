using Telecom_Tools.Model;

namespace Telecom_Tools
{
    public partial class formTelecomTools : Form
    {

        Controller.ModuleWidthController moduleWidthController = new Controller.ModuleWidthController();
        public formTelecomTools()
        {
            InitializeComponent();

            moduleWidthController.CriaSplitButtons(toolStripMenuItem);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void errorCorrectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void versionDropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {

        }
    }

}