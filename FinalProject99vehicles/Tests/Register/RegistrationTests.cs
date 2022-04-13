using FinalProject99vehicles.PageModels;
using FinalProject99vehicles.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject99vehicles.Tests.Register
{
    public class RegistrationTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();
        const string existingEmailLabelSelector = "//span[@class='hint-login']"; //Xpath

        [Test]
        public void RegisterTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            _driver.Navigate().GoToUrl(url + registrationUrlPath);
            RegistrationPage rp = new RegistrationPage(_driver);
            Assert.IsTrue(rp.CheckRegistrationLabel("Client nou: Inregistrare"));  
            rp.RegisterUser(Utils.GenerateRandomStringCount(10) + "@test.com", "Wick", "John", Utils.GenerateRandomStringCount(10));

        }

        [Test]
        public void RegisterEmailLessTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            _driver.Navigate().GoToUrl(url + registrationUrlPath);
            RegistrationPage rp = new RegistrationPage(_driver);
            rp.RegisterUserEmailLess("", "Wick", "John", Utils.GenerateRandomStringCount(10));
            Assert.IsTrue(rp.CheckEmailLessLabel("Adresa de email este obligatorie."));
        }


        [Test]
        public void RegisterRepeatPassDiferentTest()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            _driver.Navigate().GoToUrl(url + registrationUrlPath);
            RegistrationPage rp = new RegistrationPage(_driver);
            rp.RegisterUserRepeatPassDiferent (Utils.GenerateRandomStringCount(10) + "@test.com", "Wick", "John", Utils.GenerateRandomStringCount(10), Utils.GenerateRandomStringCount(5));
            Assert.IsTrue(rp.CheckRepeatPassLabel("Parolele nu corespund."));
        }


        [Test]
        public void RegisterTestExistingEmail()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            _driver.Navigate().GoToUrl(url + registrationUrlPath);
            RegistrationPage rp = new RegistrationPage(_driver);
            //Assert.IsTrue(rp.CheckExistingPassLabel("Adresa de email exista in baza de date. Va rugam sa va logati."));
            rp.RegisterUserExistingEmail("test@test1.com", "Wick", "John", Utils.GenerateRandomStringCount(10));
            var existingEmailMessage = Utils.WaitForElement(_driver, 2, By.XPath(existingEmailLabelSelector)).Text;
            Assert.IsTrue(existingEmailMessage.Contains("Adresa de email exista in baza de date. Va rugam sa va logati."));
        }


    }
}
