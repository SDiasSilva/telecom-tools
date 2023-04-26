using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    // This abstract class defines the default fields for all its child classes.
    internal abstract class EfModel
    {
        public string Path { get; set; } = "";
        public string SimpleName { get; set; } = "";
        public int Length { get; set; }
    }
}
