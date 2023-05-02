using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util.Crypto;
using Telecom_Tools.Util;

namespace Telecom_Tools.Model.KCV
{
    internal class AESKCV : KCV
    {
        public override string CalculateKCV(string key)
        {
            try
            {
                byte[] keyByteArray = ByteUtil.HexStringToByteArray(key);
                AES encryptor = new(keyByteArray);
                return encryptor.Encrypt(DATA)[..6];
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Key with invalid size!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Key with invalid characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
