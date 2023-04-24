using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model
{
    internal class ModuleWidth
    {

        private string moduleText;

        private string moduleItem1Text;
        private string moduleItem2Text;
        private string moduleItem3Text;
        private string moduleItem4Text;

        private string moduleButtonText;
        private int moduleWidth;

        public ModuleWidth()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            moduleText = "Module Width (in pixels):";

            moduleItem1Text = "1";
            moduleItem2Text = "2";
            moduleItem3Text = "3";
            moduleItem4Text = "4";

            moduleButtonText = moduleItem4Text;
            moduleWidth = 4;
        }

        //Getters Text
        public string GetModuleText()
        {
            return moduleText;
        }
        public string GetModuleButtonText()
        {
            return moduleButtonText;
        }
        public string GetItem1Text()
        {
            return moduleItem1Text;
        }
        public string GetItem2Text()
        {
            return moduleItem2Text;
        }
        public string GetItem3Text()
        {
            return moduleItem3Text;
        }
        public string GetItem4Text()
        {
            return moduleItem4Text;
        }
        //Getters ModuleWidth
        public int GetModuleWidth()
        {
            return moduleWidth;
        }

        public int GetModuleWidth1()
        {
            moduleWidth = 1;
            return moduleWidth;
        }
        public int GetModuleWidth2()
        {
            moduleWidth = 2;
            return moduleWidth;
        }
        public int GetModuleWidth3()
        {
            moduleWidth = 3;
            return moduleWidth;
        }
        public int GetModuleWidth4()
        {
            moduleWidth = 4;
            return moduleWidth;
        }

    }
}
