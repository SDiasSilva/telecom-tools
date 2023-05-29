using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util.Hash
{
    /// <summary>
    /// This interface defines the method ComputeHash for any class that implements it.
    /// </summary> 
    internal interface IHashType
    {
        /// <summary>
        /// This method compute a hash of a plaintext.
        /// </summary>
        /// <param name="plaintext">This parameter will be used to compute the hash.</param>
        /// <returns>Returns the computed hash in bytes of a plaintext accordingly 
        /// with implemented algorithm.</returns>
        public string ComputeHash(string plaintext);
    }
}
