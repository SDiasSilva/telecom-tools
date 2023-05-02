using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util.Crypto
{
    internal class AES
    {
        private readonly AesEngine engine;
        private BufferedBlockCipher cipher;
        private byte[] key;

        public AES(byte[] AESKey)
        {
            engine = new AesEngine();
            cipher = new BufferedBlockCipher(engine);
            key = verifyKey(AESKey);
        }

        private byte[] verifyKey(byte[] key)
        {
            switch (key.Length)
            {
                case 16:
                case 24:
                case 32:
                    return key;
                default:
                    throw new ArgumentException();
            }
        }

        public string Encrypt(byte[] plainBytes)
        {
            byte[] encryptedBytes;
            KeyParameter keyParameter = new(key);
            cipher.Init(true, keyParameter);
            try
            {
                encryptedBytes = cipher.DoFinal(plainBytes);
            }
            catch (DataLengthException)
            {
                cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), new ZeroBytePadding());
                cipher.Init(true, keyParameter);
                encryptedBytes = cipher.DoFinal(plainBytes);
            }
            string encryptedText = BitConverter.ToString(encryptedBytes).Replace("-", "");
            return encryptedText;
        }
        public string Decrypt(byte[] encryptedBytes)
        {
            byte[] output;
            KeyParameter keyParameter = new (key);
            cipher.Init(false, keyParameter);
            output = cipher.DoFinal(encryptedBytes);
            string plaintext = BitConverter.ToString(encryptedBytes).Replace("-", "");
            return plaintext;
        }
    }
}
