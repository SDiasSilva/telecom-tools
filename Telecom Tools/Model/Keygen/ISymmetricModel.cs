namespace Telecom_Tools.Model.Keygen
{
    internal interface ISymmetricModel
    {
        string GenerateKey(int keySize);
    }
}