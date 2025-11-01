using EmployeeManagementAutomation.Base;
using EmployeeManagementAutomation.Pages;
using EmployeeManagementAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Test
{
    public class LoginTest : AutomationWrapper
    {
        [Test, Category("regression")]
        public void ValidLoginTest()
        { 
            LoginPage login=new LoginPage(driver);
            login.EnterUsername("Admin");
            login.EnterPassword("admin123");
            login.ClickOnLogin();

            DashboardPage dashboard=new DashboardPage(driver);
            Assert.That(dashboard.GetDashboardHeader(), Is.EqualTo("Dashboard"));
        }

        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginDataFromExcel))]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            string actualError = login.GetInvalidErrorMessage();
            Assert.That(actualError, Does.Contain(expectedError));
        }
    }
}
