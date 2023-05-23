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
                "8 bytes",
                "16 bytes",
                "24 bytes"
            };
        }

        public override string GenerateKey(int keySize, string password)
        {
            int bytesLength = keySize;
            byte[] key = new byte[bytesLength];
            if (!string.IsNullOrEmpty(password))
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] salt = new byte[8];
                using Rfc2898DeriveBytes keyGenerator = new(passwordBytes, salt, 1000);
                key = keyGenerator.GetBytes(bytesLength);
            }
            return BitConverter.ToString(key).Replace("-", String.Empty);
        }
    }
}
