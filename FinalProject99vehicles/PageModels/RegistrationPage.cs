using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject99vehicles.PageModels
{
    public class RegistrationPage : BasePage
    {
        const string registrationLabelSelector = "//h1[@class='title'][contains(text(),'Inregistrare')]"; // XPath
        const string emailInputSelector = "__emailRegister"; // Id
        const string lastNameInputSelector = "__lastnameRegister"; // Id
        const string firstNameInputSelector = "__firstnameRegister"; // Id
        const string passwordInputSelector = "__passwordRegister"; // Id
        const string repeatPasswordInputSelector = "__confirmPasswordRegister"; // Id
        const string termsAndConditionInputSelector = "agreePersonalInformation"; // Name
        const string registerButtonSelector = "doRegister"; // Id
        const string registrationEmailLabelSelector = "//span[@class='hint-login'][contains(text(),'email')]"; //XPath
        const string repeatPassLabelSelector = "//span[@class='hint-login'][contains(text(),'Parolele')]"; //Xpath
       



        public Boolean CheckRegistrationLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(registrationLabelSelector)).Text);
        }

        public Boolean CheckEmailLessLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(registrationEmailLabelSelector)).Text);
        }

        public Boolean CheckRepeatPassLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(repeatPassLabelSelector)).Text);
        }

       
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }




        public void RegisterUser(string email, string lastName, string firstName, string password)
        {
            var registerButtonInput = driver.FindElement(By.Id(registerButtonSelector));
            registerButtonInput.Click();
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lastName);
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(firstName);
            var passwordInput = driver.FindElement(By.Id(passwordInputSelector));
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            var repeatPasswordInput = driver.FindElement(By.Id(repeatPasswordInputSelector));
            repeatPasswordInput.Clear();
            repeatPasswordInput.SendKeys(password);
            var termsAndConditionInput = driver.FindElement(By.Name(termsAndConditionInputSelector));
            termsAndConditionInput.Click();
            var submitButton = driver.FindElement(By.Id(registerButtonSelector));
            submitButton.Submit();
        }


        public void RegisterUserEmailLess (string email, string lastName, string firstName, string password)
        {
            var registerButtonInput = driver.FindElement(By.Id(registerButtonSelector));
            registerButtonInput.Click();
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lastName);
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(firstName);
            var passwordInput = driver.FindElement(By.Id(passwordInputSelector));
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            var repeatPasswordInput = driver.FindElement(By.Id(repeatPasswordInputSelector));
            repeatPasswordInput.Clear();
            repeatPasswordInput.SendKeys(password);
            var termsAndConditionInput = driver.FindElement(By.Name(termsAndConditionInputSelector));
            termsAndConditionInput.Click();
            var submitButton = driver.FindElement(By.Id(registerButtonSelector));
            submitButton.Submit();
        }


        public void RegisterUserRepeatPassDiferent (string email, string lastName, string firstName, string password, string repeatpassword)
        {
            var registerButtonInput = driver.FindElement(By.Id(registerButtonSelector));
            registerButtonInput.Click();
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lastName);
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(firstName);
            var passwordInput = driver.FindElement(By.Id(passwordInputSelector));
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            var repeatPasswordInput = driver.FindElement(By.Id(repeatPasswordInputSelector));
            repeatPasswordInput.Clear();
            repeatPasswordInput.SendKeys(repeatpassword);
            var termsAndConditionInput = driver.FindElement(By.Name(termsAndConditionInputSelector));
            termsAndConditionInput.Click();
            var submitButton = driver.FindElement(By.Id(registerButtonSelector));
            submitButton.Submit();   
        }


        public void RegisterUserExistingEmail(string email, string lastName, string firstName, string password)
        {
            var registerButtonInput = driver.FindElement(By.Id(registerButtonSelector));
            registerButtonInput.Click();
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lastName);
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(firstName);
            var passwordInput = driver.FindElement(By.Id(passwordInputSelector));
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            var repeatPasswordInput = driver.FindElement(By.Id(repeatPasswordInputSelector));
            repeatPasswordInput.Clear();
            repeatPasswordInput.SendKeys(password);
            var termsAndConditionInput = driver.FindElement(By.Name(termsAndConditionInputSelector));
            termsAndConditionInput.Click();
            var submitButton = driver.FindElement(By.Id(registerButtonSelector));
            submitButton.Submit();
        }

    }
}
