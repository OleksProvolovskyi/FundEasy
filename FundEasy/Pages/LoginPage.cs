
using OpenQA.Selenium;
using TechTalk.SpecFlow;

public class LoginPage
{
    IWebDriver driver = ScenarioContext.Current["driver"] as IWebDriver;

    public IWebElement UsernameField => driver.FindElement(By.Id("username"));
    public IWebElement PasswordField => driver.FindElement(By.Id("password"));
    public IWebElement SubmitBtn => driver.FindElement(By.Id("submit"));
}
