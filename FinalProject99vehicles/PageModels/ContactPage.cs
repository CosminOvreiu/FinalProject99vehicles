using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject99vehicles.PageModels
{
    class ContactPage : BasePage
    {
        
        const string contactSelector = "#main-menu > div > ul > li:nth-child(2) > a"; //Css
        const string emailInputSelector = "email"; // Id
        const string nameInputSelector = "lastname"; // Name
        const string phoneInputSelector = "phone"; // Name
        const string yourMessageInputSelector = "message"; // Name
        const string termsAndConditionInputSelector = "agreePersonalInformation"; // Name
        const string sendMessageButtonSelector = "sendMessage"; // Id 
        const string contactLabelSelector = "//h3[@class='title'][contains(text(), '99Vehicles')]"; // Xpath
       



        public Boolean CheckContactLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(contactLabelSelector)).Text);
        }

        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        public void ContactSeller(string email, string name, string phone, string message)
        {
            var contactButtonInput = driver.FindElement(By.CssSelector(contactSelector));
            contactButtonInput.Click();
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var nameInput = driver.FindElement(By.Name(nameInputSelector));
            nameInput.Clear();
            nameInput.SendKeys(name);
            var phoneInput = driver.FindElement(By.Name(phoneInputSelector));
            phoneInput.Clear();
            phoneInput.SendKeys(phone);
            var yourMessageInput = driver.FindElement(By.Name(yourMessageInputSelector));
            yourMessageInput.Clear();
            yourMessageInput.SendKeys(message);
            var termsAndConditionInput = driver.FindElement(By.Name(termsAndConditionInputSelector));
            termsAndConditionInput.Click();
            var sendMessageButton = driver.FindElement(By.Id(sendMessageButtonSelector));
            sendMessageButton.Submit();


        }

        public void ContactWrongEmail(string email, string name, string phone, string message)
        {
            var contactButtonInput = driver.FindElement(By.CssSelector(contactSelector));
            contactButtonInput.Click();
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var nameInput = driver.FindElement(By.Name(nameInputSelector));
            nameInput.Clear();
            nameInput.SendKeys(name);
            var phoneInput = driver.FindElement(By.Name(phoneInputSelector));
            phoneInput.Clear();
            phoneInput.SendKeys(phone);
            var yourMessageInput = driver.FindElement(By.Name(yourMessageInputSelector));
            yourMessageInput.Clear();
            yourMessageInput.SendKeys(message);
            var termsAndConditionInput = driver.FindElement(By.Name(termsAndConditionInputSelector));
            termsAndConditionInput.Click();
            var sendMessageButton = driver.FindElement(By.Id(sendMessageButtonSelector));
            sendMessageButton.Submit();


        }




    }
}
