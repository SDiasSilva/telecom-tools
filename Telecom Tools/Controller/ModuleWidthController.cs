using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telecom_Tools.Properties;

namespace Telecom_Tools.Controller
{
    internal class ModuleWidthController
    {

        private void InitializeComponent()
        {
        }

        public void CriaSplitButtons(ToolStripDropDownButton toolStripMenuItem)
        {
            for (int i = 1; i <= 5; i++)
            {
                ToolStripMenuItem itemDropBox = new ToolStripMenuItem();

                itemDropBox.Text = i.ToString();

                toolStripMenuItem.DropDownItems.Add(itemDropBox);
            }
        }

    }
}
