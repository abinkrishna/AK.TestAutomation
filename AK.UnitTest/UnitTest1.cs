using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AK.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                

        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail();

        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.Inconclusive();

        }
        [TestMethod]
        public void TestMethod5()
        {
            //Assert.pass();

        }
    }
}
