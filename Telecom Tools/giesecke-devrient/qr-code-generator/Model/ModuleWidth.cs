
namespace Telecom_Tools.Model
{
    internal class ModuleWidth
    {

        private static int moduleWidth;
        private static string? moduleWidthLabelText;
        public int itemDropBoxNumber;

        public ModuleWidth(int moduleWidth,string moduleWidthLabelText)
        {
            ModuleWidth.moduleWidth = moduleWidth;
            ModuleWidth.moduleWidthLabelText = moduleWidthLabelText;
        }

        public ModuleWidth() {  }

        public static string GetModuleText() { return moduleWidthLabelText!; }
        public static int GetModuleWidth() { return moduleWidth; }
        public static void SetModuleWidth(int moduleWidth) { ModuleWidth.moduleWidth = moduleWidth; }
    }
}
