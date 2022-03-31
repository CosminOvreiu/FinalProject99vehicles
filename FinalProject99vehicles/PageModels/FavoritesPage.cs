using FinalProject99vehicles.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject99vehicles.PageModels
{
    class FavoritesPage : BasePage
    {
        const string allProductsSelector = "//*[@id='main-menu']/div/ul/li[1]"; //XPath
        const string vaselineSectionSelector = "//*[@id='main-menu']/div/ul/li[1]/div/ul/li[18]/a/span"; //XPath
        const string vaselineProductSelector = "//*[@id='category-page']/div/div[3]/div[2]/div/div/div/div[1]/a/img"; //XPath
        const string addProductToFavoritesSelector = "//*[@id='product-page']/div[1]/div[1]/div[3]/div[7]/a[1]";  //Xpath
        const string favoritesSectionSelector = "//*[@id='wrapper']/header/div[2]/div/div/div[3]/ul/li[3]/a/span[2]"; //Xpath
        const string closePopupAddToFavoritesSelector = "/html/body/div[5]/img";  //XPath
        const string favoriteLabelSelector = "/html/body/div[2]/div[3]/div/div[2]/h3"; //XPath
        const string filtreSectionSelector = "/html/body/div[2]/header/div[4]/nav/div/ul/li[1]/div/ul/li[5]/a/span"; //Xpath
        const string filtruProductSelector = "//a[text()='FILTRU AER MANN C35154']"; //Xpath
        const string deleteProductButtonSelector = "//i[@class='fa fa-trash-o']"; //Xpath
        const string deleteProductMessageLabel = "//div[@class='succes center  mrg-b-20']"; //XPath



        public FavoritesPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckFavoritesLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(favoriteLabelSelector)).Text);
        }

        public Boolean deleteLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(deleteProductMessageLabel)).Text);
        }

       

   
        public void AddToFavorites()
        {
            var allProduct = driver.FindElement(By.XPath(allProductsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(allProduct).Build().Perform();
            actions.MoveToElement(allProduct).Click();
            var vaselineSection = driver.FindElement(By.XPath(vaselineSectionSelector));
            vaselineSection.Click();
            var vaselineProduct = driver.FindElement(By.XPath(vaselineProductSelector));
            vaselineProduct.Click();
            var addProductToFavorites = Utils.WaitForElement(driver, 2, By.XPath(addProductToFavoritesSelector));
            addProductToFavorites.Click();
            var closePopupAddToFavorites = Utils.WaitForElement(driver, 2, By.XPath(closePopupAddToFavoritesSelector));
            closePopupAddToFavorites.Click();
            var favoritesSection = Utils.WaitForElement(driver, 2, By.XPath(favoritesSectionSelector));
            favoritesSection.Click();

        }

        public void AddToFavoritesAndDeleteProduct()
        {
            var allProduct = driver.FindElement(By.XPath(allProductsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(allProduct).Build().Perform();
            actions.MoveToElement(allProduct).Click();
            var filtruSection = driver.FindElement(By.XPath(filtreSectionSelector));
            filtruSection.Click();
            var filtruProduct = driver.FindElement(By.XPath(filtruProductSelector));
            filtruProduct.Click();
            var addProductToFavorites = Utils.WaitForElement(driver, 2, By.XPath(addProductToFavoritesSelector));
            addProductToFavorites.Click();
            var closePopupAddToFavorites = Utils.WaitForElement(driver, 2, By.XPath(closePopupAddToFavoritesSelector));
            closePopupAddToFavorites.Click();
            var favoritesSection = Utils.WaitForElement(driver, 2, By.XPath(favoritesSectionSelector));
            favoritesSection.Click();
            var deleteProduct = Utils.WaitForElement(driver, 3, By.XPath(deleteProductButtonSelector));
            deleteProduct.Click();




        }




    }
}
