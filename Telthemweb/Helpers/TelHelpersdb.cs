using System;
using System.Security.Cryptography;
using System.Text;

namespace Telthemweb.Helpers
{
    /// <summary>
    /// This is encryption class
    /// </summary>
    public class TelHelpersdb
    {
        TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider M5 = new MD5CryptoServiceProvider();
        string PublicKey = "One day i will conquer the world. God have mercy on my vision";

        /// <summary>
        /// Print md5 hash code algorithim
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public byte[] TelMD5Code(string values)
        {
            return M5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(values));
        }

        /// <summary>
        /// Encryipt data 
        /// </summary>
        /// <param name="StrEncrypt"></param>
        /// <returns></returns>
        public string TelEncryptData(string StrEncrypt)
        {
            DES.Key = TelMD5Code(PublicKey);
            DES.Mode = CipherMode.ECB;
            byte[] buf = ASCIIEncoding.ASCII.GetBytes(StrEncrypt);
            return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buf, 0, buf.Length));
        }

        /// <summary>
        ///  Decryipt data 
        /// </summary>
        /// <param name="DecryptString"></param>
        /// <returns></returns>
        public string TelDecryptData(string DecryptString)
        {
            try
            {
                DES.Key = TelMD5Code(PublicKey);
                DES.Mode = CipherMode.ECB;
                byte[] Buff = Convert.FromBase64String(DecryptString);
                return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buff, 0, Buff.Length));
            }
            catch
            {
                return "FALSE";
            }
        }
    }
}
