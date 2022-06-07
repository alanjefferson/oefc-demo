using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace BlueChip.Util
{
	public static class Crypt
	{
        private static readonly byte[] key = Encoding.UTF8.GetBytes("bluchp_Crypt@Encrypt/Decrypt@Str");
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("@@bluchp_@@Crypt");

        public static string Decrypt(string inStr)
        {
            string str;
            try
            {
                RijndaelManaged managed = new RijndaelManaged
                {
                    Key = key,
                    IV = iv
                };
                MemoryStream stream = new MemoryStream(Convert.FromBase64String(inStr));
                CryptoStream stream2 = new CryptoStream(stream, managed.CreateDecryptor(managed.Key, managed.IV), CryptoStreamMode.Read);
                byte[] buffer = new byte[inStr.Length];
                int count = stream2.Read(buffer, 0, buffer.Length);
                str = Encoding.Default.GetString(buffer, 0, count);
                stream.Close();
                stream2.Close();
            }
            catch
            {
                str = "!invalid_string!";
            }
            return str;
        }
        
        public static string Encrypt(string inStr)
        {
            string str;
            try
            {
                RijndaelManaged managed = new RijndaelManaged
                {
                    Key = key,
                    IV = iv
                };
                Encoding.ASCII.GetBytes(inStr);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, managed.CreateEncryptor(managed.Key, managed.IV), CryptoStreamMode.Write);
                stream2.Write(Encoding.Default.GetBytes(inStr), 0, inStr.Length);
                stream2.FlushFinalBlock();
                str = Convert.ToBase64String(stream.ToArray());
                stream.Close();
                stream2.Close();
            }
            catch
            {
                str = "!invalid_string!";
            }
            return str;
        }
    }
}
