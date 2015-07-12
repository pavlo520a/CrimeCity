using CrimeCity.Contracts.UserContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.BusinessLogic
{
    public class PasswordEncryptor : IPasswordEncryptor
    {
        public string GetHash(string password)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(string password)
        {
            throw new NotImplementedException();
        }
    }
}
