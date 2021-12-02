using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic.Helpers
{
    public class HashHelper
    {
        public static string CalcHash(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }
    }
}
