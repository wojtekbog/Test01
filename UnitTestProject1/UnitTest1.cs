using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTest01;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Class1.testFunction(), "");
        }
    }
}
