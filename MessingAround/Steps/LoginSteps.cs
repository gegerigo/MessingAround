using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MessingAround.Steps
{
	[Binding]
	public class LoginSteps
	{
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
