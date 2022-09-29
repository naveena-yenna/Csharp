
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace csharp_Training
{
    [TestClass]
    public class Flipkart
    {
        [TestMethod]
        public void LaunchFlipkart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com");
            driver.FindElement(By.CssSelector("input[class='_2IX_2- VJZDxU'][type='text']")).SendKeys("6305273762");
            driver.FindElement(By.CssSelector("input[class='_2IX_2- _3mctLh VJZDxU'][type='password']")).SendKeys("Navi@1234");
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2HKlqd _3AWRsL']")).Click();
            Thread.Sleep(700);
            driver.FindElement(By.XPath("//input[@class='_3704LK']")).SendKeys("samsung nfold phone");
           // driver.FindElement(By.XPath("//button[@class='L0Z3Pu']")).Click();
            driver.Quit();
        }
    }
}
