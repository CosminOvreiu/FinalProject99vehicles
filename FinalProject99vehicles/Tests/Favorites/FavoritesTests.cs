using FinalProject99vehicles.PageModels;
using FinalProject99vehicles.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject99vehicles.Tests.Favorites
{
    class FavoritesTests : BaseTest
    {
        public FavoritesTests()
        {
        }

        string url = FrameworkConstants.GetUrl();
        

        [Test]
        public void AddToFavorites()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();
           
            FavoritesPage fp = new FavoritesPage(_driver);
            fp.AddToFavorites();
            Assert.IsTrue(fp.CheckFavoritesLabel("Wishlist"));

        }


        [Test]
        public void AddToFavoritesAndDelete()
        {
            testName = TestContext.CurrentContext.Test.Name;
            _test = _extent.CreateTest(testName);
            _driver.Navigate().GoToUrl(url);
            MainPage mp = new MainPage(_driver);
            mp.CloseOpenBanner();

            FavoritesPage fp = new FavoritesPage(_driver);
            fp.AddToFavoritesAndDeleteProduct();
            Assert.IsTrue(fp.deleteLabel("Produsul a fost sters cu succes."));
           
        }







    }   
}
