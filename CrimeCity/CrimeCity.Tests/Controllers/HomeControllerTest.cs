﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CrimeCity.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase]
        public void Test1()
        {
            Assert.AreEqual(0, 0);
        }

        [TestCase]
        public void FailedTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
