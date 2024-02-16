using OpenQA.Selenium.Chrome;

namespace FundEasy.Helpers
{
    public static class WebdriverBuilder
    {
        public static ChromeDriver GetChromeInstances()
        {
            var service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);

            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", AppDomain.CurrentDomain.BaseDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", true);
            options.AddUserProfilePreference("disable-popup-blocking", true);

            options.AddArgument("start-maximized");
            options.AddArgument("disable-infobars");
            options.AddArguments("--disable-extensions");
            options.AddArgument("no-sandbox");

            ChromeDriver driver = new ChromeDriver(service, options);

            return driver;
        }
    }
}
