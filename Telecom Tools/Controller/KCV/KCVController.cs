using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.KCV;

namespace Telecom_Tools.Controller.Ef
{
    /// <summary>
    /// This class defines which KCV Algorithm will be used.
    /// </summary> 
    internal class KCVController
    {
        public readonly Dictionary<int, KCV> CRYPTO_TYPE = new()
        {
            {0, new DESKCV()},
            {1, new AESKCV()}
        };

        /// <summary>
        /// This method returns the KCV selected by the user.
        /// </summary>
        /// <param name="cryptoType">This parameter will be defined by the select index of cryptoTypeComboBox.</param>
        /// <returns>Returns the selected KCV that will define which KCV algorithm will be used.</returns>
        public KCV SelectCryptoType(int cryptoType)
        {
            return CRYPTO_TYPE[cryptoType];
        }
    }
}
