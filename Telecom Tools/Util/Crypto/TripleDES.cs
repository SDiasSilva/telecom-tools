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
    /// <summary>
    /// A class that implements the TripleDES encryption algorithm.
    /// </summary>
    internal class TripleDES
    {
        private readonly DesEngine engine;
        private BufferedBlockCipher cipher;
        private byte[] Key1 = new byte[8];
        private byte[] Key2 = new byte[8];
        private byte[] Key3 = new byte[8];

        /// <summary>
        /// Initializes a new instance of the TripleDES class with the specified TripleDES key.
        /// </summary>
        /// <param name="tripleDESKey">The TripleDES key.</param>
        public TripleDES(byte[] tripleDESKey)
        {
            engine = new DesEngine();
            cipher = new BufferedBlockCipher(engine);
            StartKeys(tripleDESKey);
        }

        private void StartKeys(byte[] Key)
        {
            // Initializes the key based on its length
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
                    throw new ArgumentException("Invalid length!");
            }
        }

        /// <summary>
        /// Encrypts the input byte array using the TripleDES algorithm with the specified key.
        /// </summary>
        /// <param name="plainBytes">The byte array to encrypt.</param>
        /// <param name="key">The encryption key.</param>
        /// <returns>The encrypted byte array.</returns>
        private byte[] EncryptBytes(byte[] plainBytes, byte[] key)
        {
            byte[] output;
            KeyParameter keyParameter = new(key);
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

        /// <summary>
        /// Decrypts the input byte array using the TripleDES algorithm with the specified key.
        /// </summary>
        /// <param name="encryptedBytes">The byte array to decrypt.</param>
        /// <param name="key">The decryption key.</param>
        /// <returns>The decrypted byte array.</returns>
        private byte[] DecryptBytes(byte[] encryptedBytes, byte[] key)
        {
            byte[] output;
            KeyParameter keyParameter = new (key);
            cipher.Init(false, keyParameter);
            output = cipher.DoFinal(encryptedBytes);
            return output;
        }

        /// <summary>
        /// Encrypts the input byte array using TripleDES encryption.
        /// </summary>
        /// <param name="input">The input byte array to encrypt.</param>
        /// <returns>The encrypted byte array represented as a hexadecimal string.</returns>
        public string Encrypt(byte[] input)
        {
            byte[] cipher = EncryptBytes(DecryptBytes(EncryptBytes(input, Key1), Key2), Key3);
            string output = BitConverter.ToString(cipher);
            return output.Replace("-", "");
        }

        /// <summary>
        /// Decrypts the input byte array using TripleDES decryption.
        /// </summary>
        /// <param name="input">The input byte array to decrypt.</param>
        /// <returns>The decrypted byte array represented as a hexadecimal string.</returns>
        public string Decrypt(byte[] input)
        {
            byte[] decipher = DecryptBytes(EncryptBytes(DecryptBytes(input, Key3), Key2), Key1);
            string output = BitConverter.ToString(decipher);
            return output.Replace("-", "");
        }
    }
}
