namespace Telecom_Tools.Controller.Ef
{
    /*
     * This abstract class defines the default methods and reusable methods for all its child classes.
     */
    internal abstract class EfController
    {
        /*
         * This method will generate a EF content based on the child class implementation
         * 
         * @param input This is the information that will be converted into an EF Content
         */
        public abstract string GenerateEf(string input);
        

        /*
         * This method create and fill a byte array with FF
         * 
         * @param length The created byte array length
         */
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