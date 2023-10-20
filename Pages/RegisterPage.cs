using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Pages
{
    internal class RegisterPage
    {
        private IWebDriver _driver;
        private WebDriverWait ShortWait;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
            ShortWait = new WebDriverWait(_driver, new System.TimeSpan(0, 0, 10));
        }

        //Input Fields
        public IWebElement FirsNameInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.firstName']")));
        public IWebElement LastNameInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.lastName']")));
        public IWebElement Addressnput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.address.street']")));
        public IWebElement CityInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.address.city']")));
        public IWebElement StateInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.address.state']")));
        public IWebElement ZipCodeInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.address.zipCode']")));
        public IWebElement PhoneInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.phoneNumber']")));
        public IWebElement SSNInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.ssn']")));
        public IWebElement UsernameInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.username']")));
        public IWebElement PasswordInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'customer.password']")));
        public IWebElement ConfirmPWInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@id = 'repeatedPassword']")));

        //Hyperlink
        public IWebElement RegisterLink => ShortWait.Until(d => d.FindElement(By.XPath("//*[text() = 'Register']")));

        //Button
        public IWebElement RegisterButton => ShortWait.Until(d => d.FindElement(By.XPath("//input[@value = 'Register']")));

        //Heading
        public IWebElement WelcomeHeading(string title) => ShortWait.Until(d => d.FindElement(By.XPath("//h1[text()='"+title+"']")));

        //Message
        public IWebElement AccountCreateSuccessMsg => ShortWait.Until(d => d.FindElement(By.XPath("//*[text()='Your account was created successfully. You are now logged in.']")));


        

    }

    public class SignUpForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string SSN { get; set; }
    }
}
