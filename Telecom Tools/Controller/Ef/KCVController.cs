using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.KCV;

namespace Telecom_Tools.Controller.Ef
{
    internal class KCVController
    {
        public readonly Dictionary<int, KCV> CRYPTO_TYPE = new()
        {
            {0, new DESKCV()},
            {1, new AESKCV()}
        };

        public KCV SelectCryptoType(int cryptoType)
        {
            return CRYPTO_TYPE[cryptoType];
        }
    }
}
