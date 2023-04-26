using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    internal class PLMNNetworkName:EfModel
    {
        public PLMNNetworkName()
        {
            Path = "3F00/7F20/6FC5";
            SimpleName = "PNN";
            Length = 17;
        }
    }
}
