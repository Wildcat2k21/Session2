using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BolshayaPachkaLibrary.Test1
{
    [TestClass]
    public class PachkaTest1
    {
        [TestMethod]
        public void TestDBconnection()
        {
            //arrage
            int expected = 133;

            //act
            PachkaClass test = new PachkaClass();
            int actual = test.SelectMaxID("Material");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
