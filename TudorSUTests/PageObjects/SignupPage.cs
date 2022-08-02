using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorSUTests.PageObjects
{
    public class SignupPage
    {
        private IWebDriver Driver { get; }
        public SignupPage(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        private readonly By firstname = By.Id("fname");
        private readonly By lastname = By.Id("lname");
        private readonly By email = By.Id("email");
        private readonly By password = By.Id("password");
        private readonly By singup = By.Name("button.button");

        private IWebElement TxtFirstName => Driver.FindElement(firstname);
        private IWebElement TxtLastName => Driver.FindElement(lastname);
        private IWebElement TxtEmail => Driver.FindElement(email);
        private IWebElement TxtPassword => Driver.FindElement(password);
        private IWebElement BtnSignup => Driver.FindElement(singup);

        public void SignUp(string firstname, string lastname, string email, string password)
        {
            TxtFirstName.SendKeys(firstname);
            TxtLastName.SendKeys(lastname);
            TxtEmail.SendKeys(email);
            TxtPassword.SendKeys(password);
            BtnSignup.Click();
        }
    }
}
