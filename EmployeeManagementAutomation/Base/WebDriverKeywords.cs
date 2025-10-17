using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Base
{
    /// <summary>
    /// All IWebDriver methods, reusable keywords, wait conditions will be handled.
    /// </summary>
    public class WebDriverKeywords
    {
        private IWebDriver _driver;

        public WebDriverKeywords(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickElement(By locator)
        {
            _driver.FindElement(locator).Click();
        }

        public void SendTextToElement(By locator, string text)
        {
            _driver.FindElement(locator).SendKeys(text);
        }

        public string GetTextFromElement(By locator)
        {
            return _driver.FindElement(locator).Text;
        }

        public string GetAttributeValueFromElement(By locator,string attributeName)
        {
            return _driver.FindElement(locator).GetAttribute(attributeName);
        }

        public void SwitchToWindowByTitle(string title)
        {
            foreach (string window in _driver.WindowHandles)
            {
                _driver.SwitchTo().Window(window);
                if (_driver.Title.Equals(title))
                {
                    break;
                }
            }
        }
    }
}
