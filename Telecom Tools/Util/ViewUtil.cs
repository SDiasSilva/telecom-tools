using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    internal class ViewUtil
    {
        public static string CountCharacters(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + textBoxText.Length + " Characters):";
            return labelText + ":";
        }

        public static string CountBytes(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + input.Length / 2 + " bytes):";
            return labelText + ":";
        }
        public static bool IsButtonEnabled(string txtBoxText)
        {
            if (txtBoxText.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
