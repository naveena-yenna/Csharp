
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace csharp_Training
{
    [TestClass]
    public class LoginPage
    {
        private By userEmail = By.CssSelector("input#input-email");
        private By userPassword = By.CssSelector("input#input-password");
        private By loginButton = By.CssSelector("button[type = 'submit'][class ='btn btn-primary btn-lg hidden-xs']");
        private By pinConfirm = By.CssSelector("input#input-pin");
        private By continueButton = By.CssSelector("button[type='submit'][class='btn btn-primary btn-lg']");
        private By accountPageLink = By.XPath("//a[text()='Account Details']");
        private By userName = By.CssSelector("input#input-username");
        private By firstName = By.CssSelector("input#input-firstname");
        private By lastName = By.CssSelector("input#input-lastname");
        private By companyName = By.CssSelector("input#input-company");
        private By taxID = By.CssSelector("input#input-tax-id");
        private By userEMail = By.CssSelector("input#input-email");
        private By userCountry = By.CssSelector("select[name='country_id'][id='input-country']");
        private By radioButton = By.CssSelector("input[name='notify'][value='0']");
        private By submitButton = By.CssSelector("button[type='submit'][class='btn btn-primary']");
        private By logOut = By.CssSelector("a[class='btn btn-black navbar-btn']");
        [TestMethod]
        public void LaunchApplication()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.opencart.com/index.php?route=account/login");
            driver.FindElement(userEmail).SendKeys("naveenaraviyenna1@gmail.com");
            driver.FindElement(userPassword).SendKeys("Navi@1234");
            driver.FindElement(loginButton).Click();
            driver.FindElement(pinConfirm).SendKeys("8019");
            driver.FindElement(continueButton).Click();
            driver.FindElement(accountPageLink).Click();
            driver.FindElement(userName).Clear();
            driver.FindElement(userName).SendKeys("naveenayenna");
            driver.FindElement(firstName).Clear();
            driver.FindElement(firstName).SendKeys("naveena1");
            driver.FindElement(lastName).Clear();
            driver.FindElement(lastName).SendKeys("yenna");
            driver.FindElement(companyName).Clear();
            driver.FindElement(companyName).SendKeys("qualitest");
            driver.FindElement(taxID).Clear();
            driver.FindElement(taxID).SendKeys("48902");
            driver.FindElement(userEMail).Clear();
            driver.FindElement(userEMail).SendKeys("naveenaraviyenna1@gmail.com");
            driver.FindElement(userCountry).SendKeys("India");
            driver.FindElement(radioButton).Click();
            driver.FindElement(submitButton).Click();
            driver.FindElement(logOut).Click();
            driver.Quit();

        }
    }
}