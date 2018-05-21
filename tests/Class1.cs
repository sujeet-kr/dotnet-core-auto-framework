using System;
using System.Threading;
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
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("browserName", "chrome");
            //IWebDriver _driver = new ChromeDriver(@"/Users/sujeet.kumar/WebDriver-Drivers/");
            IWebDriver _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);


            _driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = _driver.FindElement(By.Name("q"));
            element.SendKeys("Sujeet");
            //Thread.Sleep(10000);                      
        }
        
    }
}
