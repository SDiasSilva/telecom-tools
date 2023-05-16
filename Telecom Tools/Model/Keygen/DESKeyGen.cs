using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    internal class DESKeyGen : SymmetricModel
    {
        public DESKeyGen()
        {
            algorithmName = "DES";
            keySizes = new object[]
            {
                "64 bits",
                "128 bits",
                "192 bits"
            };
        }
    }
}
