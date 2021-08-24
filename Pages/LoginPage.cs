using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    {

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void EnterUsernameAndPassword (string username, string password)
        
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
