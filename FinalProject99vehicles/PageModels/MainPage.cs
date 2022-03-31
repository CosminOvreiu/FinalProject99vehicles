using FinalProject99vehicles.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject99vehicles.PageModels
{
    class MainPage : BasePage
    {
        const string closeOpenBannerSelector = "/html/body/div[7]/div[2]/div[4]/div/div/div/div[3]/div[1]/a[2]"; //FullXpath
        const string acceptCookiesSelector = "__gomagCookiePolicy"; // Id
        const string loginButtonSelector = "/html/body/div[2]/header/div[2]/div/div/div[3]/ul/li[1]/a/span"; //FullXpath

        public MainPage(IWebDriver driver) : base(driver)
        {
        }


        public void CloseOpenBanner()
        {
            var closeBanner = Utils.WaitForElement(driver, 20, By.XPath(closeOpenBannerSelector));
            closeBanner.Click();

            driver.FindElement(By.Id(acceptCookiesSelector)).Click();
        }

        public void MoveToLoginPage()
        {
            driver.FindElement(By.XPath(loginButtonSelector)).Click();
        }

    }
}
