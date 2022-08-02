using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorSUTests.PageObjects
{
    public class LoginPage
    {
        private IWebDriver Driver { get; }
        public LoginPage(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver,this);
        }

        private readonly By email = By.Id("email");
        private readonly By password = By.Id("password");
        private readonly By login = By.Name("button.button");

        private IWebElement TxtEmail => Driver.FindElement(email);
        private IWebElement TxtPassword => Driver.FindElement(email);
        private IWebElement BtnLogin => Driver.FindElement(login);

        public void Login(string email, string password)
        {
            TxtEmail.SendKeys(email);
            TxtPassword.SendKeys(password);
            BtnLogin.Click();
        }
    }
}
