using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TudorSUTests.PageObjects;

namespace TudorSUTests
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:4200/login");
        }

        [TestMethod]
        public void TestLogin_SuccessfullyLogin()
        {
            Thread.Sleep(millisecondsTimeout: 3000);
            var login = new LoginPage(driver);
            //login.Login(email:"random@email.com", password:"random");
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
