using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Leovolpatto.Eccosys.Helpers
{
    public static class ApiAuthHelper
    {
        public static string GenerateSignature(string secret)
        {
            return GenerateSignature(secret, DateTime.Now);
        }

        public static string GenerateSignature(string secret, DateTime datetime)
        {
            string date = datetime.ToString("dd-MM-yyyy");
            string signTemplate = string.Concat(secret, ":", date);
            string signature = "";
            using (var md5 = MD5.Create())
            {
                byte[] input = Encoding.UTF8.GetBytes(signTemplate);
                byte[] hash = md5.ComputeHash(input);
                signature = BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

            return signature;
        }
    }
}
