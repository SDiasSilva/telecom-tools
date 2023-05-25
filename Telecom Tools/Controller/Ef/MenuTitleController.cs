using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller.Ef
{
    /// <summary>
    ///  This class inherits from EfController and overrides the GenerateEF method to generate
    ///  the content of the Elementary File "Menu Title".
    /// </summary>
    internal class MenuTitleController : EfController
    {
        private readonly MenuTitle menuTitle;

        /// <summary>
        /// This constructor will initialize the field "menuTitle" using the parameter "encoding".
        /// </summary>
        /// <param name="encoding">This parameter will be defined by the selected index of
        /// MenuTitleEncodingComboBox.</param>
        public MenuTitleController(int encoding)
        {
            menuTitle = new MenuTitle(encoding);
        }

        /// <summary>
        /// This method will generate the content of EFMenuTitle using the parameter "mainMenuTitle"
        /// and the selected encoding by the user.
        /// </summary>
        /// <param name="mainMenuTitle">This is the input (Max Length: 7-16 depending on the chosen encoding)
        /// used to generate the EFMenuTitle's content.</param>
        /// <returns>Returns a hexstring with length of 19 bytes e.g 
        /// 00 00 ?? XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX:
        /// <para>
        /// ?? - mainMenuTitle's length;
        /// </para>
        /// <para>
        /// XX - mainMenuTitle's hexstring.
        /// </para></returns>
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
