using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util.Hash
{
    internal interface HashType
    {
        public string ComputeHash(string plaintext);
    }
}
