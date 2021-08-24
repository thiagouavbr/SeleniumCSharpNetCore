using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {


        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUsernameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.IsLogoffVisible(), Is.True, "Cant find LogOff button");

        }
    }
}