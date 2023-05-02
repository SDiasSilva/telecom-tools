using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatagen
{
    /*
    The BoyerMoore class provides an implementation of the Boyer-Moore string search algorithm.
    The algorithm searches for a byte pattern (needle) in a byte array (haystack) and returns the 
    indices at which the pattern is found. 

    This implementation uses precomputed tables for the bad-character rule and the good-suffix rule.
    The MakeByteTable and MakeOffsetTable methods compute these tables.
    */
    internal class BoyerMoore
    {
        //Fields
        readonly byte[] needle;
        readonly int[] charTable;
        readonly int[] offsetTable;

        //Constructor
        public BoyerMoore(byte[] needle)
        {
            //Initialize fields
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
            // If the needle is empty, return an empty IEnumerable.
            if (needle.Length == 0)
                yield break;

            // Start searching from the end of the needle in the haystack.
            for (int i = needle.Length - 1; i < haystack.Length;)
            {
                int j;

                // Compare the needle to the haystack from right to left.
                for (j = needle.Length - 1; needle[j] == haystack[i]; --i, --j)
                {
                    // If j is 0, the needle was found, return the index and continue searching.
                    if (j != 0)
                        continue;

                    yield return i;
                    i += needle.Length - 1;
                    break;
                }

                i += Math.Max(offsetTable[needle.Length - 1 - j], charTable[haystack[i]]);
            }
        }
      
        //Helper Methods
        static int[] MakeByteTable(byte[] needle)
        {
            const int ALPHABET_SIZE = 256;
            int[] table = new int[ALPHABET_SIZE];

            for (int i = 0; i < table.Length; ++i)
                table[i] = needle.Length;

            for (int i = 0; i < needle.Length - 1; ++i)
                table[needle[i]] = needle.Length - 1 - i;

            return table;
        }

        static int[] MakeOffsetTable(byte[] needle)
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

        static bool IsPrefix(byte[] needle, int p)
        {
            for (int i = p, j = 0; i < needle.Length; ++i, ++j)
                if (needle[i] != needle[j])
                    return false;

            return true;
        }

        static int SuffixLength(byte[] needle, int p)
        {
            int len = 0;

            for (int i = p, j = needle.Length - 1; i >= 0 && needle[i] == needle[j]; --i, --j)
                ++len;

            return len;
        }
    }
}
