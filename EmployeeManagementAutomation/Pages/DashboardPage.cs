using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class DashboardPage : WebDriverKeywords
    {
        private By _dashboardHeader = By.XPath("//h6[contains(normalize-space(),'Dash')]");

        private readonly IWebDriver _driver;
        public DashboardPage(IWebDriver driver):base(driver) 
        {
            _driver = driver;
        }


        public string GetDashboardHeader()
        {
            return _driver.FindElement(_dashboardHeader).Text;
        }
    }
}
