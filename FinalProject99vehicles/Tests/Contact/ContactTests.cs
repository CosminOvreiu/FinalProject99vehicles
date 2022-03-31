using FinalProject99vehicles.PageModels;
using FinalProject99vehicles.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject99vehicles.Tests.Contact
{
    class ContactTests : BaseTest
    {
        public ContactTests()
        {
        }

        string url = FrameworkConstants.GetUrl();
        const string wrongEmailMessageLabel = "//span[@class='hint-contact']"; //XPath

        [Test]
        public void ContactSection()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            

            ContactPage cp = new ContactPage(_driver);
            cp.ContactSeller(Utils.GenerateRandomStringCount(10) + "@test.com", "John Wick", "0744000000", "Hello");
            Assert.IsTrue(cp.CheckContactLabel("SC 99VEHICLES MEDIA SRL"));

        }

        [Test]
        public void ContactSectionWrongEmailFormat()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();


            ContactPage cp = new ContactPage(_driver);
            cp.ContactWrongEmail("abcdefgh", "John Wick", "0744000000", "Hello");
            var emailwarning = Utils.WaitForElement(_driver, 5, By.XPath(wrongEmailMessageLabel)).Text;
            Assert.IsTrue(emailwarning.Contains("Adresa de email este obligatorie."));

        }
    }
}
