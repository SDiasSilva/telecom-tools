using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util;
using Telecom_Tools.Util.Hash;

namespace Telecom_Tools.Controller
{
    /// <summary>
    /// This class defines which Hashing Algorithm will be used.
    /// </summary> 
    internal class HashController
    {
        private readonly Dictionary<int, IHashType> HASH_TYPE = new()
        {
            { 0, new SHA1Hash()}
        };

        /// <summary>
        /// This method returns the HashType selected by the user.
        /// </summary>
        /// <param name="hashtype">This parameter will be defined by the select index of hashTypeComboBox.</param>
        /// <returns>Returns the selected HashType that will define which hashing algorithm will be used.</returns>
        public IHashType SelectHashAlgorithm(int hashtype)
        {
            return HASH_TYPE[hashtype];
        }

    }
}
