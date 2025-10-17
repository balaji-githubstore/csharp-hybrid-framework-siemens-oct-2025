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
    /// <summary>
    /// Handles all elements inside the LoginPage
    /// </summary>
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(By.Name("username")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.Name("password")).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            _driver.FindElement(By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]")).Click();
        }

        public string GetInvalidErrorMessage()
        {
            return _driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
        }


    }
}
