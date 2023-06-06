
namespace Telecom_Tools.Model
{
    /// <summary>
    /// Represents the module width used for encoding.
    /// </summary>
    internal class ModuleWidth
    {

        private static int moduleWidth;
        private static string? moduleWidthLabelText;

        /// <summary>
        /// Initializes a new instance of the ModuleWidth class with the specified module width and module width label text.
        /// </summary>
        /// <param name="moduleWidth">The module width used for encoding.</param>
        /// <param name="moduleWidthLabelText">The label text associated with the module width.</param>
        public ModuleWidth(int moduleWidth,string moduleWidthLabelText)
        {
            ModuleWidth.moduleWidth = moduleWidth;
            ModuleWidth.moduleWidthLabelText = moduleWidthLabelText;
        }

        /// <summary>
        /// Initializes a new instance of the ModuleWidth class.
        /// </summary>
        public ModuleWidth() {  }

        public static string GetModuleText() { return moduleWidthLabelText!; }
        public static int GetModuleWidth() { return moduleWidth; }
        public static void SetModuleWidth(int moduleWidth) { ModuleWidth.moduleWidth = moduleWidth; }
    }
}
