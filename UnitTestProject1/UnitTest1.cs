using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace stanislavDuga.test
{
    [TestClass]
    public class UnitTest1
    {
        private Program program = new Program(); 
        [TestMethod]
        public void TestMethod100is100()
        {
            string value = "100";
            long expected = 100;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10k()
        {
            string value = "10k";
            long expected = 10000;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10kBigleter()
        {
            string value = "10K";
            long expected = 10000;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10m()
        {
            string value = "10m";
            long expected = 10000000;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10b()
        {
            string value = "10b";
            long expected = 10000000000;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10t()
        {
            string value = "10t";
            long expected = 10000000000000;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodnull()
        {
            string value = null;
            long expected = -1;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodWrongSinbol()
        {
            string value = "11h";
            long expected = -1;
            long actual = program.truoNumber(value);
              Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodnumdersAfterSinbol()
        {
            string value = "11k10";
            long expected = -1;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodDuobleSinbol()
        {
            string value = "11kb";
            long expected = -1;
            long actual = program.truoNumber(value);
            Assert.AreEqual(expected, actual);
        }
    }
}
