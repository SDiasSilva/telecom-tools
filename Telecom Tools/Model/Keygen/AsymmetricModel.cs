using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Keygen
{
    internal abstract class AsymmetricModel : AlgorithmModel
    {
        public abstract List<string> GenerateKeyPair(int keySize);
    }
}
