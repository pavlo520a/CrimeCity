using CrimeCity.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CrimeCity.Tests.BL
{
    [TestFixture]
    public class PasswordEncryptorTest
    {
        private PasswordEncryptor encryptor = new PasswordEncryptor();
        private string correctPassword = "pavlo520a";
        private string wrongPassword = "pavlo520x";
        private string hash = "a19d7e480ab588697903d316435b5ba1761cc6f1";

        [TestCase]
        public void GetHash_GetCorrectHash() 
        {
            string actualHash = encryptor.GetHash(correctPassword);
            Assert.AreEqual(hash, actualHash);
        }

        [TestCase]
        public void IsValid_HashIsValid()
        {
            Assert.AreEqual(true, encryptor.IsValid(correctPassword, hash));
        }

        [TestCase]
        public void IsValid_HashIsInvalid()
        {
            Assert.AreEqual(false, encryptor.IsValid(wrongPassword, hash));
        }
    }
}
