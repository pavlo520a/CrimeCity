using CrimeCity.Contracts.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.BusinessLogic
{
    /// <summary>
    /// This class will be needed to save password (in safe way) into database
    /// and to check is entered by user password is correct
    /// </summary>
    public class PasswordEncryptor : IPasswordEncryptor
    {
        public string GetHash(string password)
        {
            return GetSHA1Hash(password);
        }

        public bool IsValid(string password, string hash)
        {
            return string.Compare(GetSHA1Hash(password), hash) == 0;
        }

        private string GetSHA1Hash(string password)
        {
            SHA1 sha1 = SHA1.Create();
            StringBuilder returnValue = new StringBuilder();

            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(password));

            for (int i = 0; i < hashData.Length; i++)
                returnValue.Append(hashData[i].ToString("x2"));

            return returnValue.ToString();
        }
    }
}
