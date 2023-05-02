using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util;

namespace Telecom_Tools.Model.KCV
{
    internal class DESKCV : KCV
    {
        public override string CalculateKCV(string key)
        {
            byte[] keyByteArray = ByteUtil.HexStringToByteArray(key);
            TripleDES encryptor = new TripleDES(keyByteArray);
            return encryptor.Encrypt(DATA).Substring(0, 6);
        }
    }
}
