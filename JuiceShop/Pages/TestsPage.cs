using NUnit.Framework;
using OpenQA.Selenium;
using OWASP_Juice_Shop.JuiceShop.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.JuiceShop.Pages
{
    public class TestsPage : BasicPage
    {
        IWebElement searchButtonIcon => driver.FindElement(By.CssSelector(".mat-search_icon-search"));
        IWebElement searchButtonField => driver.FindElement(By.Id("mat-input-0"));
        IWebElement juiceShopCoasterAddToBasketButton => driver.FindElement(By.CssSelector(".mat-button-wrapper > span:nth-child(1)"));
        IWebElement notificationWeb => driver.FindElement(By.CssSelector(".mat-simple-snackbar > span"));
        IWebElement accountButton => driver.FindElement(By.Id("navbarAccount"));
        IWebElement accountLoginButton => driver.FindElement(By.Id("navbarLoginButton"));
        IWebElement emailField => driver.FindElement(By.Id("email"));
        IWebElement passwordField => driver.FindElement(By.Id("password"));
        IWebElement accountLogOutButton => driver.FindElement(By.Id("navbarLogoutButton"));
        IWebElement error => driver.FindElement(By.CssSelector(".error"));
        IWebElement accountLogInINButton => driver.FindElement(By.Id("loginButton"));
        string NotificationFive = "We are out of stock! Sorry for the inconvenience.";
        string NotificationSix = "Placed Green Smoothie into basket.";
        string NotificationSeven = "Added another Green Smoothie to basket.";

        public TestsPage(IWebDriver driver) : base(driver) { }

        public TestsPage SearhButtonIcon()
        {
            searchButtonIcon.Click();
            return this;
        }
        public TestsPage SearhTextField(string text)
        {
            searchButtonField.SendKeys(text);
            return this;
        }
        public TestsPage AddToCartButton()
        {
            juiceShopCoasterAddToBasketButton.Click();
            return this;
        }
        public TestsPage AccountButton()
        {
            accountButton.Click();
            return this;
        }
        public TestsPage AccountLoginButton()
        {
            accountLoginButton.Click();
            return this;
        }
        public TestsPage EmailField(string text)
        {
            emailField.SendKeys(text);
            return this;
        }
        public TestsPage PasswordField(string text)
        {
            passwordField.SendKeys(text);
            return this;
        }
        public TestsPage AccountLogOutButton()
        {
            accountLogOutButton.Click();
            return this;
        }
        public TestsPage AccountLogInINButton()
        {
            accountLogInINButton.Click();
            return this;
        }
        /*
        public TestsPage AssertSorry(TestsValues notification)
        {         
           Assert.AreEqual(TestsValues.NotificationOne, notificationWeb.Text);
            return this;
        }
        */
        public TestsPage AssertNonExistentQty()
        {
            Assert.AreEqual(NotificationFive, notificationWeb.Text);
            return this;
        }
        public TestsPage AssertExistingQty()
        {
           Assert.IsTrue((notificationWeb.Text == NotificationSix || notificationWeb.Text == NotificationSeven) ? true : false, "Failed");
            return this;
        }
        public TestsPage AssertSqlInjectionError()
        {
            Assert.IsTrue(error.Displayed);
            return this;
        }
        public TestsPage AssertSqlInjectionErrorText()
        {
            Assert.AreEqual("Invalid email or password.", error.Text, "Something of interest or hacking succeeded");
            return this;
        }
    }
}











