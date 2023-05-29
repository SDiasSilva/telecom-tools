using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model;
using Telecom_Tools.Util.Crypto;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller
{
    /// <summary>
    ///  This class is used to calculate the psk.
    /// </summary>
    internal class PSKController
    {
        private readonly string iccid;
        private readonly string masterKey;

        /// <summary>
        /// This constructor will initialize the fields "iccid" and "masterKey" that will be used
        /// to calculate the PSK.
        /// </summary>
        /// <param name="iccid">This parameter will be defined by the text of ICCIDTextBox.</param>
        /// <param name="masterKey">This parameter will be defined by the text of masterKeyTextBox.</param>
        public PSKController(string iccid, string masterKey)
        {
            this.masterKey = masterKey;
            this.iccid = iccid;
        }

        /// <summary>
        /// This method calculates the psk in the following way:
        /// <para>■ The data(data) is the 8 last bytes of the swapped ICCID</para>
        /// <para>■ The Master Key(KM0) is a 16-byte key.</para>
        /// <para>The algorithm for calculating diversified keys is:</para>
        /// <para>KM0 = K1 || K2</para>
        /// <para>KM1 = K2 || K1</para>
        /// <para>R1 = 3 - DESKM0(data) or R1 = DESK1(DES - 1K2(DESK1(data)))</para>
        /// <para>R2 = 3 - DESKM1(data) or R2 = DESK2(DES - 1K1(DESK2(data)))</para>
        /// <para>PSK = R1 || R2</para>
        /// <para>where:</para>
        /// <para>■ K1 = Left - most 8 bytes of the Master Key</para>
        /// <para>■ K2 = Right - most 8 bytes of the Master Key</para>
        /// <para>The PSK is encrypted using 3DES ECB NO_PADDING and using two different 8 byte keys.</para>
        /// <para>The PSK is 16 bytes in length</para>
        /// </summary>
        /// <returns>Returns the calculated PSK.</returns>
        public string CalculatePSK()
        {
            try
            {
                PSK psk = new(masterKey);
                psk.Data = ConvertICCID(iccid);
                string r1 = new TripleDES(psk.KM0).Encrypt(psk.Data);
                string r2 = new TripleDES(psk.KM1).Encrypt(psk.Data);
                return r1 + r2;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Master Key or ICCID with invalid size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Master Key or ICCID with invalid characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        /// <summary>
        /// This method converts the ICCID by swapping every 2 digits.
        /// </summary>
        /// <param name="iccid">This parameter will be returned swapped.</param>
        /// <returns>Returns the swapped ICCID e.g 89256776274942161783 -> 98527667729424617138.</returns>
        private static byte[] ConvertICCID(string iccid)
        {
            string last8 = iccid[^16..];
            string swapped = "";
            for (var i = 0; i < last8.Length; i += 2)
            {
                swapped += Swap(last8.Substring(i, 2));
            }
            return ByteUtil.HexStringToByteArray(swapped);
        }

        /// <summary>
        /// This method swaps 2 characters of a string with length of 2.
        /// </summary>
        /// <param name="pair">This parameter it is a string of 2 characters.</param>
        /// <returns>Returns the swapped characters e.g 89 -> 98.</returns>
        private static string Swap(string pair)
        {
            if (pair.Length > 2){
                throw new ArgumentException("Invalid pair size");
            }
            string first = pair.Substring(pair.Length - 2, 1);
            string second = pair[^1..];
            return second + first;
        }
    }
}
