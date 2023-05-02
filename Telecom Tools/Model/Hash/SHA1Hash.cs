using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util.Hash;

namespace Telecom_Tools.Util
{
    internal class SHA1Hash : HashType
    {
        private SHA1 sha1;

        public SHA1Hash()
        {
            sha1 = SHA1.Create();
        }

        public string ComputeHash(string plaintext)
        {
            return Convert.ToHexString(sha1.ComputeHash(Encoding.UTF8.GetBytes(plaintext)));
        }
    }
}
