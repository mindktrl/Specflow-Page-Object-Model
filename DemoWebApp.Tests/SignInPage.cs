using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    public class SignInPage
    {
        private readonly IWebDriver _driver;
        private const string PageUri = @"http://executeautomation.com/demosite/Login.html";

        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static SignInPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new SignInPage(driver);
        }

        public string usernameElement
        {
            set
            {
                _driver.FindElement(By.Name("UserName")).SendKeys(value);
            }
        }

        public string passwordElement
        {
            set
            {
                _driver.FindElement(By.Name("Password")).SendKeys(value);
            }
        }

        public void clickLoginButton()
        {
            _driver.FindElement(By.XPath("//*[@id='userName']/p[3]/input")).Click();
        }

        public void logoutButtonDisplayed()
        {
            _driver.FindElement(By.XPath("//*[@id='cssmenu']/ul/li[1]/a/span")).Displayed.Equals(true);
        }

        public void clickLogoutButton()
        {
            _driver.FindElement(By.XPath("//*[@id='cssmenu']/ul/li[1]/a/span")).Click();
        }
    }
}








