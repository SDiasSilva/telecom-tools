using Telecom_Tools.Controller;
using Telecom_Tools.Controller.Ef;
using Telecom_Tools.Util;
using Telecom_Tools.Util.Ef;
using Telecom_Tools.Model;
using Telecom_Tools.Controller.Keygen;

namespace Telecom_Tools
{
    public partial class FormTelecomTools : Form
    {
        //QRCode Attributes
        private readonly ModuleWidthController moduleWidthController = new();
        private readonly VersionController versionController = new();
        private readonly ErrorCorrectionlevelCntroller errorCorrectionLevelController = new();
        private readonly FileController fileController = new();
        private string privateKeyLabelText = "";
        public FormTelecomTools()
        {
            InitializeComponent();
            SUMEIconQualifierComboBox.SelectedIndex = 2;
            MenuTitleEncodingComboBox.SelectedIndex = 0;
            SPNRegisteredPLMNRequiredComboBox.SelectedIndex = 1;
            SPNamePLMNRequiredComboBox.SelectedIndex = 0;
            hashTypeComboBox.SelectedIndex = 0;
            cryptoTypeComboBox.SelectedIndex = 0;
            algorithmComboBox.SelectedIndex = 0;
            symmetricRadioButton.Checked = true;

            
            //QRCodeGenerator
            moduleWidthController.CriaSplitButtons(moduleComboBox);
            versionController.CriaSplitButtons(versionComboBox);
            errorCorrectionLevelController.CriaSplitButtons(errorCorrectionLevelComboBox);
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

        private void EfGenOpenFileButton_Click(object sender, EventArgs e)
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

        private void PSKCalculateButton_Click(object sender, EventArgs e)
        {
            PSKTextBox.Text = new PSKController(ICCIDTextBox.Text, masterKeyTextBox.Text).CalculatePSK();
        }

        private void PSKTextBox_TextChanged(object sender, EventArgs e)
        {
            PSKLabel.Text = ViewUtil.CountCharactersAndBytes(PSKTextBox.Text, "PSK");
            PSKCopyButton.Enabled = ViewUtil.IsButtonEnabled(PSKTextBox.Text);
        }

        private void ClearAllPSKFieldsButton_Click(object sender, EventArgs e)
        {
            ICCIDTextBox.Text = "";
            masterKeyTextBox.Text = "";
            PSKTextBox.Text = "";
        }

        private void PSKCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PSKTextBox.Text);
        }

        private void ICCIDTextBox_TextChanged(object sender, EventArgs e)
        {
            ICCIDLabel.Text = ViewUtil.CountCharactersAndBytes(ICCIDTextBox.Text, "ICCID");
        }

        private void MasterKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            masterKeyLabel.Text = ViewUtil.CountCharactersAndBytes(masterKeyTextBox.Text, "Master Key");
        }

        private void PlaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            plaintextLabel.Text = ViewUtil.CountCharacters(plaintextTextBox.Text, "Plaintext");
        }

        private void GetHashButton_Click(object sender, EventArgs e)
        {
            hashTextBox.Text = new HashController().SelectHashAlgorithm(hashTypeComboBox.SelectedIndex).ComputeHash(plaintextTextBox.Text);
        }

        private void HashTextBox_TextChanged(object sender, EventArgs e)
        {
            hashLabel.Text = ViewUtil.CountCharactersAndBytes(hashTextBox.Text, "Hash");
            HashCopyButton.Enabled = ViewUtil.IsButtonEnabled(hashTextBox.Text);
        }

        private void HashCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hashTextBox.Text);
        }

        private void ClearAllHashFieldsButton_Click(object sender, EventArgs e)
        {
            plaintextTextBox.Text = "";
            hashTextBox.Text = "";
        }

        private void CalculateKCVButton_Click(object sender, EventArgs e)
        {
            KCVTextBox.Text = new KCVController().SelectCryptoType(cryptoTypeComboBox.SelectedIndex).CalculateKCV(keyTextBox.Text);
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            keyLabel.Text = ViewUtil.CountCharactersAndBytes(keyTextBox.Text, "Key");
        }

        private void KCVTextBox_TextChanged(object sender, EventArgs e)
        {
            KCVLabel.Text = ViewUtil.CountCharactersAndBytes(KCVTextBox.Text, "KCV");
            KCVCopyButton.Enabled = ViewUtil.IsButtonEnabled(KCVTextBox.Text);
        }

        private void ClearAllKCVFields_Click(object sender, EventArgs e)
        {
            keyTextBox.Text = "";
            KCVTextBox.Text = "";
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            fileController.OpenFile(openFileTextBox);
        }
        private void TypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            privateKeyLabelText = KeyGenController.VerifyKeyLabel(symmetricRadioButton.Checked);
            privateKeyLabel.Text = privateKeyLabelText+ ":";
            new KeyGenController().SetAlgorithmTypeInterface(
            symmetricRadioButton.Checked,
            algorithmComboBox,
            publicKeyTextBox,
            publicKeyLabel,
            publicKeyCopyButton,
            generateKeyButton,
            passwordLabel,
            passwordTextBox);
            ClearKeyGenFields(sender, e);
        }
        private void GeneratedKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            privateKeyLabel.Text = ViewUtil.CountBytes(privateKeyTextBox.Text, privateKeyLabelText);
            privateKeyCopyButton.Enabled = ViewUtil.IsButtonEnabled(privateKeyTextBox.Text);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordLabel.Text = ViewUtil.CountCharacters(passwordTextBox.Text, "Password");
        }

        private void PublicKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            publicKeyLabel.Text = ViewUtil.CountBytes(publicKeyTextBox.Text, "Public Key");
            publicKeyCopyButton.Enabled = ViewUtil.IsButtonEnabled(publicKeyTextBox.Text);
        }

        private void AlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new KeyGenController().RecoverAlgorithmKeySizes(symmetricRadioButton.Checked, algorithmComboBox.SelectedIndex, keySizeComboBox);
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            List<string> keys = new KeyGenController().GenerateKeys(passwordTextBox.Text, symmetricRadioButton.Checked, algorithmComboBox.SelectedIndex, keySizeComboBox.SelectedItem);
            privateKeyTextBox.Text = keys[0];
            publicKeyTextBox.Text = keys[1];
        }

        private void PrivateKeyCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(privateKeyTextBox.Text);
        }

        private void PublicKeyCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(publicKeyTextBox.Text);
        }

        private void ClearKeyGenFields(object sender, EventArgs e)
        {
            privateKeyTextBox.Text = "";
            publicKeyTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void OpenFileTextBox_TextChanged(object sender, EventArgs e)
        {
            generateQRCodesButton.Enabled = ViewUtil.IsButtonEnabled(openFileTextBox.Text);
        }

        private void GenerateQRCodesButton_Click(object sender, EventArgs e)
        {
            fileController.Generate(pdfCheckBox, zipCheckBox, pngCheckBox, logoCheckBox);
        }
    }
}