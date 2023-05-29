using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    /// <summary>
    /// This abstract class inherits from AlgorithmModel and defines the abstract method
    /// "GenerateKey" for its children classes.
    /// </summary>
    internal abstract class SymmetricModel : AlgorithmModel
    {

        /// <summary>
        /// This is a template method that receives parameter "keySize" and "password"
        /// and generates a key according to the script implemented in the child class.
        /// </summary>
        /// <param name="keySize">This parameter will be defined by the select item of 
        /// keySizeComboBox.</param>
        /// <param name="password">This parameter will be defined by the text of 
        /// passwordTextBox.</param>
        /// <returns>Returns the generated key.</returns>
        public abstract string GenerateKey(int keySize, string password);
    }
}
