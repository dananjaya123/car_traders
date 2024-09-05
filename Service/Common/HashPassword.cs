using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Service.Common
{
    internal class HashPassword
    {
        public string HashPasswords(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // converts the password (a string) into bytes using UTF-8 encoding and then hashes it.
                //this produces a byte array as the hashed result.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // StringBuilder to build the hashed password as a readable string
                StringBuilder builder = new StringBuilder();
                // loop byte  hashed result
                for (int i = 0; i < bytes.Length; i++)
                {
                    //Each byte is converted to a hexadecimal string
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
                //returns the complete hashed password
            }
        }
    }
}
