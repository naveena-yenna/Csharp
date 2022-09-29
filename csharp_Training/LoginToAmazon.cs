using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Training
{
    [TestClass]
    public class LoginToAmazon
    {
        [TestMethod]
        public void LaunchApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
           driver.FindElement(By.XPath("//span[@class='nav-line-2 ']")).Click();
            driver.FindElement(By.CssSelector("input#ap_email")).SendKeys("naveenaraviyenna@gmail.com");
          driver.FindElement(By.CssSelector("input#continue")).Click();
            driver.FindElement(By.CssSelector("input#ap_password")).SendKeys("Navi@1234");
            driver.FindElement(By.CssSelector("input#signInSubmit")).Click();
            driver.FindElement(By.CssSelector("input#twotabsearchtextbox")).SendKeys("samasung z fold phone");
            driver.FindElement(By.CssSelector("input#nav-search-submit-button")).Click();
            driver.FindElement(By.XPath("//img[@src='https://m.media-amazon.com/images/I/71Zzyu-Ol4L._AC_UY218_.jpg']")).Click();
            driver.FindElement(By.CssSelector("input#add-to-cart-button")).Click();
            IWebElement element = driver.FindElement(By.XPath("(//h4[@class='a-alert-heading'])[3]"));
            string Text1 = element.Text;
              Console.Write("the product is"+Text1+".");
            driver.Quit();
            
            }
    }
}
