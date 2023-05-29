using EFDatagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    /// <summary>
    /// This is a utility class for manipulating byte arrays.
    /// </summary>
    internal static class ByteUtil
    {
        /// <summary>
        /// This method converts a hexadecimal string to a byte array.
        /// </summary>
        /// <param name="hexString">This is the parameter that will be converted into a 
        /// byte array.</param>
        /// <returns>Returns a byte array</returns>
        public static byte[] HexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace(" ", "").Replace("-", "");
            var numberChars = hexString.Length;
            var bytes = new byte[numberChars / 2];
            for (var i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            return bytes;
        }

        /// <summary>
        /// This method encodes a string using the GSM 7-bit encoding scheme and returns the result as a byte array.
        /// </summary>
        /// <param name="plaintext">This is the parameter that will be converted into a 
        /// byte array using GSM 7-bit encoding scheme.</param>
        /// <returns>Returns a byte array</returns>
        public static byte[] GetBytes(string plaintext)
        {
            string hexStringText = GSMEncoder.Encode(plaintext);
            byte[] encoded = HexStringToByteArray(hexStringText);
            return encoded;
        }

        /// <summary>
        /// This method packs a block of 1-8 bytes into a compact format using the 7-bit encoding scheme
        /// to save space.
        /// </summary>
        /// <param name="block">This is the byte array that will be packed.</param>
        /// <returns>Returns a packed block.</returns>
        public static byte[] PackBlock(byte[] block)
        {
            long x = 0;
            for (int i = 0; i < block.Length; i += 1) x |= ((long)block[i]) << (7 * i);
            byte[] output = new byte[(block.Length * 7 + 7) / 8];
            for (int i = 0; i < output.Length; i += 1) output[i] = (byte)(x >> (8 * i));
            return output;
        }

        /// <summary>
        /// This method packs a byte array into a compact format using a 7-bit encoding scheme.
        /// If the input array is longer than 8 bytes, it will split it into two blocks and each block is 
        /// packed separately.
        /// </summary>
        /// <param name="info">This is the info that will be packed.</param>
        /// <returns>Returns the packed info.</returns>
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

        /// <summary>
        /// Given a byte array "needle" and a byte array "source",
        /// searches for the first occurrence of "needle" in "source"
        /// using the Boyer-Moore algorithm and returns the index
        /// of the found item. If "needle" is not found, returns -1.
        /// </summary>
        /// <param name="needle">This is the block of bytes that needs to be found in a source
        /// a byte array.</param>
        /// <param name="source">This is the source byte array that will be searched through.</param>
        /// <returns>Returns the index of the found needle in the source if found.</returns>
        public static int GetIndexSearchedItem(byte[] needle, byte[] source)
        {
            int itemIndex = -1;
            BoyerMoore Searcher = new (needle);
            foreach (int index in Searcher.Search(source))
            {
                itemIndex = index;
                break;
            }
            return itemIndex;
        }
    }
}
