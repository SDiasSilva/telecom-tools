using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    /// <summary>
    /// This abstract class inherits from AlgorithmModel and defines the abstract method
    /// "GenerateKeyPair" for its children classes.
    /// </summary>
    internal abstract class AsymmetricModel : AlgorithmModel
    {

        /// <summary>
        /// This is a template method that receives parameter "keySize"
        /// and generates a key pair according to the script implemented in the child class.
        /// </summary>
        /// <param name="keySize">This parameter will be defined by the select item of 
        /// keySizeComboBox.</param>
        /// <returns>Returns the generated key pair.</returns>
        public abstract List<string> GenerateKeyPair(int keySize);
    }
}
