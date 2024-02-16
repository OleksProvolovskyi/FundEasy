using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FundEasy.Helpers;

[Binding]
public class Hooks
{
    private static IWebDriver driver;

    [BeforeScenario]
    public void InitializeTest()
    {
        driver = WebdriverBuilder.GetChromeInstances();
        driver.Manage().Window.Maximize();
        ScenarioContext.Current["driver"] = driver;
    }

    [AfterScenario]
    public void CleanUp()
    {
        driver.Quit();
    }
}