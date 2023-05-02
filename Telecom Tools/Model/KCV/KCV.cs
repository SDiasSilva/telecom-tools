using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.KCV
{
    internal abstract class KCV
    {
        protected readonly byte[] DATA = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public abstract string CalculateKCV(string key);
    }
}
