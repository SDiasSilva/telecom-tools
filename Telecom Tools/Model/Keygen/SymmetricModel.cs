using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    internal abstract class SymmetricModel : AlgorithmModel
    {
        public abstract string GenerateKey(int keySize, string password);
    }
}
