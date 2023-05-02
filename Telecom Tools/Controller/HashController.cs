using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util;
using Telecom_Tools.Util.Hash;

namespace Telecom_Tools.Controller
{
    internal class HashController
    {
        private readonly Dictionary<int, HashType> HASH_TYPE = new()
        {
            { 0, new SHA1Hash()}
        };

        public HashType SelectHashAlgorithm(int hashtype)
        {
            return HASH_TYPE[hashtype];
        }

    }
}
