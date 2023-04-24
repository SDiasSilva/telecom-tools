using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model
{
    internal class ErrorCorrectionLevel
    {

        private string errorCorrectionText;

        private string errorItemLText;
        private string errorItemMText;
        private string errorItemQText;
        private string errorItemHText;

        private string errorButtonText;
        private string eccLevel;
        
        public ErrorCorrectionLevel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            errorCorrectionText = "Error Correction Level:";

            errorItemHText = "Level H";
            errorItemLText = "Level L";
            errorItemMText = "Level M";
            errorItemQText = "Level Q";

            errorButtonText = errorItemMText;
            eccLevel = "M";
        }

        //Getters Text
        public string GetErrorCorrectionText()
        {
            return errorCorrectionText;
        }
        public string GetErrorButtonText()
        {
            return errorButtonText;
        }
        public string GetErrorItemLText()
        {
            return errorItemLText;
        }
        public string GetErrorItemMText()
        {
            return errorItemMText;
        }
        public string GetErrorItemQText()
        {
            return errorItemQText;
        }
        public string GetErrorItemHText()
        {
            return errorItemHText;
        }
        //Getters EccLevel
        public string GetEccLevel()
        {
            return eccLevel;
        }
        public string GetEccLevelL()
        {
            eccLevel = "L";
            return eccLevel;
        }
        public string GetEccLevelM()
        {
            eccLevel = "M";
            return eccLevel;
        }
        public string GetEccLevelQ()
        {
            eccLevel = "Q";
            return eccLevel;
        }
        public string GetEccLevelH()
        {
            eccLevel = "H";
            return eccLevel;
        }

    }
}
