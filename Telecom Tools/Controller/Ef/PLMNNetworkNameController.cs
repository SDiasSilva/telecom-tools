using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller.Ef
{
    /// <summary>
    ///  This class inherits from EfController and overrides the GenerateEF method to generate
    ///  the content of the Elementary File "PNN".
    /// </summary>
    internal class PLMNNetworkNameController : EfController
    {
        private readonly PLMNNetworkName pnn;

        /// <summary>
        /// This constructor will initialize the field "pnn".
        /// </summary>
        public PLMNNetworkNameController()
        {
            pnn = new PLMNNetworkName();
        }

        /// <summary>
        /// This method will generate the content of EFPNN using the parameter "input".
        /// </summary>
        /// <param name="networkFullName">This is the input (Max Length: 16) used to generate the 
        /// EFPNN's content.</param>
        /// <returns>Returns a hexstring with length of 17 bytes e.g 
        /// 43 ?? 8X XX XX XX XX XX XX XX XX XX XX XX XX XX XX:
        /// <para>
        /// ?? - following bytes length;
        /// </para>
        /// <para>
        /// 8X - coding scheme and spare bytes;
        /// </para>
        /// <para>
        /// XX - networkFullName's hexstring (packed 7-bits).
        /// </para></returns>
        public override string GenerateEf(string networkFullName)
        {
            byte[] inputByteArray = ByteUtil.PackInfo(ByteUtil.GetBytes(networkFullName));
            byte[] pnnEFContent = CreateByteArrayFilledWith0xFF(pnn.Length);
            pnnEFContent[0] = 0x43;
            int infoStart = 3;
            pnnEFContent[1] = (byte)(inputByteArray.Length + 1);
            pnnEFContent[2] = CountSpareBits(networkFullName);
            Array.Copy(inputByteArray, 0, pnnEFContent, infoStart, inputByteArray.Length);
            return BitConverter.ToString(pnnEFContent).Replace("-", " ");
        }

        /// <summary>
        /// This method counts the spare bits to pack the "networkFullName".
        /// </summary>
        /// <param name="networkFullName">This is the input (Max Length: 16)used to generate the EFPNN's content.</param>
        /// <returns>Returns a hexstring e.g 8X
        /// <para>
        /// X - spare bits (0-7).
        /// </para></returns>
        private static byte CountSpareBits(string networkFullName)
        {
            if (networkFullName.Length == 8 || networkFullName.Length == 16) return 0x80;
            else if (networkFullName.Length < 8) return (byte)(128+networkFullName.Length);
            return (byte)(128 + networkFullName.Length - 8);
        }
    }
}
