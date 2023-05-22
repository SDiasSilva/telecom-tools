using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public override string GenerateKey(int keySize, string password)
        {
            int bytesLength = keySize / 8;
            byte[] key = new byte[bytesLength];
            if (!string.IsNullOrEmpty(password))
            {
                byte[] salt = new byte[8];
                using Rfc2898DeriveBytes keyGenerator = new(password, salt, 2000, HashAlgorithmName.SHA1);
                key = keyGenerator.GetBytes(keySize / 8);
            }

            return BitConverter.ToString(key).Replace("-", string.Empty);
        }
    }
}
