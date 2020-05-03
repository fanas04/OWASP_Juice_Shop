using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Tests
{
    public class RadiobuttonTest
    {
        [Test]
        public void NotfingChecked()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("buttoncheck")).Click();
            Assert.AreEqual("Radio button is Not checked", driver.FindElement(By.CssSelector(".radiobutton")).Text);

        }

        [Test]
        public void MaleIsChecked()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.CssSelector(".panel-body > .radio-inline:nth-child(2)")).Click();
            driver.FindElement(By.Id("buttoncheck")).Click();
            Assert.AreEqual("Radio button 'Male' is checked", driver.FindElement(By.CssSelector(".radiobutton")).Text);

        }
        [Test]
        public void FemaleIsChecked()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.CssSelector(".panel-body > .radio-inline:nth-child(3) > input")).Click();
            driver.FindElement(By.Id("buttoncheck")).Click();
            Assert.AreEqual("Radio button 'Female' is checked", driver.FindElement(By.CssSelector(".radiobutton")).Text);
        }
        [Test]
        public void GroupRadioButtonChecked()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            driver.Manage().Window.Maximize();

            IWebElement GetValueButton = driver.FindElement(By.CssSelector(".btn:nth-child(5)"));
            IWebElement MaleRadioButton = driver.FindElement(By.CssSelector(".panel-body > div:nth-child(2) > .radio-inline:nth-child(2)"));
            IWebElement FemaleRadioButton = driver.FindElement(By.CssSelector(".panel-body > div:nth-child(2) > .radio-inline:nth-child(3)"));
            IWebElement ZeroToFive = driver.FindElement(By.CssSelector("div:nth-child(3) > .radio-inline:nth-child(2)"));
            IWebElement FiveToFiftyn = driver.FindElement(By.CssSelector("div:nth-child(3) > .radio-inline:nth-child(3)"));
            IWebElement FiveToFifty = driver.FindElement(By.CssSelector(".radio-inline:nth-child(4)"));

            GetValueButton.Click();
            Assert.AreEqual("Sex :\r\nAge group:", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

            MaleRadioButton.Click();
            ZeroToFive.Click();
            GetValueButton.Click();
            Assert.AreEqual("Sex : Male\r\nAge group: 0 - 5", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

            MaleRadioButton.Click();
            FiveToFiftyn.Click();
            GetValueButton.Click();
            Assert.AreEqual("Sex : Male\r\nAge group: 5 - 15", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

            MaleRadioButton.Click();
            FiveToFifty.Click();
            GetValueButton.Click();
            Assert.AreEqual("Sex : Male\r\nAge group: 15 - 50", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

            FemaleRadioButton.Click();
            ZeroToFive.Click();
            GetValueButton.Click();
            Assert.AreEqual("Sex : Female\r\nAge group: 0 - 5", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

            FemaleRadioButton.Click();
            FiveToFiftyn.Click();
            GetValueButton.Click();
            Assert.AreEqual("Sex : Female\r\nAge group: 5 - 15", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

            FemaleRadioButton.Click();
            FiveToFifty.Click();
            GetValueButton.Click();
            Assert.AreEqual("Sex : Female\r\nAge group: 15 - 50", driver.FindElement(By.CssSelector(".groupradiobutton")).Text);

        }



    }
}
