using FundEasy.Models;
using FundEasy.Pages;

namespace FundEasy.Contexts
{
    public class CampaignCreationContext
    {
        private CampaignCreationPage _campaignCreationPage = new CampaignCreationPage();

        public void FeelMandatoryFields(Campaign company)
        {
            _campaignCreationPage.CampaignName.SendKeys(company.CampaignName);
            _campaignCreationPage.TaxId.SendKeys(company.TaxId);
            _campaignCreationPage.Country.SendKeys(company.Country);
            _campaignCreationPage.BusinessType.SelectByValue(company.BusinessType);
        }

        public void SaveCampaign() => _campaignCreationPage.CreateButton.Click();

        public string GetToastMessageText => _campaignCreationPage.ToastMessage.Text;

        public bool IsToastMessageDisplayed => _campaignCreationPage.ToastMessage.Displayed;
    }
}
