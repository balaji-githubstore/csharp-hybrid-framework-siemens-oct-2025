using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class DashboardPage
    {
        private IWebDriver _driver;
        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
        }


        public string GetDashboardHeader()
        {
            return _driver.FindElement(By.XPath("//h6[contains(normalize-space(),'Dash')]")).Text;
        }
    }
}
