using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Training
{
    [TestClass]
    public class HeroKu
    {
        [TestMethod] 
        public  void  ListOfElements()
        {
            IWebDriver driver = new ChromeDriver();
          driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
           driver.FindElement(By.XPath("//a[@href='/broken_images']")).Click();
           driver.Close();
           // driver.FindElement(By.XPath("//a[@href='/checkboxes']")).Click();
           // driver.FindElement(By.XPath("//input[@type='checkbox'][1]")).Click();

        }
    }
}
