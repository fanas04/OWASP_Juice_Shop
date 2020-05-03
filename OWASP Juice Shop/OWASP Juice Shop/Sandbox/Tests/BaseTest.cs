using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforeEveryTest()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }
    }
}
