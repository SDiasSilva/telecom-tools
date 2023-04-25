using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    internal class MenuTitle:EfModel
    {
        public int Encoding { get; set; }
        public MenuTitle(int encoding)
        {
            Path = "3F00/2700/6F1E";
            SimpleName = "Menu Title";
            Length = 19;
            Encoding = encoding;
        }
    }
}
