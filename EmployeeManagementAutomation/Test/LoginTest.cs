using EmployeeManagementAutomation.Base;
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
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]")).Click();

            string actualHeader = driver.FindElement(By.XPath("//h6[contains(normalize-space(),'Dash')]")).Text;
            Assert.That(actualHeader, Is.EqualTo("Dashboard"));
        }

        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginDataFromExcel))]
        //[TestCase("john", "john123", "Invalid credentials")]
        //[TestCase("saul", "saul123", "Invalid credentials")]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualError, Does.Contain(expectedError));
        }
    }
}
