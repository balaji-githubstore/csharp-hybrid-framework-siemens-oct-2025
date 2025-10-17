using DocumentFormat.OpenXml.Bibliography;
using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class MainPage : WebDriverKeywords
    {
        private By _pimLocator = By.XPath("//span[text()='PIM']");

        private readonly IWebDriver _driver;

        public MainPage(IWebDriver driver):base(driver) 
        {
            _driver = driver;
        }

        public void ClickOnPIMMenu()
        {
            _driver.FindElement(_pimLocator).Click();
        }
    }
}
