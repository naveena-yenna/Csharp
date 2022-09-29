using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_Training
{
    [TestClass]
    public class SwagLabs
    {
        [TestMethod]
        public void LaunchApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.CssSelector("input#user-name")).SendKeys("standard_user");
            driver.FindElement(By.CssSelector("input#password")).SendKeys("secret_sauce");
            driver.FindElement(By.CssSelector("input#login-button")).Click();
            driver.FindElement(By.CssSelector("button#add-to-cart-sauce-labs-backpack")).Click();
            Thread.Sleep(500);
            driver.Quit();

        }
    }
}
