using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Pages
{
    public class ImputFieldPage : BasePage
    {
        private IWebElement imputField => driver.FindElement(By.Id("user-message"));
        private IWebElement showMessageButton => driver.FindElement(By.CssSelector(".btn:nth-child(2)"));
        private IWebElement displayedText => driver.FindElement(By.Id("display"));
        private IWebElement imputNumberOne => driver.FindElement(By.Id("sum1"));
        private IWebElement imputNumberTwo => driver.FindElement(By.Id("sum2"));
        private IWebElement sumButton => driver.FindElement(By.CssSelector(".btn:nth-child(3)"));
        private IWebElement getSum => driver.FindElement(By.Id("displayvalue"));

        public ImputFieldPage (IWebDriver driver) : base(driver) { } //draiverio konstruktorius

        public ImputFieldPage EnterMessage(string text)
        {
            imputField.SendKeys(text);
            return this;
        }

        public ImputFieldPage ClickShowMessage()
        {
            showMessageButton.Click();
            return this;
        }
        public ImputFieldPage AssertMessageIs(string text)
        {
            Assert.AreEqual(text, displayedText.Text);
            return this;
        }
        public ImputFieldPage EnterFirstNumber (string number)
        {
            imputNumberOne.SendKeys(number);
            return this;
        }
        public ImputFieldPage EnterSecondNumber(string number)
        {
            imputNumberTwo.SendKeys(number);
            return this;
        }
        public ImputFieldPage ClickCalculeSum()
        {
            sumButton.Click();
            return this;
        }
        public ImputFieldPage AssertSum(string exspectedSum)
        {
            Assert.AreEqual(exspectedSum, driver.FindElement(By.Id("displayvalue")).Text);
            return this;
        }

    }
}
