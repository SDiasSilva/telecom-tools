using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatagen
{
    /// <summary>
    /// The BoyerMoore class provides an implementation of the Boyer-Moore string search algorithm.
    /// The algorithm searches for a byte pattern(needle) in a byte array(haystack) and returns the
    /// indices at which the pattern is found.
    /// This implementation uses precomputed tables for the bad-character rule and the good-suffix rule.
    /// The MakeByteTable and MakeOffsetTable methods compute these tables.
    /// </summary>
    internal class BoyerMoore
    {

        readonly byte[] needle;
        readonly int[] charTable;
        readonly int[] offsetTable;

        /// <summary>
        /// This constructor will initialize all this class fields using the parameter 
        /// "needle".
        /// </summary>
        /// <param name="needle">This parameter is the byte pattern that need to be found.</param>
        public BoyerMoore(byte[] needle)
        {
            this.needle = needle;
            this.charTable = MakeByteTable(needle);
            this.offsetTable = MakeOffsetTable(needle);
        }

        /// <summary>
        /// Search for the needle in the haystack using the Boyer-Moore algorithm.
        /// </summary>
        /// <param name="haystack">The array of bytes to search in.</param>
        /// <returns>An IEnumerable with the indexes where the needle was found.</returns>
        public IEnumerable<int> Search(byte[] haystack)
        {
            if (needle.Length == 0)
                yield break;

            for (int i = needle.Length - 1; i < haystack.Length;)
            {
                int j;

                for (j = needle.Length - 1; needle[j] == haystack[i]; --i, --j)
                {
                    if (j != 0)
                        continue;

                    yield return i;
                    i += needle.Length - 1;
                    break;
                }

                i += Math.Max(offsetTable[needle.Length - 1 - j], charTable[haystack[i]]);
            }
        }

        /// <summary>
        /// Constructs and returns an integer array representing a byte table for string matching operations.
        /// </summary>
        /// <param name="needle">The pattern to be matched.</param>
        /// <returns>An integer array representing the constructed byte table.</returns>
        public static int[] MakeByteTable(byte[] needle)
        {
            const int ALPHABET_SIZE = 256;
            int[] table = new int[ALPHABET_SIZE];

            for (int i = 0; i < table.Length; ++i)
                table[i] = needle.Length;

            for (int i = 0; i < needle.Length - 1; ++i)
                table[needle[i]] = needle.Length - 1 - i;

            return table;
        }

        /// <summary>
        /// Constructs and returns an integer array representing an offset table for string matching operations.
        /// </summary>
        /// <param name="needle">The pattern to be matched.</param>
        /// <returns>An integer array representing the constructed offset table.</returns>
        public static int[] MakeOffsetTable(byte[] needle)
        {
            int[] table = new int[needle.Length];
            int lastPrefixPosition = needle.Length;

            for (int i = needle.Length - 1; i >= 0; --i)
            {
                if (IsPrefix(needle, i + 1))
                    lastPrefixPosition = i + 1;

                table[needle.Length - 1 - i] = lastPrefixPosition - i + needle.Length - 1;
            }

            for (int i = 0; i < needle.Length - 1; ++i)
            {
                int slen = SuffixLength(needle, i);
                table[slen] = needle.Length - 1 - i + slen;
            }

            return table;
        }

        /// <summary>
        /// Checks if the specified position in the byte array is a prefix of the needle.
        /// </summary>
        /// <param name="needle">The byte array to check.</param>
        /// <param name="p">The position to check.</param>
        /// <returns>True if the position is a prefix, otherwise false.</returns>
        public static bool IsPrefix(byte[] needle, int p)
        {
            for (int i = p, j = 0; i < needle.Length; ++i, ++j)
                if (needle[i] != needle[j])
                    return false;

            return true;
        }

        /// <summary>
        /// Calculates the length of the suffix starting at the specified position in the byte array.
        /// </summary>
        /// <param name="needle">The byte array to calculate the suffix length from.</param>
        /// <param name="p">The starting position of the suffix.</param>
        /// <returns>The length of the suffix.</returns>
        public static int SuffixLength(byte[] needle, int p)
        {
            int len = 0;

            for (int i = p, j = needle.Length - 1; i >= 0 && needle[i] == needle[j]; --i, --j)
                ++len;

            return len;
        }
    }
}
