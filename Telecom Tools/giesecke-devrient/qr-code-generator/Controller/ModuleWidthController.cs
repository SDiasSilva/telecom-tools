using System.Collections.Specialized;
using System.Text;
using Telecom_Tools.Model;

namespace Telecom_Tools.Controller
{
    internal class ModuleWidthController
    {
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

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender!).SelectedIndex;
            int moduleWidth = selectedIndex + 1;
            ModuleWidth.SetModuleWidth(moduleWidth);
        }
    }
}
