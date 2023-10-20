using System;


namespace SpecFlowProject.Pages
{
    internal class AccountOverviewPage
    {
        private IWebDriver _driver;
        private WebDriverWait ShortWait;

        public AccountOverviewPage(IWebDriver driver)
        {
            _driver = driver;
            ShortWait = new WebDriverWait(_driver, new System.TimeSpan(0, 0, 10));
        }

        //Heading
        public IWebElement AccountOverviewHeading => ShortWait.Until(d => d.FindElement(By.XPath("//h1[text()='Accounts Overview']")));

        //Hyperlink
        public IWebElement AccountOverviewLink => ShortWait.Until(d => d.FindElement(By.XPath("//a[text()='Accounts Overview']")));

        //Account and Amount Assertions
        public IWebElement AccountNumber => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id='accountTable']//td//a")));
        public IWebElement Balance(string acn) => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id='accountTable']//*[text()='"+acn+"']/ancestor::td/following-sibling::td[1]")));
        public IWebElement AvailableAmount(string acn) => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id='accountTable']//*[text()='"+acn+"']/ancestor::td/following-sibling::td[2]")));

    }

    public class AccountTable
    {
        public string Account { get; set; }
        public string Balance { get; set; }
        public string AvailableAmount { get; set; }
    }
}
