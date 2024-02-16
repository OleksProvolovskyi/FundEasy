using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace FundEasy.Pages
{
    public class CampaignCreationPage
    {
        IWebDriver driver = ScenarioContext.Current["driver"] as IWebDriver;

        public IWebElement CampaignName => driver.FindElement(By.Id("companyName"));
        public IWebElement TaxId => driver.FindElement(By.Id("taxId"));
        public SelectElement BusinessType => new SelectElement(driver.FindElement(By.Id("businessType")));
        public IWebElement Country => driver.FindElement(By.Id("country"));

        public IWebElement CreateButton => driver.FindElement(By.Id("createButton"));

        public IWebElement ToastMessage => driver.FindElement(By.Id("toastMessage"));
    }
}
