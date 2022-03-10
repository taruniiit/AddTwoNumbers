using System;
using NUnit.Framework;
using AddTwoNumbers;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            Program theProg = new Program();
            string[] args = new string[] { "Test1", "2", "10" };
            var ret = theProg.Main(new string[] { "Test1", "2", "10" });

            Assert.AreEqual(12, ret);
            Console.WriteLine("Completed test method: Test1");
        }
        [Test]
        public void TestMethod2()
        {
            Program theProg = new Program();
            string[] args = new string[] { "Test1", "-2", "10" };
            var ret = theProg.Main(new string[] { "Test1", "-2", "10" });

            Assert.AreEqual(8, ret);
            Console.WriteLine("Completed test method: Test2");

        }
        [Test]
        public void TestMethod3()
        {
            Program theProg = new Program();
            var ret = theProg.Main(new string[] { "Test1", "-20", "10" });

            Assert.AreEqual(-10, ret);
            Console.WriteLine("Completed test method: Test3");
        }
    }
}
