using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller.Ef
{
    internal class SetUpMenuElementsController : EfController
    {
        private readonly SetUpMenuElements sume;


        public SetUpMenuElementsController(int iconQualifier, decimal iconIdentifier)
        {
            sume = new SetUpMenuElements(iconQualifier, iconIdentifier);
        }

        public override string GerarEf(string menuTitle)
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