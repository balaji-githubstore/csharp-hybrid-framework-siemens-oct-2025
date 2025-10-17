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
    public class WebDriverKeywords
    {
        private IWebDriver _driver;
     //   private DefaultWait<IWebDriver> _wait;

        public WebDriverKeywords(IWebDriver driver)
        {
            _driver = driver;

            //_wait = new DefaultWait<IWebDriver>(_driver);
            //_wait.Timeout=TimeSpan.FromSeconds(20);
            //_wait.IgnoreExceptionTypes(typeof(Exception)));

        }


        public void ClickElement(By locator)
        {
            _driver.FindElement(locator).Click();
           // _wait.Until(x => x.FindElement(locator)).Click();
        }

        public void SendTextToElement(By locator, string text)
        {
            _driver.FindElement(locator).SendKeys(text);
        }

        public string GetTextFromElement(By locator)
        {
            return _driver.FindElement(locator).Text;
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
