﻿using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class MainPage
    {
        private By _pimLocator = By.XPath("//span[text()='PIM']");

        private readonly IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickOnPIMMenu()
        {
            _driver.FindElement(_pimLocator).Click();
        }
    }
}
