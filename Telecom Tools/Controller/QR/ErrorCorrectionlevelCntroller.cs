using System.Collections.Specialized;
using Telecom_Tools.Model;

namespace Telecom_Tools.Controller
{
    internal class ErrorCorrectionlevelCntroller
    {
        public void CriaSplitButtons(ComboBox comboBox)
        {
            StringCollection strings = new();
            string level = "Level - ";

            ErrorCorrectionLevel.SetLevelH("H");
            ErrorCorrectionLevel.SetLevelL("L");
            ErrorCorrectionLevel.SetLevelM("M");
            ErrorCorrectionLevel.SetLevelQ("Q");

            strings.Add(level+ErrorCorrectionLevel.GetLevelH());
            strings.Add(level+ErrorCorrectionLevel.GetLevelL());
            strings.Add(level+ErrorCorrectionLevel.GetLevelM());
            strings.Add(level+ErrorCorrectionLevel.GetLevelQ());

                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            comboBox.Items.Clear();
            comboBox.Items.AddRange(strings.Cast<object>().ToArray());

            int indicePreSelecionado = 2;
            if (indicePreSelecionado >= 0 && indicePreSelecionado < comboBox.Items.Count)
            {
                comboBox.SelectedIndex = indicePreSelecionado;
            }
            else { comboBox.SelectedIndex = -1; }
        }

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox comboBox = ((ComboBox)sender!);
            int selectedItem = comboBox.SelectedIndex;
            if (selectedItem == 0)  { ErrorCorrectionLevel.SetErrorCorrectionLevel("H"); } 
            else if(selectedItem == 1) { ErrorCorrectionLevel.SetErrorCorrectionLevel("L"); }
            else if(selectedItem == 2) { ErrorCorrectionLevel.SetErrorCorrectionLevel("M"); }
            else if(selectedItem == 3) { ErrorCorrectionLevel.SetErrorCorrectionLevel("Q"); }
        }

    }
}
