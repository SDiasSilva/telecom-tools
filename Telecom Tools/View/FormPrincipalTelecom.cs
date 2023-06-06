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

        /// <summary>
        /// Initializes a new instance of the FormTelecomTools class.
        /// </summary>
        public FormTelecomTools()
        {
            InitializeComponent();

            // Sets the initial selected index values for various controls
            SUMEIconQualifierComboBox.SelectedIndex = 2;
            MenuTitleEncodingComboBox.SelectedIndex = 0;
            SPNRegisteredPLMNRequiredComboBox.SelectedIndex = 1;
            SPNamePLMNRequiredComboBox.SelectedIndex = 0;
            hashTypeComboBox.SelectedIndex = 0;
            cryptoTypeComboBox.SelectedIndex = 0;
            algorithmComboBox.SelectedIndex = 0;
            symmetricRadioButton.Checked = true;

            // Initializes QRCodeGenerator controls
            moduleWidthController.CriaSplitButtons(moduleComboBox);
            versionController.CriaSplitButtons(versionComboBox);
            errorCorrectionLevelController.CriaSplitButtons(errorCorrectionLevelComboBox);
        }

        /// <summary>
        /// Event handler called when the text in the InputTextBox is changed.
        /// Updates the character count in the inputLabel and generates corresponding EF data.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            inputLabel.Text = ViewUtil.CountCharacters(inputTextBox.Text, "Input");
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        /// <summary>
        /// Event handler called when the selected item in the SUMEIconQualifierComboBox is changed.
        /// Generates corresponding EF data.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SUMEIconQualifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        /// <summary>
        /// Event handler called when the value of the SUMEIconNumericUpDown is changed.
        /// Generates corresponding EF data.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SUMEIconNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        /// <summary>
        /// Event handler called when the text in the SUMETextBox is changed.
        /// Updates the byte count in the SUMEPathLabel and enables/disables the SUMECopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SUMETextBox_TextChanged(object sender, EventArgs e)
        {
            SUMEPathLabel.Text = ViewUtil.CountBytes(SUMETextBox.Text, "3F00/7F10/6F54 | SUME");
            SUMECopyButton.Enabled = ViewUtil.IsButtonEnabled(SUMETextBox.Text);
        }

        /// <summary>
        /// Event handler called when the text in the MenuTitleTextBox is changed.
        /// Updates the byte count in the MenuTitlePathLabel and enables/disables the MenuTitleCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            MenuTitlePathLabel.Text = ViewUtil.CountBytes(MenuTitleTextBox.Text, "3F00/2700/6F1E | Menu Title");
            MenuTitleCopyButton.Enabled = ViewUtil.IsButtonEnabled(MenuTitleTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the selected item in the MenuTitleEncodingComboBox is changed.
        /// Selects the encoding for the menu title and updates the interface accordingly.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuTitleEncodingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.MenuTitleEncodingSelect(MenuTitleEncodingComboBox.SelectedIndex, inputTextBox, characterLimitLabel, EFDataGenTabPage);
        }

        /// <summary>
        /// Event handler called when the selected item in the SPNRegisteredPLMNRequiredComboBox is changed.
        /// Generates corresponding EF data.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SPNRegisteredPLMNRequiredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        /// <summary>
        /// Event handler called when the selected item in the SPNamePLMNRequiredComboBox is changed.
        /// Generates corresponding EF data.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SPNamePLMNRequiredComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfUtil.GenerateAllEFData(EFDataGenTabPage);
        }

        /// <summary>
        /// Event handler called when the text in the SPNTextBox is changed.
        /// Updates the byte count in the SPNPathLabel and enables/disables the SPNCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SPNTextBox_TextChanged(object sender, EventArgs e)
        {
            SPNPathLabel.Text = ViewUtil.CountBytes(SPNTextBox.Text, "3F00/7F20/6F46 | SPN");
            SPNCopyButton.Enabled = ViewUtil.IsButtonEnabled(SPNTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the text in the PNNTextBox is changed.
        /// Updates the byte count in the PNNPathLabel and enables/disables the PNNCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PNNTextBox_TextChanged(object sender, EventArgs e)
        {
            PNNPathLabel.Text = ViewUtil.CountBytes(PNNTextBox.Text, "3F00/7F20/6FC5 | PNN");
            PNNCopyButton.Enabled = ViewUtil.IsButtonEnabled(PNNTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the EfGenOpenFileButton is clicked.
        /// Opens an input file and sets its content in the inputTextBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EfGenOpenFileButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = InputFileUtil.OpenInputFile(efGenOpenFileDialog, this);
        }

        /// <summary>
        /// Event handler called when the SUMECopyButton is clicked.
        /// Copies the content of the SUMETextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SUMECopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SUMETextBox.Text);
        }

        /// <summary>
        /// Event handler called when the MenuTitleCopyButton is clicked.
        /// Copies the content of the MenuTitleTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MenuTitleCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MenuTitleTextBox.Text);
        }


        /// <summary>
        /// Event handler called when the SPNCopyButton is clicked.
        /// Copies the content of the SPNTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void SPNCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SPNTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the PNNCopyButton is clicked.
        /// Copies the content of the PNNTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PNNCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PNNTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the PSKCalculateButton is clicked.
        /// Calculates the PSK based on the ICCID and masterKeyTextBox values and sets it in the PSKTextBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PSKCalculateButton_Click(object sender, EventArgs e)
        {
            PSKTextBox.Text = new PSKController(ICCIDTextBox.Text, masterKeyTextBox.Text).CalculatePSK();
        }

        /// <summary>
        /// Event handler called when the text in the PSKTextBox is changed.
        /// Updates the character and byte count in the PSKLabel and enables/disables the PSKCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PSKTextBox_TextChanged(object sender, EventArgs e)
        {
            PSKLabel.Text = ViewUtil.CountCharactersAndBytes(PSKTextBox.Text, "PSK");
            PSKCopyButton.Enabled = ViewUtil.IsButtonEnabled(PSKTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the ClearAllPSKFieldsButton is clicked.
        /// Clears all fields related to PSK (ICCIDTextBox, masterKeyTextBox, PSKTextBox).
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ClearAllPSKFieldsButton_Click(object sender, EventArgs e)
        {
            ICCIDTextBox.Text = "";
            masterKeyTextBox.Text = "";
            PSKTextBox.Text = "";
        }

        /// <summary>
        /// Event handler called when the PSKCopyButton is clicked.
        /// Copies the content of the PSKTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PSKCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PSKTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the text in the ICCIDTextBox is changed.
        /// Updates the character and byte count in the ICCIDLabel.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ICCIDTextBox_TextChanged(object sender, EventArgs e)
        {
            ICCIDLabel.Text = ViewUtil.CountCharactersAndBytes(ICCIDTextBox.Text, "ICCID");
        }

        /// <summary>
        /// Event handler called when the text in the MasterKeyTextBox is changed.
        /// Updates the character and byte count in the masterKeyLabel.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void MasterKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            masterKeyLabel.Text = ViewUtil.CountCharactersAndBytes(masterKeyTextBox.Text, "Master Key");
        }

        /// <summary>
        /// Event handler called when the text in the PlaintextTextBox is changed.
        /// Updates the character count in the plaintextLabel.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PlaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            plaintextLabel.Text = ViewUtil.CountCharacters(plaintextTextBox.Text, "Plaintext");
        }

        /// <summary>
        /// Event handler called when the GetHashButton is clicked.
        /// Computes the hash of the plaintext based on the selected hash algorithm and sets it in the hashTextBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void GetHashButton_Click(object sender, EventArgs e)
        {
            hashTextBox.Text = new HashController().SelectHashAlgorithm(hashTypeComboBox.SelectedIndex).ComputeHash(plaintextTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the text in the hashTextBox is changed.
        /// Updates the character and byte count in the hashLabel and enables/disables the HashCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void HashTextBox_TextChanged(object sender, EventArgs e)
        {
            hashLabel.Text = ViewUtil.CountCharactersAndBytes(hashTextBox.Text, "Hash");
            HashCopyButton.Enabled = ViewUtil.IsButtonEnabled(hashTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the HashCopyButton is clicked.
        /// Copies the content of the hashTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void HashCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hashTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the ClearAllHashFieldsButton is clicked.
        /// Clears all fields related to hashing (plaintextTextBox, hashTextBox).
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ClearAllHashFieldsButton_Click(object sender, EventArgs e)
        {
            plaintextTextBox.Text = "";
            hashTextBox.Text = "";
        }

        /// <summary>
        /// Event handler called when the CalculateKCVButton is clicked.
        /// Calculates the Key Check Value (KCV) based on the selected crypto type and key value and sets it in the KCVTextBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CalculateKCVButton_Click(object sender, EventArgs e)
        {
            KCVTextBox.Text = new KCVController().SelectCryptoType(cryptoTypeComboBox.SelectedIndex).CalculateKCV(keyTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the text in the keyTextBox is changed.
        /// Updates the character and byte count in the keyLabel.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            keyLabel.Text = ViewUtil.CountCharactersAndBytes(keyTextBox.Text, "Key");
        }

        /// <summary>
        /// Event handler called when the text in the KCVTextBox is changed.
        /// Updates the character and byte count in the KCVLabel and enables/disables the KCVCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void KCVTextBox_TextChanged(object sender, EventArgs e)
        {
            KCVLabel.Text = ViewUtil.CountCharactersAndBytes(KCVTextBox.Text, "KCV");
            KCVCopyButton.Enabled = ViewUtil.IsButtonEnabled(KCVTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the ClearAllKCVFieldsButton is clicked.
        /// Clears all fields related to KCV calculation (keyTextBox, KCVTextBox).
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ClearAllKCVFields_Click(object sender, EventArgs e)
        {
            keyTextBox.Text = "";
            KCVTextBox.Text = "";
        }

        /// <summary>
        /// Event handler called when the OpenFileButton is clicked.
        /// Opens a file using the fileController and sets the selected file path in the openFileTextBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OpenFile_Click(object sender, EventArgs e)
        {
            fileController.OpenFile(openFileTextBox);
        }

        /// <summary>
        /// Event handler called when the TypeRadioButton's CheckedChanged event is triggered.
        /// Updates the private key label, sets the appropriate algorithm type interface elements,
        /// and clears the key generation fields.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
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

        /// <summary>
        /// Event handler called when the text in the privateKeyTextBox is changed.
        /// Updates the character and byte count in the privateKeyLabel and enables/disables the privateKeyCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void GeneratedKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            privateKeyLabel.Text = ViewUtil.CountCharactersAndBytes(privateKeyTextBox.Text, privateKeyLabelText);
            privateKeyCopyButton.Enabled = ViewUtil.IsButtonEnabled(privateKeyTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the text in the passwordTextBox is changed.
        /// Updates the character count in the passwordLabel.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordLabel.Text = ViewUtil.CountCharacters(passwordTextBox.Text, "Password");
        }

        /// <summary>
        /// Event handler called when the text in the publicKeyTextBox is changed.
        /// Updates the character and byte count in the publicKeyLabel and enables/disables the publicKeyCopyButton.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PublicKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            publicKeyLabel.Text = ViewUtil.CountCharactersAndBytes(publicKeyTextBox.Text, "Public Key");
            publicKeyCopyButton.Enabled = ViewUtil.IsButtonEnabled(publicKeyTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the algorithmComboBox's SelectedIndexChanged event is triggered.
        /// Recovers the algorithm's key sizes and updates the keySizeComboBox accordingly.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void AlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new KeyGenController().RecoverAlgorithmKeySizes(symmetricRadioButton.Checked, algorithmComboBox.SelectedIndex, keySizeComboBox);
        }

        /// <summary>
        /// Event handler called when the GenerateKeyButton is clicked.
        /// Generates keys based on the provided password, algorithm type, algorithm index, and selected key size.
        /// Sets the generated private and public keys in the privateKeyTextBox and publicKeyTextBox, respectively.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            List<string> keys = new KeyGenController().GenerateKeys(passwordTextBox.Text, symmetricRadioButton.Checked, algorithmComboBox.SelectedIndex, keySizeComboBox.SelectedItem);
            privateKeyTextBox.Text = keys[0];
            publicKeyTextBox.Text = keys[1];
        }

        /// <summary>
        /// Event handler called when the PrivateKeyCopyButton is clicked.
        /// Copies the content of the privateKeyTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PrivateKeyCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(privateKeyTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the PublicKeyCopyButton is clicked.
        /// Copies the content of the publicKeyTextBox to the clipboard.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PublicKeyCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(publicKeyTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the ClearKeyGenFieldsButton is clicked.
        /// Clears all fields related to key generation (privateKeyTextBox, publicKeyTextBox, passwordTextBox).
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ClearKeyGenFields(object sender, EventArgs e)
        {
            privateKeyTextBox.Text = "";
            publicKeyTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        /// <summary>
        /// Event handler called when the text in the openFileTextBox is changed.
        /// Enables/disables the generateQRCodesButton based on the open file path.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OpenFileTextBox_TextChanged(object sender, EventArgs e)
        {
            generateQRCodesButton.Enabled = ViewUtil.IsButtonEnabled(openFileTextBox.Text);
        }

        /// <summary>
        /// Event handler called when the GenerateQRCodesButton is clicked.
        /// Generates QR codes based on the selected options (pdfCheckBox, zipCheckBox, pngCheckBox, logoCheckBox).
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void GenerateQRCodesButton_Click(object sender, EventArgs e)
        {
            fileController.Generate(pdfCheckBox, zipCheckBox, pngCheckBox, logoCheckBox);
        }
    }
}