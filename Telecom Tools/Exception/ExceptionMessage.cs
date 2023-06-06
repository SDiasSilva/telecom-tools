
namespace Telecom_Tools.Exceptions
{
    /// <summary>
    /// This class contains several static methods to display error messages using 
    /// the MessageBox class of Windows Forms.
    /// </summary>
    internal class ExceptionMessage
    {

        /// <summary>
        /// Displays a message informing the user that no file has been selected.
        /// </summary>
        public static void ExceptionMessageFileNotselected()
        {
            MessageBox.Show("Select a file", "File not selected", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Displays a message informing the user that the selected file is too large.
        /// </summary>
        public static void ExceptionMessageFileTooBig()
        {
            MessageBox.Show("Select a larger version", "Input file too big", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Displays a message informing the user that an unknown error has occurred 
        /// and that they should review their steps.
        /// </summary>
        public static void ExceptionMessageUnKnown()
        {
            MessageBox.Show("review your steps. one by one and look the help page", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Displays a message informing the user that the selected file format
        /// is not compliant with the expected standards.
        /// </summary>
        public static void ExceptionMessageFileOutOfformat()
        {
            MessageBox.Show("Make sure the file is up to standards" +
                            "\n \n \n Example: ICCID + Whitespace + LPA" +
                            "\n \n Example 2: \n 11111111111111111111 2222222222222222222222222222222222 ",
                            "File out of format", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Displays a message informing the user that there is a QRCode 
        /// that is repeated more than once in the input file.
        /// </summary>
        public static void ExceptionMessageQRCodeAlreadyExist()
        {
            MessageBox.Show("There is a QRCode that is repeated more than once, look your input file",
                            "QRCode is repeated", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Displays a message informing the user that there is an ICCID 
        /// that is repeated more than once in the input file.
        /// </summary>
        public static void ExceptionMessageIccidAlreadyExist()
        {
            MessageBox.Show("There is a ICCID that is repeated more than once, look your input file",
                            "QRCode is repeated", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

    }
}
