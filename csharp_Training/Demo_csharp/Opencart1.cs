using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_csharp
{
    [TestClass]
    public class Opencart1
    {
        
        [TestMethod]
        public void LoginPage()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.opencart.com/index.php?route=account/login");
        } 
        
    }
}
