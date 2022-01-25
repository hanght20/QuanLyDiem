using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.UTIL
{
    public class ProcessingLogic
    {
        public static string Decrypt(string cipherString, bool useHashing)
        {
            byte[] buffer;
            byte[] inputBuffer = Convert.FromBase64String(cipherString);
            AppSettingsReader reader = new AppSettingsReader();
            string s = "Tiep";
            if (!useHashing)
            {
                buffer = Encoding.UTF8.GetBytes(s);
            }
            else
            {
                MD5CryptoServiceProvider provider2 = new MD5CryptoServiceProvider();
                buffer = provider2.ComputeHash(Encoding.UTF8.GetBytes(s));
                provider2.Clear();
            }
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider
            {
                Key = buffer,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            byte[] bytes = provider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            provider.Clear();
            return Encoding.UTF8.GetString(bytes);
        }

        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] buffer;
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            AppSettingsReader reader = new AppSettingsReader();
            string s = "Tiep";
            if (!useHashing)
            {
                buffer = Encoding.UTF8.GetBytes(s);
            }
            else
            {
                MD5CryptoServiceProvider provider2 = new MD5CryptoServiceProvider();
                buffer = provider2.ComputeHash(Encoding.UTF8.GetBytes(s));
                provider2.Clear();
            }
            TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider
            {
                Key = buffer,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            byte[] inArray = provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            provider.Clear();
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }

        public string GetEnCode(string chuoi) =>
            Encrypt(chuoi, true);
    }
}
