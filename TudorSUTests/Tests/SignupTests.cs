using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TudorSUTests.PageObjects;

namespace TudorSUTests
{
    [TestClass]
    public class SignupTests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:4200/signup");
        }

        [TestMethod]
        public void TestSignup_SuccessfullySignUp()
        {
            Thread.Sleep(millisecondsTimeout: 3000);
            var signup = new SignupPage(driver);
            //signup.SignUp(firstname: "Tudor", lastname: "Portal", email: "tudorportal@gmail.com", password: "aciasi");
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
