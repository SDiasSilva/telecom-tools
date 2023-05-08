
namespace Telecom_Tools.Exceptions
{
    internal class ExceptionMessage
    {
        public static void ExceptionMessageFileNotselected()
        {
            MessageBox.Show("Select a file", "File not selected", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ExceptionMessageFileTooBig()
        {
            MessageBox.Show("Select a larger version", "Input file too big", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ExceptionMessageUnKnown()
        {
            MessageBox.Show("review your steps. one by one and look the help page", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ExceptionMessageFileOutOfformat()
        {
            MessageBox.Show("Make sure the file is up to standards" +
                            "\n \n \n Example: ICCID + Whitespace + LPA" +
                            "\n \n Example 2: \n 11111111111111111111 2222222222222222222222222222222222 ",
                            "File out of format", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ExceptionMessageQRCodeAlreadyExist()
        {
            MessageBox.Show("There is a QRCode that is repeated more than once, look your input file",
                            "QRCode is repeated", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ExceptionMessageIccidAlreadyExist()
        {
            MessageBox.Show("There is a ICCID that is repeated more than once, look your input file",
                            "QRCode is repeated", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

    }
}
