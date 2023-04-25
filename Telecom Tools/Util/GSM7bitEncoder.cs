using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    internal class GSM7bitEncoder
    {
        public static string Encode(string PlainText)

        {

            // ` is not a conversion, just a untranslatable letter

            string strGSMTable = "";

            strGSMTable += "@£$¥èéùìòÇ`Øø`Åå";

            strGSMTable += "Δ_ΦΓΛΩΠΨΣΘΞ`ÆæßÉ";

            strGSMTable += " !\"#¤%&'()*=,-./";

            strGSMTable += "0123456789:;<=>?";

            strGSMTable += "¡ABCDEFGHIJKLMNO";

            strGSMTable += "PQRSTUVWXYZÄÖÑÜ`";

            strGSMTable += "¿abcdefghijklmno";

            strGSMTable += "pqrstuvwxyzäöñüà";

            string strExtendedTable = "";

            strExtendedTable += "````````````````";

            strExtendedTable += "````^```````````";

            strExtendedTable += "````````{}`````\\";

            strExtendedTable += "````````````[~]`";

            strExtendedTable += "|```````````````";

            strExtendedTable += "````````````````";

            strExtendedTable += "`````€``````````";

            strExtendedTable += "````````````````";

            string strGSMOutput = "";

            foreach (char cPlainText in PlainText.ToCharArray())

            {
                int unknownCharacter = 63;
                int intGSMTable = strGSMTable.IndexOf(cPlainText);

                if (intGSMTable != -1)

                {
                    strGSMOutput += intGSMTable.ToString("X2");

                    continue;

                }

                int intExtendedTable = strExtendedTable.IndexOf(cPlainText);

                if (intExtendedTable != -1)

                {
                    strGSMOutput += (27).ToString("X2");
                    strGSMOutput += intExtendedTable.ToString("X2");

                }

                if (intGSMTable == -1 && intExtendedTable == -1)
                {
                    strGSMOutput += unknownCharacter.ToString("X2");
                }
            }

            return strGSMOutput;

        }
    }
}
}
