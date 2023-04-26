﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Util
{
    // A utility class for handling input files
    internal class InputFileUtil
    {
        // Byte arrays used to identify the start and end of the customer name in the input file
        private static readonly byte[] CUSTOMER_START = { 0x43, 0x75, 0x73, 0x74, 0x6F, 0x6D, 0x65, 0x72, 0x20, 0x20, 0x20, 0x20, 0x20, 0x3A, 0x20, 0x22 };
        private static readonly byte[] CUSTOMER_END = { 0x22, 0x0D, 0x0A };
        
        // Method for opening an input file and recovering the customer name from it
        public static string OpenInputFile(OpenFileDialog efGenOpenFileDialog, Form telecomToolsform)
        {
            var result = efGenOpenFileDialog.ShowDialog(telecomToolsform);
            if (result != DialogResult.OK) return "";
            byte[] buffer = File.ReadAllBytes(efGenOpenFileDialog.FileName);
            try
            {
                return RecoverCustomerNameFromInputFile(buffer);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Method for recovering the customer name from an input file buffer
        private static string RecoverCustomerNameFromInputFile(byte[] buffer)
        {
            // Find the start and end indices of the customer name in the buffer
            int startIndex = ByteUtil.GetIndexSearchedItem(CUSTOMER_START, buffer) + CUSTOMER_START.Length;
            int endIndex = ByteUtil.GetIndexSearchedItem(CUSTOMER_END, buffer);
            int length = endIndex - startIndex;
            // Extract the customer name bytes from the buffer
            byte[] customer = new byte[length];
            Array.Copy(buffer, startIndex, customer, 0, length);
            // Convert the customer name bytes to a string and return it
            return System.Text.Encoding.ASCII.GetString(customer);
        }
    }
}
