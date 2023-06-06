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
    /// Utility class for AES encryption and decryption operations.
    /// </summary>
    internal class AES
    {
        private readonly AesEngine engine;
        private BufferedBlockCipher cipher;
        private readonly byte[] key;

        /// <summary>
        /// Initializes a new instance of the AES class with the specified AES key.
        /// </summary>
        /// <param name="AESKey">The AES encryption key.</param>
        public AES(byte[] AESKey)
        {
            engine = new AesEngine();
            cipher = new BufferedBlockCipher(engine);
            key = VerifyKey(AESKey);
        }

        /// <summary>
        /// Verifies and returns the provided key.
        /// Throws an ArgumentException if the key length is invalid.
        /// </summary>
        /// <param name="key">The key to verify.</param>
        /// <returns>The verified key.</returns>
        private static byte[] VerifyKey(byte[] key)
        {
            // Verifies and returns the provided key.
            // Throws an ArgumentException if the key length is invalid.
            return key.Length switch
            {
                16 or 24 or 32 => key,
                _ => throw new ArgumentException("Invalid key!"),
            };
        }

        /// <summary>
        /// Encrypts the provided byte array using AES encryption with the initialized key.
        /// </summary>
        /// <param name="plainBytes">The byte array to encrypt.</param>
        /// <returns>The encrypted text as a hexadecimal string.</returns>
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

        /// <summary>
        /// Decrypts the provided byte array using AES decryption with the initialized key.
        /// </summary>
        /// <param name="encryptedBytes">The byte array to decrypt.</param>
        /// <returns>The decrypted text as a hexadecimal string.</returns>
        public string Decrypt(byte[] encryptedBytes)
        {
            KeyParameter keyParameter = new (key);
            cipher.Init(false, keyParameter);
            _ = cipher.DoFinal(encryptedBytes);
            string plaintext = BitConverter.ToString(encryptedBytes).Replace("-", "");
            return plaintext;
        }
    }
}
