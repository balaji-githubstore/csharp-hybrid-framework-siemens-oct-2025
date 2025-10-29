using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace EmployeeManagementAutomation.Base
{
    /// <summary>
    /// Browser and Report Configuration 
    /// </summary>
    public class AutomationWrapper
    {
        protected IWebDriver driver;
        protected BrowserSettings browserSettings;

        public void InitConfigScript()
        {
            var config = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

            browserSettings = config.GetSection("BrowserSettings").Get<BrowserSettings>();
        }

        [SetUp]
        public void BeforeTestMethod()
        {
            InitConfigScript();
            string browserName = browserSettings.BrowserName;

            if (browserName.ToLower().Equals("edge"))
            {
                EdgeOptions options=new EdgeOptions();
                //options.BinaryLocation = @"";
                driver = new EdgeDriver(options);
            }
            else if (browserName.ToLower().Equals("ff"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                ChromeOptions options = new ChromeOptions();
                //options.BinaryLocation = @"D:\Balaji\Components\chrome-win64\chrome-win64\chrome.exe";
                options.BinaryLocation = browserSettings.ChromeBinaryLocation;

                driver = new ChromeDriver(options);
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(browserSettings.BaseUrl);
        }

        [TearDown]
        public void AfterTestMethod()
        {
            //driver.Quit();
            driver.Dispose();
        }
    }
}
