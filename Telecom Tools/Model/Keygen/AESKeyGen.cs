using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    /// <summary>
    /// This abstract class inherits from SymmetricModel and generates a key. 
    /// </summary>
    internal class AESKeyGen : SymmetricModel
    {

        /// <summary>
        /// this constructor initializes the fields of inherited class AlgorithmModel.
        /// </summary>
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

        /// <summary>
        /// This method receives the parameters "keySize" and "password"
        /// and generates a DES key deriving the password.
        /// </summary>
        /// <param name="keySize">This parameter will be defined by the select item of 
        /// keySizeComboBox.</param>
        /// <param name="password">This parameter will be defined by the text of 
        /// passwordTextBox and will be derivated key.</param>
        /// <returns>Returns the derivated DES key.</returns>
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
