using FundEasy.Contexts;
using FundEasy.Generators;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FundEasy.StepBindings.CollectorPortal
{
    public class CampaignCreationSteps
    {
        private CampaignCreationContext _campaignCreationContext = new CampaignCreationContext();

        [Given(@"I fill out the form with valid details")]
        [When(@"I fill out the form with valid details")]
        public void IFeelCampaignMandatoryFields()
        {
            var company = EntitiesGenerator.GenerateCampaign();

            _campaignCreationContext.FeelMandatoryFields(company);
        }

        [Given(@"I submit the form")]
        [When(@"I submit the form")]
        public void IClickSaveButton()
        {
            _campaignCreationContext.SaveCampaign();
        }

        [Then(@"I should see a confirmation of campaign creation")]
        public void CampaignCreationVerification()
        {
            var expectedMessage = "Campaign was successfully created";
            var actualMessage = _campaignCreationContext.GetToastMessageText;

            Assert.That(_campaignCreationContext.IsToastMessageDisplayed.Equals(true) &&
                actualMessage.Equals(expectedMessage), "Campaign wasn't created!");
        }
    }
}
