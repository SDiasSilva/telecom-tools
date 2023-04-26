using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    internal class GSMEncoder
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
        public static byte[] EncodeGSM1111v1(string plainText)
        {
            byte[] utf32 = System.Text.Encoding.UTF32.GetBytes(plainText);
            byte[] output = new byte[plainText.Length * 2 + 1];
            output[0] = 0x80;
            int outputIndex = 1;
            for (int i = 0; i < utf32.Length; i += 4)
            {
                output[outputIndex] = utf32[i + 1];
                output[outputIndex + 1] = utf32[i];
                outputIndex += 2;
                if (outputIndex == output.Length - 1)
                {
                    break;
                }
            }
            return output;
        }
        public static byte[] EncodeGSM1111v2(byte[] input)
        {
            byte[] output = new Byte[input.Length + 3];
            output[0] = 0x81;
            output[1] = (byte)input.Length;
            output[2] = 0xFF;
            Array.Copy(input, 0, output, 3, input.Length);
            return output;
        }
        public static byte[] EncodeGSM1111v3(byte[] input)
        {
            byte[] output = new Byte[input.Length + 4];
            output[0] = 0x82;
            output[1] = (byte)input.Length;
            output[2] = 0xFF;
            output[3] = 0xFF;
            Array.Copy(input, 0, output, 4, input.Length);
            return output;
        }
    }
}
