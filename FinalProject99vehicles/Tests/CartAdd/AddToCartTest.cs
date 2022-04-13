using FinalProject99vehicles.PageModels;
using FinalProject99vehicles.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject99vehicles.Tests.CartAdd
{
    class AddToCartTests : BaseTest
    {
        public AddToCartTests()
        {
        }

        string url = FrameworkConstants.GetUrl();

        const string checkPageLabelSelector = "//b[contains(text(), 'Durata de livrare:')]"; //XPath
        const string final = "//a[@class='btn btn-cmd center']"; //xpath

        [Test]
        public void AddToCart() 
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

            AddToCartPage ap = new AddToCartPage(_driver);
            ap.AddToCart();
            var deliveryInfo = Utils.WaitForElement(_driver, 10, By.XPath(checkPageLabelSelector)).Text;
            Assert.IsTrue(deliveryInfo.Contains("Durata de livrare:"));

        }


        [Test]
        public void AddToCartManyP()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            lp.Login("radu.serban18@yahoo.ro", "123456");

            AddToCartPage ap = new AddToCartPage(_driver);
            ap.AddToCartManyProducts();
            var finalbutton = Utils.WaitForElement(_driver, 5, By.XPath(final)).Text;
            Assert.IsTrue(finalbutton.Contains("FINALIZEAZA COMANDA"));

        }

        [Test]
        public void AddToCartAditivX()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
            mp.MoveToLoginPage();

            LoginPage lp = new LoginPage(_driver);
            lp.Login("radu.serban188@yahoo.ro", "123456");

            AddToCartPage ap = new AddToCartPage(_driver);
            ap.AddToCardAditiv();
            var finalbuttonxxx = Utils.WaitForElement(_driver, 10, By.XPath(final)).Text;
            Assert.IsTrue(finalbuttonxxx.Contains("FINALIZEAZA COMANDA"));


        }








    }
}
