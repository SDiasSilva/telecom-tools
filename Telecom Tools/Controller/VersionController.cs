using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Controller
{
    internal class VersionController
    {

        public void CriaSplitButtons(ToolStripDropDownButton toolStripMenuItem)
        {
            String[] versions = new string[40];

            for (int i = 0; i < 40; i++)
            {
                versions[i] = (21 + (i * 4)) + " x " + (21 + (i * 4)) + " - " + (i + 1);

                ToolStripMenuItem itemDropBox = new ToolStripMenuItem();
                itemDropBox.Text = versions[i];
                toolStripMenuItem.DropDownItems.Add(itemDropBox);
            }
        }
    }
}
