using EFDatagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    // This is a utility class for manipulating byte arrays.
    internal class ByteUtil
    {
        // This method converts a hexadecimal string to a byte array.
        private static byte[] HexStringToByteArray(string hexString)
        {
            // Remove any spaces or dashes in the input string.
            hexString = hexString.Replace(" ", "").Replace("-", "");
            var numberChars = hexString.Length;
            var bytes = new byte[numberChars / 2];
            for (var i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            return bytes;
        }

        // This method encodes a string using the GSM 7-bit encoding scheme and returns the result as a byte array.
        public static byte[] GetBytes(string plaintext)
        {
            // Encode the plaintext using GSMEncoder
            string hexStringText = GSMEncoder.Encode(plaintext);
            byte[] encoded = HexStringToByteArray(hexStringText);
            return encoded;
        }
        // This method packs a block of bytes into a compact format using a 7-bit encoding scheme.
        public static byte[] PackBlock(byte[] block)
        {
            long x = 0;
            // Pack the bytes using a bitwise OR operation.
            for (int i = 0; i < block.Length; i += 1) x |= ((long)block[i]) << (7 * i);
            byte[] output = new byte[(block.Length * 7 + 7) / 8];
            // Pack the resulting long into an array of bytes.
            for (int i = 0; i < output.Length; i += 1) output[i] = (byte)(x >> (8 * i));
            return output;
        }
        // This method packs a byte array into a compact format using a 7-bit encoding scheme.
        // If the input array is longer than 8 bytes, it is split into two blocks and each block is packed separately.
        public static byte[] PackInfo(byte[] info)
        {
            byte[] firstBlock;
            byte[] lastBlock;
            if (info.Length <= 8)
            {
                // If the input array is less than or equal to 8 bytes, pack it into a single block using the PackBlock method.
                firstBlock = PackBlock(info);
                return firstBlock;
            }
            else
            {
                // If the input array is longer than 8 bytes, split it into two blocks and pack each block separately.
                firstBlock = new byte[8];
                Array.Copy(info, 0, firstBlock, 0, firstBlock.Length);
                firstBlock = PackBlock(firstBlock);
                lastBlock = new byte[info.Length - 8];
                Array.Copy(info, 8, lastBlock, 0, lastBlock.Length);
                lastBlock = PackBlock(lastBlock);
                // Concatenate the two packed blocks into a single byte array.
                byte[] concat = new byte[firstBlock.Length + lastBlock.Length];
                Array.Copy(firstBlock, 0, concat, 0, firstBlock.Length);
                Array.Copy(lastBlock, 0, concat, firstBlock.Length, lastBlock.Length);
                return concat;
            }
        }
        /* Given a byte array `needle` and a byte array `source`,
        searches for the first occurrence of `needle` in `source`
        using the Boyer-Moore algorithm and returns the index
        of the found item. If `needle` is not found, returns -1.*/
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
