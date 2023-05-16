using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    internal abstract class SymmetricModel : AlgorithmModel, ISymmetricModel
    {
        public string GenerateKey(int keySize)
        {
            byte[] key = new byte[keySize / 8];
            RandomNumberGenerator.Fill(key);
            return BitConverter.ToString(key).Replace("-", " ");
        }
    }
}
