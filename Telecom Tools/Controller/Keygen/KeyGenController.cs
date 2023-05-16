using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Keygen;
using Telecom_Tools.Model.Keygen.Asymmetric;

namespace Telecom_Tools.Controller.Keygen
{
    internal class KeyGenController
    {
        private readonly Dictionary<int, SymmetricModel> SYMMETRIC_ALGORITHMS = new ()
        {
            { 0, new DESKeyGen() },
            { 1, new AESKeyGen() }
        };
        private readonly Dictionary<int, AsymmetricModel> ASYMMETRIC_ALGORITHMS = new ()
        {
            { 0, new RSAKeysGen() }
        };

        public List<string> GenerateKeys(string saltTextBoxText, bool symmetricRadioButtonChecked, int algorithmComboBoxSelectedIndex, object keySizeComboBoxSelectedItem)
        {
            List<string> keys = new ();
            int keySize = int.Parse(keySizeComboBoxSelectedItem.ToString().Replace(" bits", ""));
            if (symmetricRadioButtonChecked) 
            {
                keys.Add(SYMMETRIC_ALGORITHMS[algorithmComboBoxSelectedIndex].GenerateKey(keySize));
                keys.Add("");
            }
            else
            {
                keys = ASYMMETRIC_ALGORITHMS[algorithmComboBoxSelectedIndex].GenerateKeyPair(keySize, saltTextBoxText);
            }
            return keys;
        }
        public void RecoverAlgorithmKeySizes(bool symmetricRadioButtonChecked, int selectedIndex, ComboBox keySizeComboBox)
        {
            keySizeComboBox.Items.Clear();
            if (symmetricRadioButtonChecked)
            {
                keySizeComboBox.Items.AddRange(SYMMETRIC_ALGORITHMS[selectedIndex].KeySizes());
            }
            else
            {
                keySizeComboBox.Items.AddRange(ASYMMETRIC_ALGORITHMS[selectedIndex].KeySizes());
            }
            keySizeComboBox.SelectedIndex = 0;
        }


        public void SetAlgorithmTypeInterface(
            bool symmetricRadioButtonChecked,
            ComboBox algorithmComboBox,
            TextBox publicKeyTextBox,
            Label publicKeyLabel,
            Button publicKeyCopyButton,
            Button generateKeyButton)
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
            algorithmComboBox.SelectedIndex = 0;
        }
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
