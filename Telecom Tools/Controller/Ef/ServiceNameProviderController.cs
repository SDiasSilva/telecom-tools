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
    ///  the content of the Elementary File "SPN".
    /// </summary>
    internal class ServiceNameProviderController : EfController
    {
        private readonly ServiceNameProvider spn;

        /// <summary>
        /// This constructor will initialize the field "spn" using the parameters "registeredPLMNRequired" and
        /// "sPNPLMNRequired".
        /// </summary>
        /// <param name="registeredPLMNRequired">This parameter will be defined by the selected index of 
        /// SPNRegisteredPLMNRequiredComboBox.</param>
        /// <param name="sPNPLMNRequired">This parameter will be defined by the selected index of
        /// SPNamePLMNRequiredComboBox.</param>
        public ServiceNameProviderController(int registeredPLMNRequired, int sPNPLMNRequired)
        {
            spn = new ServiceNameProvider(registeredPLMNRequired, sPNPLMNRequired);
        }

        /// <summary>
        /// This method will generate the content of EFSPN using the parameter "serviceProviderName".
        /// </summary>
        /// <param name="serviceProviderName">This is the input (Max Length: 16) used to generate the 
        /// EFSPN's content.</param>
        /// <returns>Returns a hexstring with length of 17 bytes e.g 
        /// ?? XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX:
        /// <para>
        /// ?? - Display Condition (bytes represent respectively registeredPLMNRequired and sPNPLMNRequired);
        /// </para>
        /// <para>
        /// XX - serviceProviderName's hexstring.
        /// </para></returns>
        public override string GenerateEf(string serviceProviderName)
        {
            byte[] inputByteArray = ByteUtil.GetBytes(serviceProviderName);
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
