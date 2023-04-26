using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    internal class ServiceNameProvider:EfModel
    {
        public int RegisteredPLMNRequired { get; set; }
        public int ServiceProviderNamePLMNRequired { get; set; }
        public ServiceNameProvider(int registeredPLMNRequired, int serviceProviderNamePLMNRequired)
        {
            Path = "3F00/7F20/6F46";
            SimpleName = "SPN";
            Length = 17;
            RegisteredPLMNRequired = registeredPLMNRequired;
            ServiceProviderNamePLMNRequired = serviceProviderNamePLMNRequired;
        }
    }
}
