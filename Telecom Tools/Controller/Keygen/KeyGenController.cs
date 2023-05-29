using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Keygen;
using Telecom_Tools.Model.Keygen.Asymmetric;

namespace Telecom_Tools.Controller.Keygen
{
    /// <summary>
    /// This class defines which Key generation algorithm will be used.
    /// </summary>
    internal class KeyGenController
    {
        private readonly Dictionary<int, SymmetricModel> SYMMETRIC_ALGORITHMS = new ()
        {
            { 0, new DESKeyGen() },
            { 1, new AESKeyGen() }
        };
        private readonly Dictionary<int, AsymmetricModel> ASYMMETRIC_ALGORITHMS = new ()
        {
            { 0, new RSAKeysGen() },
            { 1, new ProfileAKeyGen()},
            { 2, new ProfileBKeyGen()}
        };

        /// <summary>
        /// This method will generate key(s) using the parameters "passwordTextBoxText",
        /// "symmetricRadioButtonChecked", "algorithmComboBoxSelectedIndex" and 
        /// keySizeComboBoxSelectedItem.
        /// </summary>
        /// <param name="passwordTextBoxText">This parameter will be defined by the text of 
        /// passwordTextBox and it is used to generate a symmetric key.</param>
        /// <param name="symmetricRadioButtonChecked">This parameter will be defined by the checked 
        /// symmetricRadioButton and it is used to define which type of key generation algorithm will be used.</param>
        /// <param name="algorithmComboBoxSelectedIndex">This parameter will be defined by the selected
        /// index of algorithmComboBox and it is used to define which crypto algorithm
        /// will be used to generate the key(s).</param>
        /// <param name="keySizeComboBoxSelectedItem">This parameter will be defined by the selected 
        /// index of keySizeComboBox and it is used to define the key(s)' size.</param>
        /// <returns>Returns the generated key(s).</returns>
        public List<string> GenerateKeys(string passwordTextBoxText, bool symmetricRadioButtonChecked, int algorithmComboBoxSelectedIndex, object keySizeComboBoxSelectedItem)
        {
            List<string> keys = new ();
            int keySize = int.Parse(keySizeComboBoxSelectedItem.ToString().Replace(" bits", "").Replace(" bytes", ""));
            if (symmetricRadioButtonChecked) 
            {
                if (string.IsNullOrEmpty(passwordTextBoxText))
                {
                    MessageBox.Show("Password can not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    keys.Add(string.Empty);
                }
                else
                {
                    keys.Add(SYMMETRIC_ALGORITHMS[algorithmComboBoxSelectedIndex].GenerateKey(keySize, passwordTextBoxText));
                }
                keys.Add(string.Empty);
            }
            else
            {
                keys = ASYMMETRIC_ALGORITHMS[algorithmComboBoxSelectedIndex].GenerateKeyPair(keySize);
            }
            return keys;
        }

        /// <summary>
        /// This method receive the parameters "symmetricRadioButtonChecked", "selectedIndexAlgorithmComboBox", 
        /// to change the list of key sizes based on the selected algorithm in "keySizeComboBox".
        /// </summary>
        /// <param name="symmetricRadioButtonChecked">This parameter is defined by the
        /// checked symmetricRadioButton.</param>
        /// <param name="selectedIndexAlgorithmComboBox">This parameter is defined by the
        /// selected index of symmetricRadioButton.</param>
        /// <param name="keySizeComboBox">This parameter is defined by the keySizeComboBox.</param>
        public void RecoverAlgorithmKeySizes(bool symmetricRadioButtonChecked, int selectedIndexAlgorithmComboBox, ComboBox keySizeComboBox)
        {
            keySizeComboBox.Items.Clear();
            if (symmetricRadioButtonChecked)
            {
                keySizeComboBox.Items.AddRange(SYMMETRIC_ALGORITHMS[selectedIndexAlgorithmComboBox].KeySizes());
            }
            else
            {
                keySizeComboBox.Items.AddRange(ASYMMETRIC_ALGORITHMS[selectedIndexAlgorithmComboBox].KeySizes());
            }
            keySizeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// This method receive several interface components as a parameters and
        /// uses to change their behavior depending on which key generation algorythm type (Symmetric
        /// /Asymmetric) is selected by the user.
        /// </summary>
        /// <param name="symmetricRadioButtonChecked">This parameter is defined by the
        /// checked symmetricRadioButton.</param>
        /// <param name="algorithmComboBox">This parameter is defined by algorithmComboBox.</param>
        /// <param name="publicKeyTextBox">This parameter is defined by publicKeyTextBox.</param>
        /// <param name="publicKeyLabel">This parameter is defined by publicKeyLabel.</param>
        /// <param name="publicKeyCopyButton">This parameter is defined by publicKeyCopyButton.</param>
        /// <param name="generateKeyButton">This parameter is defined by generateKeyButton.</param>
        /// <param name="passwordLabel">This parameter is defined by passwordLabel.</param>
        /// <param name="passwordTextBox">This parameter is defined by passwordTextBox.</param>
        public void SetAlgorithmTypeInterface(
            bool symmetricRadioButtonChecked,
            ComboBox algorithmComboBox,
            TextBox publicKeyTextBox,
            Label publicKeyLabel, 
            Button publicKeyCopyButton,
            Button generateKeyButton,
            Label passwordLabel,
            TextBox passwordTextBox)
        {
            algorithmComboBox.Items.Clear();
            if (symmetricRadioButtonChecked)
            {
                algorithmComboBox.Items.AddRange(SYMMETRIC_ALGORITHMS.Values.Select(algorithm => algorithm.AlgorithmName()).ToArray());
                generateKeyButton.Text = "Generate Key";
            }
            else
            {
                algorithmComboBox.Items.AddRange(ASYMMETRIC_ALGORITHMS.Values.Select(algorithm => algorithm.AlgorithmName()).ToArray());
                generateKeyButton.Text = "Generate Pair";
            }
            publicKeyTextBox.Visible = !symmetricRadioButtonChecked;
            publicKeyLabel.Visible = !symmetricRadioButtonChecked;
            publicKeyCopyButton.Visible = !symmetricRadioButtonChecked;
            passwordLabel.Visible = symmetricRadioButtonChecked;
            passwordTextBox.Visible = symmetricRadioButtonChecked;
            algorithmComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// This method uses the parameter "symmetricRadioButtonChecked" to define which
        /// string will be returned.
        /// </summary>
        /// <param name="symmetricRadioButtonChecked">This parameter is defined by the
        /// checked symmetricRadioButton.</param>
        /// <returns>Returns a string depending if the algorithm type is symmetric
        /// or asymmetric.</returns>
        public static string VerifyKeyLabel(bool symmetricRadioButtonChecked)
        {
            if (symmetricRadioButtonChecked)
            {
                return "Key";
            }
            else
            {
                return "Private Key";
            }
        }
    }
}
