using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Util.Crypto;
using Telecom_Tools.Util;

namespace Telecom_Tools.Model.KCV
{
    /// <summary>
    /// This class inherits from the abstract class KCV and calculate de KCV using the crypto 
    /// algorithm DES.
    /// </summary>
    internal class DESKCV : KCV
    {

        /// <summary>
        /// This method calculates the KCV using the parameter "key" to encrypt a byte array with
        /// the length of 8 filled with 0x00 using the crypto algorithm DES 
        /// then returns the first 3 encrypted bytes.
        /// </summary>
        /// <param name="key">This parameter (Length: 8/16/24 bytes) will be defined by the text of keyTextBox and
        /// will be used to calculate de DES KCV.</param>
        /// <returns>Returns the calculated KCV.</returns>
        public override string CalculateKCV(string key)
        {
            try
            {
                byte[] keyByteArray = ByteUtil.HexStringToByteArray(key);
                TripleDES encryptor = new(keyByteArray);
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
