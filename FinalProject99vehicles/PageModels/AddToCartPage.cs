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
    public class AddToCartPage : BasePage
    {
        
        const string allProductsSelector = "//*[@id='main-menu']/div/ul/li[1]"; //XPath
        const string antigelSectionSelector = "//*[@id='main-menu']/div/ul/li[1]/div/ul/li[3]/a/span"; //XPath
        const string antigelProductSelector = "//*[@id='category-page']/div/div[3]/div[2]/div/div[3]/div/div[1]/a/img";  //XPath
        const string addProductToCartSelector = "//a[contains(text(), 'Adauga in cos')]"; //FullXPath
        const string viewCartDetailsPopUpSelector = "#-g-addtocart-popup-default > div.add2cart-pp.catListPP > a.btn.fl"; //Css
        const string lichidDeFranaSectionSelector = "//*[@id='main-menu']/div/ul/li[1]/div/ul/li[6]/a/span"; //Xpath
        const string lichidDeFranaProductSelector = "//*[@id='category-page']/div/div[3]/div[2]/div/div[1]/div/div[1]/a/img"; //XPath
        const string addManyPiecesSelector = "//*[@id='qtyplus']"; //Xpath
        const string aditiviSectionSelector = "//*[@id='main-menu']/div/ul/li[1]/div/ul/li[2]/a/span"; //Xpath
        const string aditivProductSelector = "//*[@id='category-page']/div/div[3]/div[2]/div/div[8]/div/div[1]/a/img"; //Xpath


        public AddToCartPage(IWebDriver driver) : base(driver)
        {
        }

        public void AddToCart()
        {
            var allProduct = driver.FindElement(By.XPath(allProductsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(allProduct).Build().Perform();
            actions.MoveToElement(allProduct).Click();
            var antigelSection = driver.FindElement(By.XPath(antigelSectionSelector));
            antigelSection.Click();
            var antigelProduct = driver.FindElement(By.XPath(antigelProductSelector));
            antigelProduct.Click();
            var addProductToCart = Utils.WaitForElement(driver, 2, By.XPath(addProductToCartSelector));
            addProductToCart.Click();

        }

        public void AddToCartManyProducts()
        {
            var allProduct = driver.FindElement(By.XPath(allProductsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(allProduct).Build().Perform();
            actions.MoveToElement(allProduct).Click();
            var lichidFranaSection = driver.FindElement(By.XPath(lichidDeFranaSectionSelector));
            lichidFranaSection.Click();
            var lichidFranaProduct = driver.FindElement(By.XPath(lichidDeFranaProductSelector));
            lichidFranaProduct.Click();
            var addMannyProductsButton = Utils.WaitForElement(driver,10, By.XPath(addManyPiecesSelector));
            for (int i = 0; i < 2; i++)
            {
                addMannyProductsButton.Click();
            }
            var addProductToCart = Utils.WaitForElement(driver, 5, By.XPath(addProductToCartSelector));
            addProductToCart.Click();
            var CartDetailsPopUp = Utils.WaitForElement(driver, 10, By.CssSelector(viewCartDetailsPopUpSelector)); 
            CartDetailsPopUp.Click();
            


        }

        public void AddToCardAditiv()
        {
            var allProduct = driver.FindElement(By.XPath(allProductsSelector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(allProduct).Build().Perform();
            actions.MoveToElement(allProduct).Click();
            var aditiviSection = driver.FindElement(By.XPath(aditiviSectionSelector));
            aditiviSection.Click();
            var aditivProduct = driver.FindElement(By.XPath(aditivProductSelector));
            aditivProduct.Click();
            var addMannyProductsButton = Utils.WaitForElement(driver, 10, By.XPath(addManyPiecesSelector));
            for (int i = 0; i < 50; i++)
            {
                addMannyProductsButton.Click();
            }
            var addProductToCart = Utils.WaitForElement(driver, 10, By.XPath(addProductToCartSelector));
            addProductToCart.Click();
            var CartDetailsPopUp = Utils.WaitForElement(driver, 10, By.CssSelector(viewCartDetailsPopUpSelector));
            CartDetailsPopUp.Click();

        }
       











    }

}
