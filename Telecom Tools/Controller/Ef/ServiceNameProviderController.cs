using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model.Ef;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller.Ef
{
    internal class ServiceNameProviderController : EfController
    {
        private readonly ServiceNameProvider spn;
        public ServiceNameProviderController(int registeredPLMNRequired, int sPNPLMNRequired)
        {
            spn = new ServiceNameProvider(registeredPLMNRequired, sPNPLMNRequired);
        }
        public override string GerarEf(string input)
        {
            byte[] inputByteArray = ByteUtil.GetBytes(input);
            byte[] spnEFContent = CreateByteArrayFilledWith0xFF(spn.Length);
            spnEFContent[0] = (spn.RegisteredPLMNRequired, spn.ServiceProviderNamePLMNRequired) switch
            {
                //True and True
                (0, 0) => 0x01,
                //True and False
                (0, 1) => 0x03,
                //False and True
                (1, 0) => 0x00,
                //False and False
                (1, 1) => 0x02,
                //Not present or Not present
                _ => 0xFF,
            };
            Array.Copy(inputByteArray, 0, spnEFContent, 1, inputByteArray.Length);
            return BitConverter.ToString(spnEFContent).Replace("-", " ");
        }
    }
}
