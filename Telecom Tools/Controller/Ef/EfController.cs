namespace Telecom_Tools.Controller.Ef
{
    /// <summary>
    /// This abstract class defines the abstract method "GenerateEf" that will
    /// be implememented accordingly with its child.
    /// </summary>
    internal abstract class EfController
    {
        /// <summary>
        /// This method will generate a EF content based on the children classes implementation.
        /// </summary>
        /// <param name="input">This is the information that will be used to create the EF Content.</param>
        /// <returns>Returns a hexstring based on this method implementation and the input.</returns>
        public abstract string GenerateEf(string input);

        /// <summary>
        /// This method create and fill a byte array with 0xFF.
        /// </summary>
        /// <param name="length">This the length of the byte array that will be returned.</param>
        /// <returns>Returns a byte array filled with 0xFF with the chosen length.</returns>
        protected static byte[] CreateByteArrayFilledWith0xFF(int length)
        {
            byte[] byteArray = new byte[length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = 0xFF;
            }
            return byteArray;
        }
    }
}