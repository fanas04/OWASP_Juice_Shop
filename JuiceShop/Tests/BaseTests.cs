using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.JuiceShop.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforeEveryTest()
        {
            driver = new ChromeDriver();
            driver.Url = "https://demo-igno.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector(".close-dialog > .mat-button-wrapper > span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }
    }
}


