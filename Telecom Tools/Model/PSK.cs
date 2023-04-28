using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util;

namespace Telecom_Tools.Model
{
    internal class PSK
    {
        public byte[] KM0 { get; set; } = new byte[16];
        public byte[] KM1 { get; set; } = new byte[16];
        public byte[] Data { get; set; } = new byte[8];

        public PSK(string masterKey)
        {
            KM0 = ByteUtil.HexStringToByteArray(masterKey);
            Array.Copy(KM0, 0, KM1, KM1.Length - 8, 8);
            Array.Copy(KM0, KM0.Length - 8, KM1, 0, 8);
        }
    }
}
