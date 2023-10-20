using SpecFlowProject.Pages;
using SpecFlowProject.Support;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class AccountOverviewSteps
    {
        private WebDriverSupport _driverSupport;
        AccountOverviewPage accountOverviewPage;

        public AccountOverviewSteps(WebDriverSupport driverSupport)
        {
            _driverSupport = driverSupport;
            accountOverviewPage = new AccountOverviewPage(_driverSupport.Driver);
        }

        [Then(@"the user should be landed in AccountOverview page")]
        public void ThenTheUserShouldBeLandedInAccountOverviewPage()
        {
            bool AccountOverviewFlag = accountOverviewPage.AccountOverviewHeading.Displayed;
            Assert.True(AccountOverviewFlag, "Account Overview Heading did not display");       
                
        }

        [When(@"I click on Accounts Overview Hyperlink")]
        public void WhenIClickOnAccountsOverviewHyperlink()
        {
            accountOverviewPage.AccountOverviewLink.Click();
        }

        [Then(@"the following values should be displayed in Account Overview Page")]
        public void ThenTheFollowingValuesShouldBeDisplayedInAccountOverviewPage(Table table)
        {
            var Rows = table.CreateSet<AccountTable>();
            foreach (var row in Rows)
            {
                Assert.AreEqual(row.Account, accountOverviewPage.AccountNumber.Text, "Account number does not match");                
                Assert.AreEqual(row.Balance, accountOverviewPage.Balance(row.Account).Text, "Balance does not match for account: "+row.Account);                
                Assert.AreEqual(row.AvailableAmount, accountOverviewPage.AvailableAmount(row.Account).Text, "Available Amount does not match for account: "+row.Account);                
            }
        }

    }
}