using Telecom_Tools.Controller.Ef;

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
            GenerateAllEFData();
        }
        private void GenerateAllEFData()
        {
            if(inputTextBox.Text.Length != 0)
            {
                try 
                {
                    SetUpMenuElementsController sumeController = new (SUMEIconQualifierComboBox.SelectedIndex, SUMEIconNumericUpDown.Value);
                    MenuTitleController menuTitleController = new (MenuTitleEncodingComboBox.SelectedIndex);
                    SUMETextBox.Text = sumeController.GerarEf(inputTextBox.Text);
                    MenuTitleTextBox.Text = menuTitleController.GerarEf(inputTextBox.Text);
                }
                catch(ArgumentException)
                {
                    MessageBox.Show("Special characters limit exceeded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string corrected = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
                    inputTextBox.Text = corrected;
                }
            }
            else
            {
                SUMETextBox.Text = "";
                MenuTitleTextBox.Text = "";
            }
        }

        private void SUMEIconQualifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateAllEFData();
        }

        private void inputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}