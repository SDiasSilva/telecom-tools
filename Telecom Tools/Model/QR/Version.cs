
namespace Telecom_Tools.Model
{

    /// <summary>
    /// Represents the version number used for encoding.
    /// </summary>
    internal class Version
    {
        private static int versionNumber;

        /// <summary>
        /// Initializes a new instance of the Version class with the specified version number.
        /// </summary>
        /// <param name="versionNumber">The version number used for encoding.</param>
        public Version( int versionNumber)
        {
            Version.versionNumber = versionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version() {  }

        public static int GetVersionNumber() { return versionNumber; }
        public static void SetVersionNumber(int versionNumber) { Version.versionNumber = versionNumber; }
    }
}
