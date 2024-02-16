using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow;

namespace FundEasy.Contexts
{
    public class LoginContext
    {
        private LoginPage _loginPage = new LoginPage();

        public void LogIn(string username, string password)
        {
            IWebDriver driver = ScenarioContext.Current["driver"] as IWebDriver;
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["homeUrl"]);
            
                _loginPage.UsernameField.SendKeys(username);
            _loginPage.PasswordField.SendKeys(password);
            _loginPage.SubmitBtn.Click();
        }
    }
}
