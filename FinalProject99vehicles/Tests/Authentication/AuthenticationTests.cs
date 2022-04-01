using FinalProject99vehicles.PageModels;
using FinalProject99vehicles.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;



namespace FinalProject99vehicles.Tests.Authentication
{
    public class AuthenticationTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        const string recoverPassErrorMessageLabel = "//span[@class='hint-order']"; //Xpath




         [Test]
         public void AuthenticationPositive()

        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            Assert.IsTrue(lp.CheckLoginLabel("Contul tau"));
            lp.Login("radu.serban18@yahoo.ro", "123456");
           

        }


        [Test]
        public void ForgotPassAuthentication()

        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            lp.ForgotPassword("radu.serban18@yahoo.ro");
            Assert.IsTrue(lp.recoverPassLabel("RECUPERARE PAROLA"));

        }


        [Test]
        public void ForgotPassErrorEmailInput()

        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            lp.ForgotPasswordWrongEmailInput("adrian21");
            var recoverPassErrMessage = Utils.WaitForElement(_driver, 2, By.XPath(recoverPassErrorMessageLabel)).Text;
            Assert.IsTrue(recoverPassErrMessage.Contains("- Adresa de email este invalida."));
        }









    }
}
