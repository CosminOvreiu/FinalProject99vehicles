using FinalProject99vehicles.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject99vehicles.PageModels
{
    public class LoginPage : BasePage
    {
        const string emailSelector = "_loginEmail"; // Id
        const string passwordSelector = "_loginPassword"; //Id
        const string loginButtonSelector = "doLogin"; // Id
        const string forgotPasswordSelector = "client-pass-recov"; //Class
        const string loginLabelSelector = "//h1[@class='title'][contains(text(),'Contul tau')]"; //XPath
        const string emailForgotPassSectionSelector = "//div[@class='col-lg-12']//input"; //XPath
        const string sentButtonForgotPassSelector = "//*[@id='_doRecover']"; //Xpath
        const string recoverPasswordLabel = "//p[@class='head-pp']"; //Xpath
       

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public Boolean CheckLoginLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(loginLabelSelector)).Text);
        }

        public Boolean recoverPassLabel(string label)
        {
            return String.Equals(label, driver.FindElement(By.XPath(recoverPasswordLabel)).Text);
        }

      


        public void Login(string email, string password)
        {
            var emailInput = driver.FindElement(By.Id(emailSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var passwordInput = driver.FindElement(By.Id(passwordSelector));
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            var loginButton = driver.FindElement(By.Id(loginButtonSelector));
            loginButton.Submit();
        }


        public void ForgotPassword(string email)
        {
            var forgotpass = driver.FindElement(By.ClassName(forgotPasswordSelector));
            forgotpass.Click();
            var iframeDoc = driver.FindElement (By.XPath("//iframe"));
            driver.SwitchTo().Frame(iframeDoc);
            var emailForgotPassInput = driver.FindElement(By.XPath(emailForgotPassSectionSelector));
            emailForgotPassInput.Clear();
            emailForgotPassInput.SendKeys(email);
            var sentButtonForgotPass = driver.FindElement(By.XPath(sentButtonForgotPassSelector));
            sentButtonForgotPass.Click();
   
        }


        public void ForgotPasswordWrongEmailInput(string email)
        {
            var forgotpass = driver.FindElement(By.ClassName(forgotPasswordSelector));
            forgotpass.Click();
            var iframeDoc = driver.FindElement(By.XPath("//iframe"));
            driver.SwitchTo().Frame(iframeDoc);
            var emailForgotPassInput = driver.FindElement(By.XPath(emailForgotPassSectionSelector));
            emailForgotPassInput.Clear();
            emailForgotPassInput.SendKeys(email);
            var sentButtonForgotPass = driver.FindElement(By.XPath(sentButtonForgotPassSelector));
            sentButtonForgotPass.Click();
            
        }







    }
}
