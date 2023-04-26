using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller.Ef
{
    internal class MenuTitleController : EfController
    {
        private readonly MenuTitle menuTitle;

        public MenuTitleController(int encoding)
        {
            menuTitle = new MenuTitle(encoding);
        }
        public override string GenerateEf(string mainMenuTitle)
        {
            byte[] menuTitleByteArray = CreateByteArrayFilledWith0xFF(menuTitle.Length);
            menuTitleByteArray[0] = 0x00;
            menuTitleByteArray[1] = 0x00;
            byte[] gsmEncoded = ByteUtil.GetBytes(mainMenuTitle); //GSM 03.38 Default
            switch (menuTitle.Encoding)
            {
                case 1: //GSM 11.11/1
                    gsmEncoded = GSMEncoder.EncodeGSM1111v1(mainMenuTitle);
                    break;
                case 2: //GSM 11.11/2
                    gsmEncoded = GSMEncoder.EncodeGSM1111v2(gsmEncoded);
                    break;
                case 3: //GSM 11.11/3
                    gsmEncoded = GSMEncoder.EncodeGSM1111v3(gsmEncoded);
                    break;
            }
            menuTitleByteArray[2] = (byte)gsmEncoded.Length;
            Array.Copy(gsmEncoded, 0, menuTitleByteArray, 3, gsmEncoded.Length);
            return BitConverter.ToString(menuTitleByteArray).Replace("-", " ");
        }
    }
}
