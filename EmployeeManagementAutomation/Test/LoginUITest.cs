using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Test
{
    public class LoginUITest
    {
        IWebDriver driver;

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
            driver.Dispose();
        }

        [Test]
        public void TitleTest()
        {
            Assert.That(driver.Title, Is.EqualTo("OrangeHRM"));
        }

        [Test]
        public void HeaderTest()
        {
            //Assert the header - Login
            string actualHeader = driver.FindElement(By.XPath("//h5")).Text;
            Assert.That(actualHeader, Is.EqualTo("Login"));
        }
    }
}
