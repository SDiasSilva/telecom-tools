using System.Collections.Specialized;
using System.Text;
using Telecom_Tools.Model;

namespace Telecom_Tools.Controller
{

    /// <summary>
    /// Controller class for managing the module width selection in a user interface.
    /// </summary>
    internal class ModuleWidthController
    {

        /// <summary>
        /// Creates split buttons for the specified ComboBox control and sets the event handler for the SelectedIndexChanged event.
        /// </summary>
        /// <param name="comboBox">The ComboBox control to create split buttons for.</param>
        public void CriaSplitButtons(ComboBox comboBox)
        {
            StringCollection strings = new();

            for (int i = 1; i < 5; i++)
            {
                StringBuilder sb = new();
                sb.Append(i);
                string novaString = sb.ToString();

                strings.Add(novaString);

                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(strings.Cast<object>().ToArray());

            int indicePreSelecionado = 3;
            if (indicePreSelecionado >= 0 && indicePreSelecionado < comboBox.Items.Count)
            {
                comboBox.SelectedIndex = indicePreSelecionado;
            }
            else { comboBox.SelectedIndex = -1; }
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the ComboBox control.
        /// Sets the module width based on the selected index of the ComboBox.
        /// </summary>
        /// <param name="sender">The event sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender!).SelectedIndex;
            int moduleWidth = selectedIndex + 1;
            ModuleWidth.SetModuleWidth(moduleWidth);
        }
    }
}
