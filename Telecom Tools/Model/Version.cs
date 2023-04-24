using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model
{
    internal class Version
    {

        String[] versions = new string[40];

        private string versionItem0Text;
        private string versionItem1Text;
        private string versionItem2Text;
        private string versionItem3Text;
        private string versionItem4Text;
        private string versionItem5Text;
        private string versionItem6Text;
        private string versionItem7Text;
        private string versionItem8Text;
        private string versionItem9Text;
        private string versionItem10Text;
        private string versionItem11Text;
        private string versionItem12Text;
        private string versionItem13Text;
        private string versionItem14Text;
        private string versionItem15Text;
        private string versionItem16Text;
        private string versionItem17Text;
        private string versionItem18Text;
        private string versionItem19Text;
        private string versionItem20Text;
        private string versionItem21Text;
        private string versionItem22Text;
        private string versionItem23Text;
        private string versionItem24Text;
        private string versionItem25Text;
        private string versionItem26Text;
        private string versionItem27Text;
        private string versionItem28Text;
        private string versionItem29Text;
        private string versionItem30Text;
        private string versionItem31Text;
        private string versionItem32Text;
        private string versionItem33Text;
        private string versionItem34Text;
        private string versionItem35Text;
        private string versionItem36Text;
        private string versionItem37Text;
        private string versionItem38Text;
        private string versionItem39Text;
        private string versionItem40Text;

        private string versionText;
        private string versionButtonText;
        private int versionNumber;

        public Version()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            GetAllNames();
            versionText = "Version:";

            versionItem0Text = "Auto - 0";
            versionButtonText = versionItem0Text;
            versionNumber = -1;
        }

        private String[] CreateArray()
        {
            for (int i = 0; i < 40; i++)
            {
                versions[i] = (21 + (i * 4)) + " x " + (21 + (i * 4)) + " - " + (i + 1);
            }

            return versions;
        }
        private void GetAllNames()
        {
            CreateArray();

            versionItem1Text = versions[0];
            versionItem2Text = versions[1];
            versionItem3Text = versions[2];
            versionItem4Text = versions[3];

            versionItem5Text = versions[4];
            versionItem6Text = versions[5];
            versionItem7Text = versions[6];
            versionItem8Text = versions[7];

            versionItem9Text = versions[8];
            versionItem10Text = versions[9];
            versionItem11Text = versions[10];
            versionItem12Text = versions[11];

            versionItem13Text = versions[12];
            versionItem14Text = versions[13];
            versionItem15Text = versions[14];
            versionItem16Text = versions[15];

            versionItem17Text = versions[16];
            versionItem18Text = versions[17];
            versionItem19Text = versions[18];
            versionItem20Text = versions[19];

            versionItem21Text = versions[20];
            versionItem22Text = versions[21];
            versionItem23Text = versions[22];
            versionItem24Text = versions[23];

            versionItem25Text = versions[24];
            versionItem26Text = versions[25];
            versionItem27Text = versions[26];
            versionItem28Text = versions[27];

            versionItem29Text = versions[28];
            versionItem30Text = versions[29];
            versionItem31Text = versions[30];
            versionItem32Text = versions[31];

            versionItem33Text = versions[32];
            versionItem34Text = versions[33];
            versionItem35Text = versions[34];
            versionItem36Text = versions[35];

            versionItem37Text = versions[36];
            versionItem38Text = versions[37];
            versionItem39Text = versions[38];
            versionItem40Text = versions[39];
        }

        //Getters text
        public string GetVersionText()
        {
            return versionText;
        }
        public string GetVersionButtonText()
        {
            return versionButtonText;
        }
        public int GetVersionNumber()
        {
            return versionNumber;
        }

        //0
        public string GetItem0Text()
        {
            return versionItem0Text;
        }
        //1-4
        public string GetItem1Text()
        {
            return versionItem1Text;
        }
        public string GetItem2Text()
        {
            return versionItem2Text;
        }
        public string GetItem3Text()
        {
            return versionItem3Text;
        }
        public string GetItem4Text()
        {
            return versionItem4Text;
        }

        //5-8
        public string GetItem5Text()
        {
            return versionItem5Text;
        }
        public string GetItem6Text()
        {
            return versionItem6Text;
        }
        public string GetItem7Text()
        {
            return versionItem7Text;
        }
        public string GetItem8Text()
        {
            return versionItem8Text;
        }

        //9-12
        public string GetItem9Text()
        {
            return versionItem9Text;
        }
        public string GetItem10Text()
        {
            return versionItem10Text;
        }
        public string GetItem11Text()
        {
            return versionItem11Text;
        }
        public string GetItem12Text()
        {
            return versionItem12Text;
        }

        //13-16
        public string GetItem13Text()
        {
            return versionItem13Text;
        }
        public string GetItem14Text()
        {
            return versionItem14Text;
        }
        public string GetItem15Text()
        {
            return versionItem15Text;
        }
        public string GetItem16Text()
        {
            return versionItem16Text;
        }

        //17-20
        public string GetItem17Text()
        {
            return versionItem17Text;
        }
        public string GetItem18Text()
        {
            return versionItem18Text;
        }
        public string GetItem19Text()
        {
            return versionItem19Text;
        }
        public string GetItem20Text()
        {
            return versionItem20Text;
        }

        //21-24
        public string GetItem21Text()
        {
            return versionItem21Text;
        }
        public string GetItem22Text()
        {
            return versionItem22Text;
        }
        public string GetItem23Text()
        {
            return versionItem23Text;
        }
        public string GetItem24Text()
        {
            return versionItem24Text;
        }

        //25-28
        public string GetItem25Text()
        {
            return versionItem25Text;
        }
        public string GetItem26Text()
        {
            return versionItem26Text;
        }
        public string GetItem27Text()
        {
            return versionItem27Text;
        }
        public string GetItem28Text()
        {
            return versionItem28Text;
        }

        //29-32
        public string GetItem29Text()
        {
            return versionItem29Text;
        }
        public string GetItem30Text()
        {
            return versionItem30Text;
        }
        public string GetItem31Text()
        {
            return versionItem31Text;
        }
        public string GetItem32Text()
        {
            return versionItem32Text;
        }

        //33-36

        public string GetItem33Text()
        {
            return versionItem33Text;
        }
        public string GetItem34Text()
        {
            return versionItem34Text;
        }
        public string GetItem35Text()
        {
            return versionItem35Text;
        }
        public string GetItem36Text()
        {
            return versionItem36Text;
        }

        //37-40
        public string GetItem37Text()
        {
            return versionItem37Text;
        }
        public string GetItem38Text()
        {
            return versionItem38Text;
        }
        public string GetItem39Text()
        {
            return versionItem39Text;
        }
        public string GetItem40Text()
        {
            return versionItem40Text;
        }

        //Getters VersionNumber

        public int GetVersionNumber0()
        {
            versionNumber = -1;
            return versionNumber;
        }

        //1-4
        public int GetVersionNumber1()
        {
            versionNumber = 1;
            return versionNumber;
        }
        public int GetVersionNumber2()
        {
            versionNumber = 2;
            return versionNumber;
        }
        public int GetVersionNumber3()
        {
            versionNumber = 3;
            return versionNumber;
        }
        public int GetVersionNumber4()
        {
            versionNumber = 4;
            return versionNumber;
        }

        //5-8
        public int GetVersionNumber5()
        {
            versionNumber = 5;
            return versionNumber;
        }
        public int GetVersionNumber6()
        {
            versionNumber = 6;
            return versionNumber;
        }
        public int GetVersionNumber7()
        {
            versionNumber = 7;
            return versionNumber;
        }
        public int GetVersionNumber8()
        {
            versionNumber = 8;
            return versionNumber;
        }

        //9-12
        public int GetVersionNumber9()
        {
            versionNumber = 9;
            return versionNumber;
        }
        public int GetVersionNumber10()
        {
            versionNumber = 10;
            return versionNumber;
        }
        public int GetVersionNumber11()
        {
            versionNumber = 11;
            return versionNumber;
        }
        public int GetVersionNumber12()
        {
            versionNumber = 12;
            return versionNumber;
        }

        //13-16
        public int GetVersionNumber13()
        {
            versionNumber = 13;
            return versionNumber;
        }
        public int GetVersionNumber14()
        {
            versionNumber = 14;
            return versionNumber;
        }
        public int GetVersionNumber15()
        {
            versionNumber = 15;
            return versionNumber;
        }
        public int GetVersionNumber16()
        {
            versionNumber = 16;
            return versionNumber;
        }

        //17-20
        public int GetVersionNumber17()
        {
            versionNumber = 17;
            return versionNumber;
        }
        public int GetVersionNumber18()
        {
            versionNumber = 18;
            return versionNumber;
        }
        public int GetVersionNumber19()
        {
            versionNumber = 19;
            return versionNumber;
        }
        public int GetVersionNumber20()
        {
            versionNumber = 20;
            return versionNumber;
        }

        //21-24
        public int GetVersionNumber21()
        {
            versionNumber = 21;
            return versionNumber;
        }
        public int GetVersionNumber22()
        {
            versionNumber = 22;
            return versionNumber;
        }
        public int GetVersionNumber23()
        {
            versionNumber = 23;
            return versionNumber;
        }
        public int GetVersionNumber24()
        {
            versionNumber = 24;
            return versionNumber;
        }

        //25-28
        public int GetVersionNumber25()
        {
            versionNumber = 25;
            return versionNumber;
        }
        public int GetVersionNumber26()
        {
            versionNumber = 26;
            return versionNumber;
        }
        public int GetVersionNumber27()
        {
            versionNumber = 27;
            return versionNumber;
        }
        public int GetVersionNumber28()
        {
            versionNumber = 28;
            return versionNumber;
        }

        //29-32
        public int GetVersionNumber29()
        {
            versionNumber = 29;
            return versionNumber;
        }
        public int GetVersionNumber30()
        {
            versionNumber = 30;
            return versionNumber;
        }
        public int GetVersionNumber31()
        {
            versionNumber = 31;
            return versionNumber;
        }
        public int GetVersionNumber32()
        {
            versionNumber = 32;
            return versionNumber;
        }

        //33-36
        public int GetVersionNumber33()
        {
            versionNumber = 33;
            return versionNumber;
        }
        public int GetVersionNumber34()
        {
            versionNumber = 34;
            return versionNumber;
        }
        public int GetVersionNumber35()
        {
            versionNumber = 35;
            return versionNumber;
        }
        public int GetVersionNumber36()
        {
            versionNumber = 36;
            return versionNumber;
        }

        //37-40
        public int GetVersionNumber37()
        {
            versionNumber = 37;
            return versionNumber;
        }
        public int GetVersionNumber38()
        {
            versionNumber = 38;
            return versionNumber;
        }
        public int GetVersionNumber39()
        {
            versionNumber = 39;
            return versionNumber;
        }
        public int GetVersionNumber40()
        {
            versionNumber = 40;
            return versionNumber;
        }

    }
}
