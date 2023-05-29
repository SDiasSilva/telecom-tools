using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util;

namespace Telecom_Tools.Model
{
    /// <summary>
    ///  This class stores the neccessary attributes to calculate the PSK/TLS Key.
    /// </summary>
    internal class PSK
    {
        public byte[] KM0 { get; set; } = new byte[16];
        public byte[] KM1 { get; set; } = new byte[16];
        public byte[] Data { get; set; } = new byte[8];

        /// <summary>
        /// This constructor will initialize the fields "KM0" and "KM1" spliting the parameter 
        /// "masterkey".
        /// </summary>
        /// <param name="masterKey">This parameter will be defined by the text of masterKeyTextBox.</param>
        public PSK(string masterKey)
        {
            KM0 = ByteUtil.HexStringToByteArray(masterKey);
            Array.Copy(KM0, 0, KM1, KM1.Length - 8, 8);
            Array.Copy(KM0, KM0.Length - 8, KM1, 0, 8);
        }
    }
}
