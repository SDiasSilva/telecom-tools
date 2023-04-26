using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Controller.Ef;

namespace Telecom_Tools.Util.Ef
{
    internal class EfUtil
    {
        public static void GenerateAllEFData(TabPage eFDataGenTabPage)
        {
            var inputTextBox = eFDataGenTabPage.Controls.Find("inputTextBox", true).FirstOrDefault() as TextBox;
            var SUMETextBox = eFDataGenTabPage.Controls.Find("SUMETextBox", true).FirstOrDefault() as TextBox;
            var MenuTitleTextBox = eFDataGenTabPage.Controls.Find("MenuTitleTextBox", true).FirstOrDefault() as TextBox;
            var SUMEIconQualifierComboBox = eFDataGenTabPage.Controls.Find("SUMEIconQualifierComboBox", true).FirstOrDefault() as ComboBox;
            var MenuTitleEncodingComboBox = eFDataGenTabPage.Controls.Find("MenuTitleEncodingComboBox", true).FirstOrDefault() as ComboBox;
            var SUMEIconNumericUpDown = eFDataGenTabPage.Controls.Find("SUMEIconNumericUpDown", true).FirstOrDefault() as NumericUpDown;

            if (inputTextBox.Text.Length != 0)
            {
                try
                {
                    SetUpMenuElementsController sumeController = new(iconQualifier: SUMEIconQualifierComboBox.SelectedIndex, SUMEIconNumericUpDown.Value);
                    MenuTitleController menuTitleController = new(MenuTitleEncodingComboBox.SelectedIndex);
                    SUMETextBox.Text = sumeController.GerarEf(inputTextBox.Text);
                    MenuTitleTextBox.Text = menuTitleController.GerarEf(inputTextBox.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Special characters limit exceeded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //string corrected = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
                    //inputTextBox.Text = corrected;
                    inputTextBox.Text = inputTextBox.Text[..inputTextBox.MaxLength];
                }
            }
            else
            {
                SUMETextBox.Text = "";
                MenuTitleTextBox.Text = "";
            }
        }

        public static void MenuTitleEncodingSelect(int selectedEncoding, TextBox inputTextBox, Label lblCharacterLimit, TabPage eFDataGenTabPage)
        {
            switch (selectedEncoding)
            {
                case 0: //GSM 03.38 Default
                    inputTextBox.MaxLength = 16;
                    break;
                case 1: //GSM 11.11/1
                    inputTextBox.MaxLength = 7;
                    break;
                case 2: //GSM 11.11/2
                    inputTextBox.MaxLength = 13;
                    break;
                case 3: //GSM 11.11/3
                    inputTextBox.MaxLength = 12;
                    break;
            }
            lblCharacterLimit.Text = "Character Limit: " + inputTextBox.MaxLength;
            if (inputTextBox.Text.Length != 0)
            {
                GenerateAllEFData(eFDataGenTabPage);
            }
        }
    }
}
