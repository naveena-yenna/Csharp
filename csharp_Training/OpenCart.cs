using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Training
{
    [TestClass]
    public class OpenCart
    {
        [TestMethod]
        public void LaunchApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.opencart.com/index.php?route=account/login");
             driver.FindElement(By.CssSelector("input#input-email")).SendKeys("naveenaraviyenna1@gmail.com");
            driver.FindElement(By.CssSelector("input#input-password")).SendKeys("Navi@1234");
            driver.FindElement(By.CssSelector("button[type='submit'][class='btn btn-primary btn-lg hidden-xs']")).Click();
            driver.FindElement(By.CssSelector("input#input-pin")).SendKeys("8019");
            driver.FindElement(By.CssSelector("button[type='submit'][class='btn btn-primary btn-lg']")).Click();
            driver.FindElement(By.XPath("//div[@class='media-body'][1]")).Click();
          driver.FindElement(By.CssSelector("input#input-username")).Clear();
          driver.FindElement(By.CssSelector("input#input-username")).SendKeys("naveenayenna1");
          driver.FindElement(By.CssSelector("input#input-firstname")).Clear();
          driver.FindElement(By.CssSelector("input#input-firstname")).SendKeys("naveena");
          driver.FindElement(By.CssSelector("input#input-lastname")).Clear();
          driver.FindElement(By.CssSelector("input#input-lastname")).SendKeys("yenna1");
          driver.FindElement(By.CssSelector("input#input-company")).Clear();
          driver.FindElement(By.CssSelector("input#input-company")).SendKeys("zenq");
          driver.FindElement(By.CssSelector("input#input-tax-id")).Clear();
          driver.FindElement(By.CssSelector("input#input-tax-id")).SendKeys("51234");
          driver.FindElement(By.CssSelector("input#input-email")).Clear();
          driver.FindElement(By.CssSelector("input#input-email")).SendKeys("naveenaraviyenna1@gmail.com");
            //driver.FindElement(By.CssSelector("select#input-country")).Clear();
            driver.FindElement(By.CssSelector("select#input-country")).SendKeys("India");
         // driver.FindElement(By.CssSelector("button[type='button'][class='btn btn-success btn-block']")).Click();
          driver.FindElement(By.CssSelector("input[type='radio'][value='0']")).Click();
          driver.FindElement(By.CssSelector("button[type='submit'][class='btn btn-primary']")).Click();
          String Text1 = driver.FindElement(By.XPath("//div[@class='alert alert-success']")).Text;
            Console.Write(Text1);
            driver.Quit();

        }
    }
}
