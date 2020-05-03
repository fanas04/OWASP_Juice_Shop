using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Tests
{

    public class CheckBoxTests
    {
        private IWebDriver driver;

        IWebElement isAgeSelected => driver.FindElement(By.Id("isAgeSelected"));
        IWebElement answerText => driver.FindElement(By.Id("txtAge"));
        IWebElement ageSelected => driver.FindElement(By.Id("isAgeSelected"));

        [SetUp]

         public void BeforeTests()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestCheckBox()
        {
            isAgeSelected.Click();
           
            var tekstas = "Success - Check box is checked";
            
            Assert.AreEqual(tekstas, answerText.Text);
            Assert.IsTrue(ageSelected.Selected);
        }

        [Test]
        public void CheckAllTest()
        {
            driver.FindElement(By.Id("check1")).Click();
            Assert.AreEqual("Uncheck All", driver.FindElement(By.Id("check1")).GetProperty("value"));

            var checkboxElementList = driver.FindElements(By.CssSelector(".cb1-element"));

            Assert.AreEqual(4, checkboxElementList.Count);

            foreach (var checkboxElement in checkboxElementList)
            {
                Assert.IsTrue(checkboxElement.Selected, "Kazkuris nepazymetas");
            }

        }
        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();
        }
    }
}
