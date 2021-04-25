using BusinessLayer.Interface;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Implementation
{
    public class Decrypt : IDecrypt
    {
        public string DecryptString(string encryptedInput, string key)
        {
            byte[] inputArray = Convert.FromBase64String(encryptedInput);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
