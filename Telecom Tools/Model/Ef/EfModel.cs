using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    /// <summary>
    /// This abstract class defines the default fields "Path", "SimpleName" and "Length" in common
    /// with all EFs.
    /// </summary> 
    internal abstract class EfModel
    {
        public string Path { get; set; } = "";
        public string SimpleName { get; set; } = "";
        public int Length { get; set; }
    }
}
