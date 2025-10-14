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
            //enter password as admin123
            //click on login

            //Assert the header - Dashboard
        }

        [Test]
        public void InvalidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("john");
            //enter password as john123
            //click on login

            //Assert the error - Invalid credentials
        }
    }
}
