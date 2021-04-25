using BusinessLayer.Interface;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Implementation
{
    public class Encrypt : IEncrypt
    {
        public string EncryptString(string inputToEncrypt, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(inputToEncrypt);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}
