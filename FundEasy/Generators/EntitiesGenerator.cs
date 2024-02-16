using FundEasy.Models;

namespace FundEasy.Generators
{
    public class EntitiesGenerator
    {
        public static Campaign GenerateCampaign()
        {
            var company = new Campaign
            {
                CampaignName = "TestCampaign",
                TaxId = "1234567890",
                BusinessType = "Private",
                Country = "UK"
            };

            return company;
        }
    }
}
