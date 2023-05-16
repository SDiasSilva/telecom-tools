using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    internal class AESKeyGen : SymmetricModel
    {
        public AESKeyGen()
        {
            algorithmName = "AES";
            keySizes = new object[]
            {
                "128 bits",
                "192 bits",
                "256 bits"
            };
        }
    }
}
