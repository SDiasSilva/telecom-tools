using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

namespace Telecom_Tools.Model.Keygen.Asymmetric
{
    internal class RSAKeysGen : AsymmetricModel
    {
        public RSAKeysGen()
        {
            algorithmName = "RSA";
            keySizes = new object[] 
            {
                "1024 bits",
                "2048 bits",
                "3072 bits",
                "4096 bits"
            };
        }

        public override List<string> GenerateKeyPair(int keySize, string salt)
        {
            RsaKeyPairGenerator generator = new ();
            KeyGenerationParameters keyGenParams;
            if (salt != null)
            {
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
                SecureRandom random = new ();
                random.SetSeed(saltBytes);
                keyGenParams = new (random, keySize);
            }
            else
            {
                keyGenParams = new (new (), keySize);
            }

            generator.Init(keyGenParams);
            AsymmetricCipherKeyPair ACKeyPair = generator.GenerateKeyPair();
            List<string> keyPair = new ();
            keyPair.Add(ExportKeyAsPemString(ACKeyPair.Private));
            keyPair.Add(ExportKeyAsPemString(ACKeyPair.Public));
            return keyPair;
        }
        private static string ExportKeyAsPemString(AsymmetricKeyParameter key)
        {
            StringWriter writer = new ();
            PemWriter pemWriter = new (writer);
            pemWriter.WriteObject(key);
            pemWriter.Writer.Flush();
            byte[] bytes = Encoding.ASCII.GetBytes(writer.ToString()
                .Replace("-----BEGIN RSA PRIVATE KEY-----", "")
                .Replace("-----END RSA PRIVATE KEY-----", "")
                .Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "")
                .Replace("\n", "")
                );
            return BitConverter.ToString(bytes).Replace("-", " ");
        }
    }
}
