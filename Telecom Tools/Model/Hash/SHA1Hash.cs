using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util.Hash;

namespace Telecom_Tools.Util
{
    /// <summary>
    /// This class implements the interface HashType and computes a hash using SHA1 algorithm.
    /// </summary> 
    internal class SHA1Hash : IHashType
    {
        private readonly SHA1 sha1;

        /// <summary>
        /// This constructor will initialize the field "sha1".
        /// </summary>
        public SHA1Hash()
        {
            sha1 = SHA1.Create();
        }

        /// <summary>
        /// This method compute a hash of a plaintext using the algorithm SHA1.
        /// </summary>
        /// <param name="plaintext">This parameter will be defined by the text of plaintextTextBox
        /// and be used to compute the hash.</param>
        /// <returns>Returns the computed hash in bytes of a plaintext using the algorithm SHA1.</returns>
        public string ComputeHash(string plaintext)
        {
            return Convert.ToHexString(sha1.ComputeHash(Encoding.UTF8.GetBytes(plaintext)));
        }
    }
}
