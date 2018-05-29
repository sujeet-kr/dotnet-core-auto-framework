using System;
using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace fc.test.project
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod2(){
            Assert.True(1<2);
        }


        [Fact]
        public void TestMethod2(){
            Assert.Equal("1", "2");
        }

        [Fact]
        public void TestMethod3()
        {
            Assert.True(1==1);
        }
        
    }
}
