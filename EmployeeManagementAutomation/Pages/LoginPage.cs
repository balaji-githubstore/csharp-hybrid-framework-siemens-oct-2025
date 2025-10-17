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
    public class LoginPage : WebDriverKeywords
    {
        private By _usernameLocator = By.Name("username");
        private By _passwordLocator = By.Name("password");
        private By _loginLocator = By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]");
        private By _errorLocator = By.XPath("//p[contains(normalize-space(),'Invalid')]");

        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver):base(driver) 
        {
            _driver = driver;
        }

        public void EnterUsername(string username)
        {
            base.SendTextToElement(_usernameLocator, username);
        }

        public void EnterPassword(string password)
        {
            base.SendTextToElement(_passwordLocator,password);  
        }

        public void ClickOnLogin()
        {
            base.ClickElement(_loginLocator);
        }

        public string GetInvalidErrorMessage()
        {
            return base.GetTextFromElement(_errorLocator);
        }

        public string GetUsernamePlaceholder()
        {
            return base.GetAttributeValueFromElement(_usernameLocator, "placeholder");
        }

    }
}
