namespace Telecom_Tools.Controller.Ef
{
    internal abstract class EfController
    {
        public abstract string GerarEf(string input);

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