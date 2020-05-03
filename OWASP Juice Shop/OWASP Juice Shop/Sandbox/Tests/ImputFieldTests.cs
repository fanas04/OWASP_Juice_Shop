using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OWASP_Juice_Shop.Sandbox.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Tests
{
    public class ImputFieldTests : BaseTest
    {
        //private IWebElement imputField => driver.FindElement(By.Id("user-message"));
        //private IWebElement showMessageButton => driver.FindElement(By.CssSelector(".btn:nth-child(2)"));
        //private IWebElement displayedText => driver.FindElement(By.Id("display"));
        //private IWebElement imputNumberOne => driver.FindElement(By.Id("sum1"));
        //private IWebElement imputNumberTwo => driver.FindElement(By.Id("sum2"));
        private ImputFieldPage imputFieldPage;
        [SetUp]
        public void BeforeTests()
        {
            imputFieldPage = new ImputFieldPage(driver);
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
          // driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
        }
        [Test]
        public void ShowMessage()
        {

            var irasomasTekstas = "test";

            imputFieldPage
                .EnterMessage(irasomasTekstas)
                .ClickShowMessage()
                .AssertMessageIs(irasomasTekstas);

            //  imputField.SendKeys("test");
            // imputFieldPage.EnterMessage("gali buti ir taip");
            // showMessageButton.Click();
            // Assert.AreEqual(irasomasTekstas, displayedText.Text);

        }
        [Test]
        public void CountSum()
        {
            // imputNumberTwo.SendKeys("8");
            //   imputNumberOne.SendKeys("5");
            // driver.FindElement(By.CssSelector(".btn:nth-child(3)")).Click();
            // Assert.AreEqual(tikrinamasTekstas, driver.FindElement(By.Id("displayvalue")).Text);

            var tikrinamasTekstas = "13";

            imputFieldPage
                .EnterFirstNumber("8")
                .EnterSecondNumber("5")
                .ClickCalculeSum()
                .AssertSum(tikrinamasTekstas);

          
        }

    }

}