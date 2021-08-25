using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps : DriverHelper
    {
        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        [Given(@"access the home page")]
        public void GivenAccessTheHomePage()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"Click Login Page")]
        public void GivenClickLoginPage()
        {
            homePage.ClickLogin();

        }

        [Given(@"type username and password")]
        public void GivenTypeUsenamerAndPassword()
        {


        }

        [Given(@"type username and password")]
        public void GivenTypeUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUsernameAndPassword((string)data.UserName, (string)data.Password);
        }

        [Given(@"Click on the Login button")]
        public void GivenClickOnTheLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"the Logoff button is shown")]
        public void ThenTheLogoffButtonIsShown()
        {
            Assert.That(homePage.IsLogoffVisible(), Is.True, "Cant find LogOff button");
        }

    }
}
