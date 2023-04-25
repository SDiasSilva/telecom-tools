using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    internal abstract class EfModel
    {
        public string Path { get; set; } = "";
        public string SimpleName { get; set; } = "";
        public int Length { get; set; }
    }
}
