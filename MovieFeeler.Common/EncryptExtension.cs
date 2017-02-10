using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Common
{
    public static class EncryptExtension
    {
        public static string EncryptMD5(this string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                return null;

            byte[] keyArray = EncryptMD5Array(plainText);

            return Convert.ToBase64String(keyArray, 0, keyArray.Length);
        }

        /// <summary>
        /// Encrypt with MD5 - one way encoding
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static byte[] EncryptMD5Array(this string plainText)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(plainText));

            // Always release the resources and flush data
            // of the Cryptographic service provide. Best Practice
            hashmd5.Clear();

            return keyArray;
        }
    }
}
