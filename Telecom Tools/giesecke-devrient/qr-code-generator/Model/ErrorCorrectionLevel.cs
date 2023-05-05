
namespace Telecom_Tools.Model
{
    internal class ErrorCorrectionLevel
    {
        private static string? errorCorrectionLevel;
        private static string? levelH;
        private static string? levelL;
        private static string? levelM;
        private static string? levelQ;

        public ErrorCorrectionLevel() { }
        public ErrorCorrectionLevel(string errorCorrectionLevel, string levelH, string levelL, string levelM, string levelQ)
        {
            ErrorCorrectionLevel.errorCorrectionLevel = errorCorrectionLevel;
            ErrorCorrectionLevel.levelH = levelH;
            ErrorCorrectionLevel.levelL = levelL;
            ErrorCorrectionLevel.levelM = levelM;
            ErrorCorrectionLevel.levelQ = levelQ;
         }

        public static string GetErrorCorrectionLevel(){ return errorCorrectionLevel!; }
        public static void SetErrorCorrectionLevel(string errorCorrectionLevel) { ErrorCorrectionLevel.errorCorrectionLevel = errorCorrectionLevel; }
        public static string GetLevelH() { return levelH!; }
        public static void SetLevelH(string levelH) { ErrorCorrectionLevel.levelH = levelH; }
        public static string GetLevelL() { return levelL!; }
        public static void SetLevelL(string levelL) { ErrorCorrectionLevel.levelL = levelL; }
        public static string GetLevelM() { return levelM!; }
        public static void SetLevelM(string levelM) { ErrorCorrectionLevel.levelM = levelM; } 
        public static string GetLevelQ() { return levelQ!; }
        public static void SetLevelQ(string levelQ) { ErrorCorrectionLevel.levelQ = levelQ; }


    }
}
