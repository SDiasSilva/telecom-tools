using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    /// <summary>
    /// This abstract class defines the fields "algorithmName" and "keySizes" and
    /// their getters for its children classes.
    /// </summary>
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
