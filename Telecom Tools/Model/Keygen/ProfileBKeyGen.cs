using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto;

namespace Telecom_Tools.Model.Keygen.Asymmetric
{
    internal class ProfileBKeyGen : AsymmetricModel
    {
        public ProfileBKeyGen()
        {
            algorithmName = "Profile B (Curve secp256r1)";
            keySizes = new object[] 
            {
                "256 bits"
            };
        }

        public override List<string> GenerateKeyPair(int keySize)
        {
            X9ECParameters curve = CustomNamedCurves.GetByName("secp256r1");
            var parameters = new ECKeyGenerationParameters(new ECDomainParameters(curve), new SecureRandom());
            var keyPairGenerator = new ECKeyPairGenerator("ECDH");
            keyPairGenerator.Init(parameters);
            AsymmetricCipherKeyPair ACKeyPair = keyPairGenerator.GenerateKeyPair();
            var privateKey = (ECPrivateKeyParameters)ACKeyPair.Private;
            var publicKey = (ECPublicKeyParameters)ACKeyPair.Public;
            List<string> keyPair = new();
            keyPair.Add(ExportKeyAsHexString(privateKey.D.ToByteArray()));
            keyPair.Add(ExportKeyAsHexString(GetCompressedPublicKey(publicKey)));
            return keyPair;
        }
        private static string ExportKeyAsHexString(byte[] encodedBytes)
        {
            return BitConverter.ToString(encodedBytes).Replace("-", string.Empty);
        }

        private static byte[] GetCompressedPublicKey(ECPublicKeyParameters publicKey)
        {
            byte[] encoded = publicKey.Q.GetEncoded();
            byte[] compressedKey = new byte[33];
            if((encoded[0] & 0x01) == 0) 
            {
                compressedKey[0] = 0x02;
            }
            else
            {
                compressedKey[0] = 0x03;
            }
            Array.Copy(encoded, 1, compressedKey, 1, 32);
            return compressedKey;
        }
    }
}
