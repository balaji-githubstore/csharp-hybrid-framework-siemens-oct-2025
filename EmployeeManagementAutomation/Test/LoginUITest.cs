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
    public class LoginUITest : AutomationWrapper 
    {
        [Test,Category("regression")]
        public void TitleTest()
        {
            Assert.That(driver.Title, Is.EqualTo("OrangeHRM"));
        }

        [Test,Category("smoke")]
        public void HeaderTest()
        {
            //Assert the header - Login
            string actualHeader = driver.FindElement(By.XPath("//h5")).Text;
            Assert.That(actualHeader, Is.EqualTo("Login"));

        }
    }
}
