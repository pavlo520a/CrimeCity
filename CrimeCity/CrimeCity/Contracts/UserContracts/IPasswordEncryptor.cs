using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts.UserContracts
{
    public interface IPasswordEncryptor
    {
        string Encrypt(string password);
        bool IsValid(string password);
    }
}
