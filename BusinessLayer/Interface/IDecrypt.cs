

namespace BusinessLayer.Interface
{
   public interface IDecrypt
    {
        string DecryptString(string encryptedInput, string key);
    }
}
