
namespace Telecom_Tools.Model
{
    internal class Version
    {
        private static int versionNumber;

        public Version( int versionNumber)
        {
            Version.versionNumber = versionNumber;
        }
        public Version() {  }

        public static int GetVersionNumber() { return versionNumber; }
        public static void SetVersionNumber(int versionNumber) { Version.versionNumber = versionNumber; }
    }
}
