using SpecFlowProject.Configuration;
using SpecFlowProject.Pages;
using SpecFlowProject.Support;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        private WebDriverSupport _driverSupport;
        private WebsiteInfo _siteInfo;
        LoginPage loginPage;

        public LoginSteps(WebDriverSupport driverSupport)
        {
            _driverSupport = driverSupport;
            _siteInfo = _driverSupport.WebsiteInfo;
            loginPage = new LoginPage(_driverSupport.Driver);
        }

        [Given(@"I navigate to ParaBank application")]
        public void GivenINavigateToParaBankApplication()
        {
            _driverSupport.Driver.Navigate().GoToUrl(_siteInfo.Url);
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword()
        {
            loginPage.UsernameInput.SendKeys(_siteInfo.Username);
            loginPage.PasswordInput.SendKeys(_siteInfo.Password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.LoginButton.Click();
        }

        [When(@"I click logout button")]
        public void WhenIClickLogoutButton()
        {
            loginPage.LogoutButton.Click();
        }

        [Then(@"the user should be redirected to login page")]
        public void ThenTheUserShouldBeRedirectedToLoginPage()
        {
            bool CSLogingHeadingFlag = loginPage.CustomerLoginHeading.Displayed;
            Assert.True(CSLogingHeadingFlag, "Customer Login Heading did not display");
        }

    }
}