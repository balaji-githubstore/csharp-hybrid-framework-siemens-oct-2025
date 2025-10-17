using EmployeeManagementAutomation.Base;
using EmployeeManagementAutomation.Pages;
using EmployeeManagementAutomation.Utilities;
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
        [TestCaseSource(typeof(DataSource), nameof(DataSource.AddValidEmployeeDataFromExcel))]
        public void AddValidEmployeeTest(string username,string password,string firstName,string middleName,string lastName)
        {
            //LoginPage
            LoginPage login = new LoginPage(driver);
            login.EnterUsername("Admin");
            login.EnterPassword("admin123");
            login.ClickOnLogin();

            //MainPage
            MainPage main=new MainPage(driver);
            main.ClickOnPIMMenu();

            //PIMPage
            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();

            //AddEmployeePage
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("middleName")).SendKeys(middleName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();

            //EmployeePersonalDetailPage
            string actualProfileName = driver.FindElement(By.XPath($"//h6[contains(normalize-space(),'{firstName}')]")).Text;
            string actualFirstName=driver.FindElement(By.Name("firstName")).GetAttribute("value");

            Assert.Multiple(() =>
            {
                Assert.That(actualProfileName, Is.EqualTo($"{firstName} {lastName}"));
                Assert.That(actualFirstName, Is.EqualTo(firstName));
            });
        }
    }
}
