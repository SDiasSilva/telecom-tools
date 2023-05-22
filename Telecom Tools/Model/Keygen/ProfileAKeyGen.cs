using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;

namespace Telecom_Tools.Model.Keygen.Asymmetric
{
    internal class ProfileAKeyGen : AsymmetricModel
    {
        public ProfileAKeyGen()
        {
            algorithmName = "Profile A (Curve 25519)";
            keySizes = new object[] 
            {
                "256 bits"
            };
        }

        public override List<string> GenerateKeyPair(int keySize)
        {
            X25519PrivateKeyParameters privateKey = new(new SecureRandom());
            X25519PublicKeyParameters publicKey = privateKey.GeneratePublicKey();
            List<string> keyPair = new();
            keyPair.Add(ExportKeyAsHexString(privateKey.GetEncoded()));
            keyPair.Add(ExportKeyAsHexString(publicKey.GetEncoded()));
            return keyPair;
        }
        private static string ExportKeyAsHexString(byte[] encodedBytes)
        {
            return BitConverter.ToString(encodedBytes).Replace("-", string.Empty);
        }
    }
}
