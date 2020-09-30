using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowDemo
{
    [Binding]
    public class SignInSteps
    {
        
        private IWebDriver _driver;
        private SignInPage _signInPage;

        [BeforeScenario]
        public void OutputScenario()
        {
            Console.WriteLine("Feature: " + FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine(FeatureContext.Current.FeatureInfo.Description);
            Console.WriteLine("\r\nScenario: " + ScenarioContext.Current.ScenarioInfo.Title);
        }

        [Given(@"the user is on the sign in page")]
        public void GivenTheUserIsOnTheSignInPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _signInPage = SignInPage.NavigateTo(_driver);
        }

        [When(@"the user enters username ""(.*)""")]
        public void WhenTheUserEntersUsername(string un)
        {
            _signInPage.usernameElement = un;
        }

        [When(@"the user enters a password ""(.*)""")]
        public void WhenTheUserEntersAPassword(string password)
        {
            _signInPage.passwordElement = password;
        }

        [When(@"the user clicks the login button")]
        public void WhenTheUserClicksTheLoginButton()
        {
            _signInPage.clickLoginButton();
        }

        [Then(@"the user should be logged in")]
        public void ThenTheUserShouldBeLoggedIn()
        {
            _signInPage.logoutButtonDisplayed();
        }

        [Then(@"the user can sign out by clicking the logout button")]
        public void ThenTheUserCanSignOutByClickingTheLogoutButton()
        {
            _signInPage.clickLogoutButton();
        }
    }
}
