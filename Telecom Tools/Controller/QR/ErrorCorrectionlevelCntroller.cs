using System.Collections.Specialized;
using Telecom_Tools.Model;

namespace Telecom_Tools.Controller
{

    /// <summary>
    /// This class is responsible for managing error correction levels.
    /// </summary>
    internal class ErrorCorrectionlevelCntroller
    {
        /// <summary>
        /// Creates and configures a ComboBox to display error correction level options.
        /// The method is public and does not return a value.
        /// </summary>
        /// <param name="comboBox">The ComboBox object to be configured.</param>
        public void CriaSplitButtons(ComboBox comboBox)
        {
            StringCollection strings = new();
            string level = "Level - ";

            // Set error correction levels in the ErrorCorrectionLevel class
            ErrorCorrectionLevel.SetLevelH("H");
            ErrorCorrectionLevel.SetLevelL("L");
            ErrorCorrectionLevel.SetLevelM("M");
            ErrorCorrectionLevel.SetLevelQ("Q");

            // Add error correction levels to the string collection
            strings.Add(level+ErrorCorrectionLevel.GetLevelH());
            strings.Add(level+ErrorCorrectionLevel.GetLevelL());
            strings.Add(level+ErrorCorrectionLevel.GetLevelM());
            strings.Add(level+ErrorCorrectionLevel.GetLevelQ());

            // Remove and reassign the SelectedIndexChanged event handler
            comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            // Clear the items in the ComboBox and add the string collection
            comboBox.Items.Clear();
            comboBox.Items.AddRange(strings.Cast<object>().ToArray());

            int indicePreSelecionado = 2;
            if (indicePreSelecionado >= 0 && indicePreSelecionado < comboBox.Items.Count)
            {
                // Set the selected index of the ComboBox
                comboBox.SelectedIndex = indicePreSelecionado;
            }
            else { comboBox.SelectedIndex = -1; }
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the ComboBox.
        /// Sets the corresponding error correction level in the ErrorCorrectionLevel class
        /// based on the selected item in the ComboBox.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox comboBox = ((ComboBox)sender!);
            int selectedItem = comboBox.SelectedIndex;

            // Set the error correction level based on the selected item
            if (selectedItem == 0)  { ErrorCorrectionLevel.SetErrorCorrectionLevel("H"); } 
            else if(selectedItem == 1) { ErrorCorrectionLevel.SetErrorCorrectionLevel("L"); }
            else if(selectedItem == 2) { ErrorCorrectionLevel.SetErrorCorrectionLevel("M"); }
            else if(selectedItem == 3) { ErrorCorrectionLevel.SetErrorCorrectionLevel("Q"); }
        }

    }
}
