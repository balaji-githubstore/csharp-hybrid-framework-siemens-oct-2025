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
        private By _usernameLocator = By.Name("username");
        private By _passwordLocator = By.Name("password");
        private By _loginLocator = By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]");
        private By _errorLocator = By.XPath("//p[contains(normalize-space(),'Invalid')]");

        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(_usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(_passwordLocator).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            _driver.FindElement(_loginLocator).Click();
        }

        public string GetInvalidErrorMessage()
        {
            return _driver.FindElement(_errorLocator).Text;
        }

        public string GetUsernamePlaceholder()
        {
            return _driver.FindElement(_usernameLocator).GetAttribute("placeholder");
        }

    }
}
