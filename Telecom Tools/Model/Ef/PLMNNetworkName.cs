using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    /// <summary>
    ///  This class inherits from EfModel and stores all information needed to generate the Elementary File 
    ///  "PNN".
    /// </summary>
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
