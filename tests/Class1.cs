using System;
using System.Threading;
//using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace fc.test.project
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1(){
            Assert.True(1 < 2);
        }

        [Test]
        public void TestMethod2(){
            Assert.AreEqual("abc","abc");
        }

        [Test]
        public void TestMethod3()
        {
            Assert.True(1==1);
        }
        
    }
}
