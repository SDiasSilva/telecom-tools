﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom_Tools.Model;
using Telecom_Tools.Util.Crypto;
using Telecom_Tools.Util;

namespace Telecom_Tools.Controller
{
    internal class PSKController
    {
        private readonly string iccid;
        private readonly string masterKey;

        public PSKController(string iccid, string masterKey)
        {
            this.masterKey = masterKey;
            this.iccid = iccid;
        }

        public string CalculatePSK()
        {
            try
            {
                PSK psk = new(masterKey);
                psk.Data = ConvertICCID(iccid);
                string r1 = new TripleDES(psk.KM0).Encrypt(psk.Data);
                string r2 = new TripleDES(psk.KM1).Encrypt(psk.Data);
                return r1 + r2;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Master Key or ICCID with invalid size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Master Key or ICCID with invalid characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        private static byte[] ConvertICCID(string iccid)
        {
            string last8 = iccid[^16..];
            string swapped = "";
            for (var i = 0; i < last8.Length; i += 2)
            {
                swapped += Swap(last8.Substring(i, 2));
            }
            return ByteUtil.HexStringToByteArray(swapped);
        }
        private static string Swap(string pair)
        {
            string first = pair.Substring(pair.Length - 2, 1);
            string second = pair[^1..];
            return second + first;
        }
    }
}