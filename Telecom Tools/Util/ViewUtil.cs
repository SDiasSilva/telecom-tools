using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    /// <summary>
    /// This is a utility class for working with the project's view.
    /// </summary>
    internal class ViewUtil
    {
        /// <summary>
        /// Returns a string representing the number of characters in a given text box input and a label text.
        /// </summary>
        /// <param name="textBoxText">The text box input.</param>
        /// <param name="labelText">The label text.</param>
        /// <returns>A string representing the number of characters.</returns>
        public static string CountCharacters(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + textBoxText.Length + " Characters):";
            return labelText + ":";
        }

        /// <summary>
        /// Returns a string representing the number of bytes in a given text box input (assuming it is a hex string) and a label text.
        /// </summary>
        /// <param name="textBoxText">The text box input.</param>
        /// <param name="labelText">The label text.</param>
        /// <returns>A string representing the number of bytes.</returns>
        public static string CountBytes(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + input.Length / 2 + " bytes):";
            return labelText + ":";
        }

        /// <summary>
        /// Returns a string representing the number of characters and bytes in a given text box input and a label text.
        /// </summary>
        /// <param name="textBoxText">The text box input.</param>
        /// <param name="labelText">The label text.</param>
        /// <returns>A string representing the number of characters and bytes.</returns>
        public static string CountCharactersAndBytes(string textBoxText, string labelText)
        {
            string input = textBoxText;
            input = input.Replace(" ", "");
            if (input.Length > 0)
                return labelText + " (" + textBoxText.Length + " Characters - " + input.Length / 2 + " bytes):";
            return labelText + ":";
        }

        /// <summary>
        /// Returns a boolean indicating if a button should be enabled based on the length of a text box input.
        /// </summary>
        /// <param name="txtBoxText">The text box input.</param>
        /// <returns>True if the button should be enabled; otherwise, false.</returns>
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
