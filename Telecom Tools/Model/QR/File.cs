
namespace Telecom_Tools.Model
{

    /// <summary>
    /// Represents a file with associated properties.
    /// </summary>
    internal class File
    {
        private static string? pathFile;
        private static string? fileName;
        private static string? valueTextBox;
        private static string? directoryPath;

        /// <summary>
        /// Initializes a new instance of the File class with the specified file path, value from a text box, and file name.
        /// </summary>
        /// <param name="pathFile">The path of the file.</param>
        /// <param name="valueTextBox">The value from a text box.</param>
        /// <param name="fileName">The name of the file.</param>
        public File(string pathFile,string valueTextBox, string fileName)
        {
            File.pathFile = pathFile;
            File.fileName = fileName;
            File.valueTextBox = valueTextBox;
            directoryPath = Path.GetDirectoryName(pathFile)!;
        }

        /// <summary>
        /// Initializes a new instance of the File class.
        /// </summary>
        public File() {  }

        public static string GetPathFile() { return pathFile!; }
        public static void SetPathFile(string pathFile) { File.pathFile = pathFile; }
        public static string GetFileName() { return fileName!; }
        public static void SetFileName(string fileName) { File.fileName= fileName; }
        public static string GetValuetextBox() { return valueTextBox!; }
        public static void SetValuetextBox(string valueTextBox) { File.valueTextBox = valueTextBox; }
        public static string GetDirectoryPath() { return directoryPath!; }
    }
}
