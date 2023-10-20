using SpecFlowProject.Configuration;
using SpecFlowProject.Pages;
using SpecFlowProject.Support;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class RegisterSteps
    {
        private WebDriverSupport _driverSupport;
        private WebsiteInfo _siteInfo;
        RegisterPage registerPage;
        

        public RegisterSteps(WebDriverSupport driverSupport)
        {
            _driverSupport = driverSupport;
            registerPage = new RegisterPage(_driverSupport.Driver);
            _siteInfo = _driverSupport.WebsiteInfo;
        }

        [Given(@"I click on Register for new registration")]
        public void GivenIClickOnRegisterForNewRegistration()
        {
            registerPage.RegisterLink.Click();
        }

        [Given(@"I fill up the sign up form")]
        public void GivenIFillUpTheSignUpForm(Table table)
        {
            var Rows = table.CreateSet <SignUpForm> ();
            var row=Rows.ElementAt(0);
            registerPage.FirsNameInput.SendKeys(row.FirstName);
            registerPage.LastNameInput.SendKeys(row.LastName);
            registerPage.Addressnput.SendKeys(row.Address);
            registerPage.CityInput.SendKeys(row.City);
            registerPage.StateInput.SendKeys(row.State);
            registerPage.ZipCodeInput.SendKeys(row.ZipCode);
            registerPage.PhoneInput.SendKeys(row.Phone);
            registerPage.SSNInput.SendKeys(row.SSN);
            registerPage.UsernameInput.SendKeys(_siteInfo.Username);
            registerPage.PasswordInput.SendKeys(_siteInfo.Password);
            registerPage.ConfirmPWInput.SendKeys(_siteInfo.Password);
        }

        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            registerPage.RegisterButton.Click();
        }

        [Then(@"user should be landed in Welcome page with heading '([^']*)'")]
        public void ThenUserShouldBeLandedInWelcomePageWithHeading(string heading)
        {
            heading = heading.Replace("username", _siteInfo.Username);
            bool flag = registerPage.WelcomeHeading(heading).Displayed;
            Assert.True(flag, "Register Heading did not display: " + heading);

        }

        [Then(@"the account created successfully message should be displayed")]
        public void ThenTheAccountCreatedSuccessfullyMessageShouldBeDisplayed()
        {
            bool flag = registerPage.AccountCreateSuccessMsg.Displayed;
            Assert.True(flag, "Account Created Success Message did not display");
        }

    }
}