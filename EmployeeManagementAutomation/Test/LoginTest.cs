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

            string actualHeader=driver.FindElement(By.XPath("//h6[contains(normalize-space(),'Dash')]")).Text;
            Assert.That(actualHeader, Is.EqualTo("Dashboard"));
        }

        public static object[] InvalidLoginData()
        {
            string[] data1 = new string[3];
            data1[0] = "john";
            data1[1] = "john123";
            data1[2] = "Invalid credentials";

            string[] data2 = new string[3];
            data2[0] = "saul";
            data2[1] = "saul123";
            data2[2] = "Invalid credentials";

            object[] allData = new object[2];
            allData[0] = data1;
            allData[1] = data2;

            return allData;
        }


        [Test]
        [TestCaseSource(nameof(InvalidLoginData))]
        //[TestCase("john","john123", "Invalid credentials")]
        //[TestCase("saul", "saul123", "Invalid credentials")]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(actualError, Does.Contain(expectedError));
        }
    }
}
