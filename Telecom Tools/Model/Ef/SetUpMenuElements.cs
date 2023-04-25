using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.Ef
{
    internal class SetUpMenuElements : EfModel
    {

        public readonly Dictionary<string, byte[]> ICON_QUALIFIER = new()
        {
            { "Self-explanatory", new byte[] { 0x1E, 0x02, 0x00 } },
            { "Not self-explanatory", new byte[] { 0x1E, 0x02, 0x01 } },
            { "Not present", Array.Empty<byte>() }
        };

        public readonly int ICON_QUALIFIER_LENGTH = 3;

        public SetUpMenuElements()
        {
            Path = "3F00/7F10/6F54";
            SimpleName = "SUME";
            Length = 30;
        }
    }
}