using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogoff => Driver.FindElement(By.XPath("//*[@id='logoutForm']"));

        public void ClickLogin() 
        { 
            lnkLogin.Click();
        }

        public void ClickLogoff()
        {
            lnkLogoff.Click();
        }

        public bool IsLogoffVisible() 
        {
            return lnkLogoff.Displayed;
        }
    }
}
