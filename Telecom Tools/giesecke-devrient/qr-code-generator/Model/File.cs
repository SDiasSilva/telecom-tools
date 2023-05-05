
namespace Telecom_Tools.Model
{
    internal class File
    {
        private static string? pathFile;
        private static string? fileName;
        private static string? valueTextBox;
        private static string? directoryPath;

        public File(string pathFile,string valueTextBox, string fileName)
        {
            File.pathFile = pathFile;
            File.fileName = fileName;
            File.valueTextBox = valueTextBox;
            directoryPath = Path.GetDirectoryName(pathFile)!;
        }
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
