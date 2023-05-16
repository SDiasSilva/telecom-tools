using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    internal abstract class AlgorithmModel
    {
        protected object? algorithmName;
        protected object[]? keySizes;

        public object? AlgorithmName()
        {
            return algorithmName;
        }
        public object[]? KeySizes()
        {
            return keySizes;
        }
    }
}
