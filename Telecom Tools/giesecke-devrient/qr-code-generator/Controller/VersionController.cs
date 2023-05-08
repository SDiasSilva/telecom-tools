using System.Collections.Specialized;
using System.Text;

namespace Telecom_Tools.Controller
{
    internal class VersionController
    {
        public void CriaSplitButtons(ComboBox comboBox)
        {
            StringCollection strings = new()
            {
                "Auto - 0"
            };
            Model.Version.SetVersionNumber(-1);
            for (int i = 0; i < 40; i++)
            {
                StringBuilder sb = new();
                sb.Append(21 + (i * 4)).Append('x').Append(21 + (i * 4)).Append(" -").Append(i + 1);
                string novaString = sb.ToString();

                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                strings.Add(novaString);
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(strings.Cast<object>().ToArray());

            int indicePreSelecionado = 0;
            if (indicePreSelecionado >= 0 && indicePreSelecionado < comboBox.Items.Count)
            {
                comboBox.SelectedIndex = indicePreSelecionado;
            }
            else { comboBox.SelectedIndex = -1; }
        }


        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender!).SelectedIndex;

            if (selectedIndex == 0) { Model.Version.SetVersionNumber(-1); }
            else { Model.Version.SetVersionNumber(selectedIndex); }
        }
    }
}
