using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    internal class ByteConverter
    {
        private static byte[] HexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace(" ", "").Replace("-", "");
            var numberChars = hexString.Length;
            var bytes = new byte[numberChars / 2];
            for (var i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            return bytes;
        }
        public static byte[] GetBytes(string plaintext)
        {
            string hexStringText = GSM7bitEncoder.Encode(plaintext);
            byte[] encoded = HexStringToByteArray(hexStringText);
            return encoded;
        }
        public static byte[] PackBlock(byte[] block)
        {
            long x = 0;
            for (int i = 0; i < block.Length; i += 1) x |= ((long)block[i]) << (7 * i);
            byte[] output = new byte[(block.Length * 7 + 7) / 8];
            for (int i = 0; i < output.Length; i += 1) output[i] = (byte)(x >> (8 * i));
            return output;
        }
        public static byte[] PackInfo(byte[] info)
        {
            byte[] firstBlock;
            byte[] lastBlock;
            if (info.Length <= 8)
            {
                firstBlock = PackBlock(info);
                return firstBlock;
            }
            else
            {
                firstBlock = new byte[8];
                Array.Copy(info, 0, firstBlock, 0, firstBlock.Length);
                firstBlock = PackBlock(firstBlock);
                lastBlock = new byte[info.Length - 8];
                Array.Copy(info, 8, lastBlock, 0, lastBlock.Length);
                lastBlock = PackBlock(lastBlock);
                byte[] concat = new byte[firstBlock.Length + lastBlock.Length];
                Array.Copy(firstBlock, 0, concat, 0, firstBlock.Length);
                Array.Copy(lastBlock, 0, concat, firstBlock.Length, lastBlock.Length);
                return concat;
            }
        }
    }
}
