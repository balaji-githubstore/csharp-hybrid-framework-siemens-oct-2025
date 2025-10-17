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
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login' or normalize-space()='登录' ]")).Click();


            MainPage main=new MainPage(driver);
            main.ClickOnPIMMenu();
            //driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();

            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("middleName")).SendKeys(middleName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);

            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();

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
