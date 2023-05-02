using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    // This is a utility class for working with this project View.
    internal class ViewUtil
    {
        // Returns a string representing the number of characters in a given text box input and a label text.
        public static string CountCharacters(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + textBoxText.Length + " Characters):";
            return labelText + ":";
        }

        // Returns a string representing the number of bytes in a given text box input (assuming it is a hex string) and a label text.
        public static string CountBytes(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + input.Length / 2 + " bytes):";
            return labelText + ":";
        }

        // Returns a boolean indicating if a button should be enabled based on the length of a text box input.
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
