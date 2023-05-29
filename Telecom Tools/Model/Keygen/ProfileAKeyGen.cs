using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;

namespace Telecom_Tools.Model.Keygen.Asymmetric
{
    /// <summary>
    /// This abstract class inherits from AsymmetricModel and generates aa Profile A key pair. 
    /// </summary>
    internal class ProfileAKeyGen : AsymmetricModel
    {

        /// <summary>
        /// this constructor initializes the fields of inherited class AlgorithmModel.
        /// </summary>
        public ProfileAKeyGen()
        {
            algorithmName = "Profile A (Curve 25519)";
            keySizes = new object[] 
            {
                "256 bits"
            };
        }

        /// <summary>
        /// This method that receives parameter "keySize"
        /// and generates an Profile A (Curve 25519) key pair.
        /// </summary>
        /// <param name="keySize">This parameter will be defined by the select item of 
        /// keySizeComboBox.</param>
        /// <returns>Returns a generated Profile A key pair.</returns>
        public override List<string> GenerateKeyPair(int keySize)
        {
            X25519PrivateKeyParameters privateKey = new(new SecureRandom());
            X25519PublicKeyParameters publicKey = privateKey.GeneratePublicKey();
            List<string> keyPair = new();
            keyPair.Add(ExportKeyAsHexString(privateKey.GetEncoded()));
            keyPair.Add(ExportKeyAsHexString(publicKey.GetEncoded()));
            return keyPair;
        }

        /// <summary>
        /// This method receives a byte array and returns it as a hexstring.
        /// </summary>
        /// <param name="encodedBytes">This parameter it is the byte array that will
        /// be converted in a hexstring.</param>
        /// <returns>Returns a hexstring.</returns>
        private static string ExportKeyAsHexString(byte[] encodedBytes)
        {
            return BitConverter.ToString(encodedBytes).Replace("-", string.Empty);
        }
    }
}
