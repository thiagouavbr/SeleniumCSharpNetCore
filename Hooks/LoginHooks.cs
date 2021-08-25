using java.sql;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager;

namespace SeleniumCSharpNetCore.Hooks
{
    [Binding]
    public sealed class LoginHooks : DriverHelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            //options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
