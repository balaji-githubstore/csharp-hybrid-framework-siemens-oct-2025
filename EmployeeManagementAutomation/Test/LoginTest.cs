using EmployeeManagementAutomation.Base;
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
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            //Assert the header - Dashboard
            string actualHeader=driver.FindElement(By.XPath("//h6[contains(normalize-space(),'Dash')]")).Text;
            Assert.That(actualHeader, Is.EqualTo("Dashboard"));
        }

        [Test]
        public void InvalidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            //Assert the error - Invalid credentials
            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualError, Does.Contain("Invalid credentials"));

        }
    }
}
