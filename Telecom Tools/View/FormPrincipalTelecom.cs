using Telecom_Tools.Controller.Ef;
using Telecom_Tools.Util;
using Telecom_Tools.Util.Ef;

namespace Telecom_Tools
{
    public partial class FormTelecomTools : Form
    {

        public FormTelecomTools()
        {
            InitializeComponent();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            inputLabel.Text = ViewUtil.CountCharacters(inputTextBox.Text, "Input");
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }


        private void SUMEIconQualifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);

            
        }

        private void SUMEIconNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        private void SUMETextBox_TextChanged(object sender, EventArgs e)
        {
            SUMEPathLabel.Text = ViewUtil.CountBytes(SUMETextBox.Text, "3F00/7F10/6F54 | SUME");
            SUMECopyButton.Enabled = ViewUtil.IsButtonEnabled(SUMETextBox.Text);
        }

        private void MenuTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            MenuTitlePathLabel.Text = ViewUtil.CountBytes(MenuTitleTextBox.Text, "3F00/2700/6F1E | Menu Title");
            MenuTitleCopyButton.Enabled = ViewUtil.IsButtonEnabled(MenuTitleTextBox.Text);
        }

        private void MenuTitleEncodingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.MenuTitleEncodingSelect(MenuTitleEncodingComboBox.SelectedIndex, inputTextBox, characterLimitLabel, EFDataGenTabPage);
        }

        private void SPNRegisteredPLMNRequiredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        private void SPNamePLMNRequiredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        private void SPNTextBox_TextChanged(object sender, EventArgs e)
        {
            SPNPathLabel.Text = ViewUtil.CountBytes(SPNTextBox.Text, "3F00/7F20/6F46 | SPN");
            SPNCopyButton.Enabled = ViewUtil.IsButtonEnabled(SPNTextBox.Text);
        }

        private void PNNTextBox_TextChanged(object sender, EventArgs e)
        {
            PNNPathLabel.Text = ViewUtil.CountBytes(PNNTextBox.Text, "3F00/7F20/6FC5 | PNN");
            PNNCopyButton.Enabled = ViewUtil.IsButtonEnabled(PNNTextBox.Text);
        }

        private void efGenOpenFileButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = InputFileUtil.OpenInputFile(efGenOpenFileDialog, this);
        }

        private void SUMECopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SUMETextBox.Text);
        }

        private void MenuTitleCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MenuTitleTextBox.Text);
        }

        private void SPNCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SPNTextBox.Text);
        }

        private void PNNCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PNNTextBox.Text);
        }
    }
}