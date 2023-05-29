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
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Telecom_Tools.Model.Keygen.Asymmetric
{
    /// <summary>
    /// This abstract class inherits from AsymmetricModel and generates an RSA key pair. 
    /// </summary>
    internal class RSAKeysGen : AsymmetricModel
    {

        /// <summary>
        /// this constructor initializes the fields of inherited class AlgorithmModel.
        /// </summary>
        public RSAKeysGen()
        {
            algorithmName = "RSA";
            keySizes = new object[] 
            {
                "512 bits",
                "1024 bits",
                "2048 bits",
                "3072 bits",
                "4096 bits"
            };
        }

        /// <summary>
        /// This method that receives parameter "keySize"
        /// and generates an RSA key pair.
        /// </summary>
        /// <param name="keySize">This parameter will be defined by the select item of 
        /// keySizeComboBox.</param>
        /// <returns>Returns a generated RSA key pair.</returns>
        public override List<string> GenerateKeyPair(int keySize)
        {
            RsaKeyPairGenerator generator = new ();
            KeyGenerationParameters keyGenParams;
            keyGenParams = new (new (), keySize);
            generator.Init(keyGenParams);
            AsymmetricCipherKeyPair ACKeyPair = generator.GenerateKeyPair();
            List<string> keyPair = new ();
            keyPair.Add(ExportKeyAsPemString(ACKeyPair.Private));
            keyPair.Add(ExportKeyAsPemString(ACKeyPair.Public));
            return keyPair;
        }

        /// <summary>
        /// this method that receives parameter an object of AsymmetricKeyParameter
        /// and returns its key PEM string.
        /// </summary>
        /// <param name="key">This parameter will be a Private or Public Key.</param>
        /// <returns>Returns a PEM string with key content.</returns>
        private static string ExportKeyAsPemString(AsymmetricKeyParameter key)
        {
            StringWriter writer = new ();
            PemWriter pemWriter = new (writer);
            pemWriter.WriteObject(key);
            pemWriter.Writer.Flush();
            /*byte[] bytes = Encoding.ASCII.GetBytes(writer.ToString()
                .Replace("-----BEGIN RSA PRIVATE KEY-----", "")
                .Replace("-----END RSA PRIVATE KEY-----", "")
                .Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "")
                .Replace("\n", "")
                );*/
            return writer.ToString();
        }
    }
}
