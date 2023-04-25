﻿using System;
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
        private SetUpMenuElements sume;
        private int iconQualifier;
        private byte iconIdentifier;

        public SetUpMenuElementsController()
        {
            sume = new SetUpMenuElements();
        }

        public void SetIconProperties(int iconQualifier, decimal iconIdentifier)
        {
            this.iconQualifier = iconQualifier;
            this.iconIdentifier = (byte)iconIdentifier;
        }

        public override string GerarEf(string menuTitle)
        {
            byte[] menuTitleBArray = ByteConverter.GetBytes(menuTitle);
            byte[] sumeByteArray = new byte[sume.Length];
            FillByteArrayWith0xFF(sumeByteArray);
            sumeByteArray[0] = 0x05;
            sumeByteArray[1] = (byte)menuTitle.Length;
            Array.Copy(menuTitleBArray, 0, sumeByteArray, 2, menuTitle.Length);
            int IconQualifierIndex = GetIndexSearchedItem(menuTitleBArray, sumeByteArray) + menuTitle.Length;
            int IconIndex = IconQualifierIndex + sume.ICON_QUALIFIER_LENGTH;
            sumeByteArray[IconIndex] = iconIdentifier;
            switch (iconQualifier)
            {
                case 0:
                    Array.Copy(sume.ICON_QUALIFIER["Self-explanatory"], 0, sumeByteArray, IconQualifierIndex, sume.ICON_QUALIFIER_LENGTH);
                    break;
                case 1:
                    Array.Copy(sume.ICON_QUALIFIER["Not self-explanatory"], 0, sumeByteArray, IconQualifierIndex, sume.ICON_QUALIFIER_LENGTH);
                    break;
                default:
                    break;
            }
            return BitConverter.ToString(sumeByteArray).Replace("-", " ");
        }
    }
}