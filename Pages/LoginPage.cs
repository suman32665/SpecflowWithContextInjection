using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Pages
{
    internal class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait ShortWait;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            ShortWait = new WebDriverWait(_driver, new System.TimeSpan(0, 0, 10));
        }

        //Input Fields
        public IWebElement UsernameInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@name = 'username']")));
        public IWebElement PasswordInput => ShortWait.Until(d => d.FindElement(By.XPath("//*[@name = 'password']")));


        //Button
        public IWebElement LoginButton => ShortWait.Until(d => d.FindElement(By.XPath("//*[@value = 'Log In']")));
        public IWebElement LogoutButton => ShortWait.Until(d => d.FindElement(By.XPath("//*[text()='Log Out']")));


        //Heading
        public IWebElement CustomerLoginHeading => ShortWait.Until(d => d.FindElement(By.XPath("//h2[text()='Customer Login']")));



    }
}
