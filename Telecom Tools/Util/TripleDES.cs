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

namespace Telecom_Tools.Util
{
    internal class TripleDES
    {
        private DesEngine engine;
        private BufferedBlockCipher cipher;
        private byte[] Key1 = new byte[8];
        private byte[] Key2 = new byte[8];
        private byte[] Key3 = new byte[8];

        public TripleDES(byte[] tripleDESKey)
        {
            engine = new DesEngine();
            cipher = new BufferedBlockCipher(engine);
            StartKeys(tripleDESKey);
        }

        private void StartKeys(byte[] Key)
        {
            switch (Key.Length)
            {
                case 8:
                    Key1 = Key;
                    Key2 = Key;
                    Key3 = Key;
                    break;
                case 16:
                    Array.Copy(Key, 0, Key1, 0, Key1.Length);
                    Array.Copy(Key, 8, Key2, 0, Key2.Length);
                    Key3 = Key1;
                    break;
                case 24:
                    Array.Copy(Key, 0, Key1, 0, Key1.Length);
                    Array.Copy(Key, 8, Key2, 0, Key2.Length);
                    Array.Copy(Key, 16, Key3, 0, Key3.Length);
                    break;
                default:
                    MessageBox.Show("Tamanho da chave Inválida!");
                    break;
            }
        }

        private byte[] EncryptBytes(byte[] plainBytes, byte[] key)
        {
            byte[] output;
            KeyParameter keyParameter = new KeyParameter(key);
            cipher.Init(true, keyParameter);
            try
            {
                output = cipher.DoFinal(plainBytes);
            }
            catch (DataLengthException)
            {
                cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), new ZeroBytePadding());
                cipher.Init(true, keyParameter);
                output = cipher.DoFinal(plainBytes);
            }
            return output;
        }
        private byte[] DecryptBytes(byte[] encryptedBytes, byte[] key)
        {
            byte[] output;
            KeyParameter keyParameter = new KeyParameter(key);
            cipher.Init(false, keyParameter);
            output = cipher.DoFinal(encryptedBytes);
            return output;
        }

        public string Encrypt(byte[] input)
        {
            byte[] cipher = EncryptBytes(DecryptBytes(EncryptBytes(input, Key1), Key2), Key3);
            string output = BitConverter.ToString(cipher);
            return output.Replace("-", "");
        }
        public string Decrypt(byte[] input)
        {
            byte[] decipher = DecryptBytes(EncryptBytes(DecryptBytes(input, Key3), Key2), Key1);
            string output = BitConverter.ToString(decipher);
            return output.Replace("-", "");
        }
    }
}
