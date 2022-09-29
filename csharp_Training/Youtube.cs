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
    public class Youtube
    {
        [TestMethod]
        public void LoginToApp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.FindElement(By.CssSelector("input#search")).SendKeys("doremon in telugu");
            driver.FindElement(By.XPath("(//yt-icon[@class='style-scope ytd-searchbox'])[2]")).Click();
            
           driver.FindElement(By.XPath("//div[@class='ytp-inline-preview-scrim ytp-inline-preview-scrim-clear']")).Click();
            driver.FindElement(By.XPath("yt-icon[class='style-scope ytd-masthead'][id='guide-icon']")).Click();
            //driver.FindElement(By.XPath("(//img[@id='img'])[2]")).Click();
           // driver.FindElement(By.XPath("(//yt-formatted-string[@class='style-scope ytd-video-renderer'])[1]")).Click();
            driver.Quit();
        }
    }
}
