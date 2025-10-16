using EmployeeManagementAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Test
{
    public class EmployeeTest : AutomationWrapper
    {

        //add the data to excel
        [Test]
        public void AddValidEmployeeTest()
        {

            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]")).Click();

            //click on PIM menu
            //Click on Add Employee 
            // enter firstname, middlename, lastname
            //click on save 

            //assert profile name - firstname lastname
            //assert the firstname textbox -- firstname
        }
    }
}
