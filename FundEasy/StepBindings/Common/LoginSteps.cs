using FundEasy.Contexts;
using TechTalk.SpecFlow;

namespace FundEasy.StepBindings.Common
{
    public class LoginSteps
    {
        private LoginContext _loginContext = new LoginContext();

        [When(@"I login")]
        public void ILogin()
        {
            _loginContext.LogIn("InvestorUser", "Password123!");
        }
    }
}
