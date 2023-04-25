namespace Telecom_Tools.Controller.Ef
{
    internal abstract class EfController
    {
        public abstract string GerarEf(string input);

        protected void FillByteArrayWith0xFF(byte[] byteArray)
        {
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = 0xFF;
            }
        }

        public static int GetIndexSearchedItem(byte[] pattern, byte[] source)
        {
            return Array.IndexOf(source, pattern);
        }
    }
}