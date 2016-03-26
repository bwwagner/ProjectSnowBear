using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UITestOneCsharp
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:22266/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheUITestOneCsharpTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Home/Index");
            driver.FindElement(By.LinkText("Register »")).Click();
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("Smith");
            driver.FindElement(By.Id("FirstMidName")).Clear();
            driver.FindElement(By.Id("FirstMidName")).SendKeys("John");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            driver.FindElement(By.LinkText("Deposit")).Click();
            driver.FindElement(By.Id("checkingAccount")).Clear();
            driver.FindElement(By.Id("checkingAccount")).SendKeys("48745858");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            driver.FindElement(By.LinkText("Withdraw")).Click();
            driver.FindElement(By.Id("checkingAccount")).Clear();
            driver.FindElement(By.Id("checkingAccount")).SendKeys("48745858");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            driver.FindElement(By.LinkText("Transfer Money")).Click();
            driver.FindElement(By.LinkText("Contact Us")).Click();
            driver.FindElement(By.LinkText("About")).Click();
            driver.FindElement(By.LinkText("Snow Crash Banking")).Click();
            driver.FindElement(By.LinkText("Learn more »")).Click();
            driver.FindElement(By.LinkText("Project SnowCrash GitHub »")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
