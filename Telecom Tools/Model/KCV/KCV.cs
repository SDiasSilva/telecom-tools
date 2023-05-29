using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom_Tools.Model.KCV
{
    /// <summary>
    /// This abstract class defines the readonly field "DATA" and the abstract method
    /// CalculateKCV for its children classes.
    /// </summary> 
    internal abstract class KCV
    {
        protected readonly byte[] DATA = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        /// <summary>
        /// This method returns the calculated KCV accordingly with the implementation of its child class.
        /// </summary>
        /// <param name="key">This parameter will be defined by the text of keyTextBox.</param>
        /// <returns>Returns the calculated KCV.</returns>
        public abstract string CalculateKCV(string key);
    }
}
