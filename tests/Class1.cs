using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace fc.test.project
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1(){
            IWebDriver _driver = new ChromeDriver(@"/Users/sujeet.kumar/WebDriver-Drivers/");
            _driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = _driver.FindElement(By.Name("q"));
            element.SendKeys("Sujeet");
            //Thread.Sleep(10000);                      
        }
        
    }
}
