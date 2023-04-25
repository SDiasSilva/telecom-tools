using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;

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

        public void SetIconProperties(int iconQualifier, int iconIdentifier)
        {
            this.iconQualifier = iconQualifier;
            this.iconIdentifier = (byte)iconIdentifier;
        }

        public override string GerarEf(string menuTitle)
        {
            return null;
        }
    }
}