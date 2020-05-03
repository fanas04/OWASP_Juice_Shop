using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Tests
{
    public class SingleDropdown
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
        }
        [Test]
        public void SingleDropDown()
        {
         
            IWebElement singleDropDown = driver.FindElement(By.Id("select-demo"));

            new SelectElement(singleDropDown).SelectByText("Wednesday"); // select elementas pagal teksta
            //new SelectElement(singleDropDown).SelectByIndex(4); //select elemntas pagal indeksa
            //new SelectElement(singleDropDown).SelectByValue("Wednesday"); // select elementas pagal verte

            Assert.AreEqual("Day selected :- Wednesday", driver.FindElement(By.ClassName("selected-value")).Text);

            Assert.IsTrue(driver.FindElement(By.ClassName("selected-value")).Text.Contains("Wednesday"));

            driver.Close();
        }
        [Test]
        public void MultiSelect()
        {
            IWebElement multiSelectElement = driver.FindElement(By.Id("multi-select"));
            IWebElement firstSelected = driver.FindElement(By.Id("printMe"));
            IWebElement getAllSelected = driver.FindElement(By.Id("printAll"));

            new SelectElement(multiSelectElement).SelectByIndex(1);

            IWebElement ohio = new SelectElement(multiSelectElement).Options[4];
            

            var builder = new Actions(driver);

            builder.KeyDown(Keys.Control);
            builder.Click(ohio);
            builder.KeyUp(Keys.Control);
            builder.Build().Perform();

            firstSelected.Click();
            Assert.AreEqual("First selected option is : Florida", driver.FindElement(By.CssSelector(".getall-selected")).Text);

            getAllSelected.Click();
            Assert.AreEqual("Options selected are : Florida,Ohio", driver.FindElement(By.CssSelector(".getall-selected")).Text);

        }
        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
        

    }








}
