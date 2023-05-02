using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller.Ef
{
    internal class PLMNNetworkNameController : EfController
    {
        private readonly PLMNNetworkName pnn;
        public PLMNNetworkNameController()
        {
            pnn = new PLMNNetworkName();
        }
        public override string GenerateEf(string input)
        {
            byte[] inputByteArray = ByteUtil.PackInfo(ByteUtil.GetBytes(input));
            byte[] pnnEFContent = CreateByteArrayFilledWith0xFF(pnn.Length);
            pnnEFContent[0] = 0x43;
            int infoStart = 3;
            pnnEFContent[1] = (byte)(inputByteArray.Length + 1);
            pnnEFContent[2] = CountSpareBits(input);
            Array.Copy(inputByteArray, 0, pnnEFContent, infoStart, inputByteArray.Length);
            return BitConverter.ToString(pnnEFContent).Replace("-", " ");
        }
        private static byte CountSpareBits(string input)
        {
            if (input.Length == 8 || input.Length == 16) return 0x80;
            else if (input.Length < 8) return (byte)(128+input.Length);
            return (byte)(128 + input.Length - 8);
        }
    }
}
