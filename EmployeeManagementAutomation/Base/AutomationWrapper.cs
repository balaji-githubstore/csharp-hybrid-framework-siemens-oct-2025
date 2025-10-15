using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Base
{
    /// <summary>
    /// Browser and Report Configuration 
    /// </summary>
    public class AutomationWrapper
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforeTestMethod()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [TearDown]
        public void AfterTestMethod()
        {
            //driver.Quit();
            driver.Dispose();
        }
    }
}
