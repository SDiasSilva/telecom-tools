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
    ///  the content of the Elementary File "SUME".
    /// </summary>
    internal class SetUpMenuElementsController : EfController
    {
        private readonly SetUpMenuElements sume;


        /// <summary>
        /// This constructor will initialize the field "sume" using the parameters "iconQualifier" and
        /// "iconIdentifier".
        /// </summary>
        /// <param name="iconQualifier">This parameter will be defined by the selected index of 
        /// SUMEIconQualifierComboBox.</param>
        /// <param name="iconIdentifier">This parameter will be defined by the selected number of
        /// SUMEIconNumericUpDown.</param>
        public SetUpMenuElementsController(int iconQualifier, decimal iconIdentifier)
        {
            sume = new SetUpMenuElements(iconQualifier, iconIdentifier);
        }

        /// <summary>
        /// This method will generate the content of EFSPN using the parameter "serviceProviderName".
        /// </summary>
        /// <param name="menuTitle">This is the input (Max Length: 16) used to generate the 
        /// EFSPN's content.</param>
        /// <returns>Returns a hexstring with length of 30 bytes e.g 
        /// 05 ?? XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX 1E 02 0! YY FF FF FF FF FF FF FF FF:
        /// <para>
        /// ?? - menuTitle's length;
        /// </para>
        /// <para>
        /// XX - menuTitle's hexstring.
        /// </para>
        /// <para>
        /// 1E 02 0! - If icon the icon qualifier is self-explanatory or not (0-1)
        /// </para>
        /// <para>
        /// YY - Icon Identifier value (0x00 - 0xFF)
        /// </para>
        /// </returns>
        public override string GenerateEf(string menuTitle)
        {
            byte[] menuTitleByteArray = ByteUtil.GetBytes(menuTitle);
            byte[] sumeByteArray = CreateByteArrayFilledWith0xFF(sume.Length);
            sumeByteArray[0] = 0x05;
            sumeByteArray[1] = (byte)menuTitle.Length;
            Array.Copy(menuTitleByteArray, 0, sumeByteArray, 2, menuTitle.Length);
            int IconQualifierIndex = ByteUtil.GetIndexSearchedItem(menuTitleByteArray, sumeByteArray) + menuTitle.Length;
            int IconIdentifierIndex = IconQualifierIndex + sume.ICON_QUALIFIER_LENGTH;
            sumeByteArray[IconIdentifierIndex] = sume.IconIdentifier;
            switch (sume.IconQualifier)
            {
                case 0:
                    Array.Copy(sume.ICON_QUALIFIER["Self-explanatory"], 0, sumeByteArray, IconQualifierIndex, sume.ICON_QUALIFIER_LENGTH);
                    break;
                case 1:
                    Array.Copy(sume.ICON_QUALIFIER["Not self-explanatory"], 0, sumeByteArray, IconQualifierIndex, sume.ICON_QUALIFIER_LENGTH);
                    break;
                case 2:
                    Array.Copy(sume.ICON_QUALIFIER["Not present"], 0, sumeByteArray, IconIdentifierIndex, 1);
                    break;
                default:
                    break;
            }
            return BitConverter.ToString(sumeByteArray).Replace("-", " ");
        }
    }
}