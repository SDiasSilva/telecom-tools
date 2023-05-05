using System.Windows.Forms;
using Telecom_Tools.Controller;
using Telecom_Tools.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Telecom_Tools
{
    public partial class formTelecomTools : Form
    {
        Model.ModuleWidth moduleWidthClass = new Model.ModuleWidth();
        Controller.ModuleWidthController moduleWidthController = new Controller.ModuleWidthController();
        Controller.VersionController versionController = new Controller.VersionController();
        Controller.ErrorCorrectionlevelCntroller errorCorrectionLevelController = new Controller.ErrorCorrectionlevelCntroller();
        Controller.FileController fileController = new Controller.FileController();

        private ModuleWidth moduleWidth;

        public formTelecomTools()
        {
            InitializeComponent();

            moduleWidthController.CriaSplitButtons(moduleComboBox);
            versionController.CriaSplitButtons(versionComboBox);
            errorCorrectionLevelController.CriaSplitButtons(errorCorrectionLevelComboBox);
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            fileController.OpenFile(openFileTextBox);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            fileController.Generate(pdfCheckBox, zipCheckBox, pngCheckBox, logoCheckBox); ;
        }
    }

}