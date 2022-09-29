using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace csharp_Training
{
    [TestClass]
    public class Facebook
    {
        [TestMethod]
        public void LoginApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.FindElement(By.CssSelector("input#email")).SendKeys("naveenaraviyenna@gmail.com");
            driver.FindElement(By.CssSelector("input#pass")).SendKeys("Navi@1234");
            driver.FindElement(By.XPath("//button[@class='_42ft _4jy0 _6lth _4jy6 _4jy1 selected _51sy']")).Click();
          //  driver.FindElement(By.XPath("(//label[@class='icdlwmnq o9w3sbdw f92fqwvt cavyzvzu bbgqxxx1 j4vk3mq5 bdao358l alzwoclg nd5c72wq om3e55n1 mfclru0v c8dj4xom kgnml90y'])[1]")).SendKeys("sruthiGangi");
            driver.FindElement(By.XPath("(//span[@class='b6ax4al1 lq84ybu9 hf30pyar om3e55n1 oshhggmv qm54mken'])[4]")).Click();
           // driver.FindElement(By.XPath("//input[@placeholder='Search']")).SendKeys("happy");
            driver.Quit();
        }
    }
}
