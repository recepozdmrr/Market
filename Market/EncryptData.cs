using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Market
{
    public class EncryptData
    {
        public static string MD5(string md5String)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] byteString = Encoding.UTF8.GetBytes(md5String);
            byteString = MD5Code.ComputeHash(byteString);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteString)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}