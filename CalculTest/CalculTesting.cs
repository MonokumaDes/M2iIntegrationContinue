using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculLibrary;

namespace CalculTest
{
    [TestClass]
    public class CalculTesting
    {
        [TestMethod]
        public void TestGetInt()
        {
            string number = "42";

            Assert.AreEqual(42, Calcul.GetInt(number));
        }
    }
}
