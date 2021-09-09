using MessingAround.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MessingAround.Steps
{
	[Binding]
	public class LoginSteps : DriverHelper
	{
        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword((string)data.UserName,(string)data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(homePage.IsLogOffExists(), Is.True, "Log off button does not exist.");
        }

    }
}
