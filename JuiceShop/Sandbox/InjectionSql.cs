using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OWASP_Juice_Shop.JuiceShop.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.JuiceShop.Sandbox
{
    public class InjectionSql : JuiceShop.Tests.BaseTest
    {
        private TestsPage testsPage;
       
        [SetUp]
        public void BeforeTests()
        {
            testsPage = new TestsPage(driver);

            driver.Url = "https://demo-igno.herokuapp.com/";
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.CssSelector(".close-dialog > .mat-button-wrapper > span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
           
        } 
        [Test]
        public void SQLInjection()
        {
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("admin")
                .PasswordField("admin")
                .AccountLogInINButton()
                .AssertSqlInjectionError()
                .AssertSqlInjectionErrorText();
        }
        [Test]
        public void SQLInjection1()
        {
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("admin")
                .PasswordField("admin123")
                .AccountLogInINButton()
                .AssertSqlInjectionError()
                .AssertSqlInjectionErrorText();
        }
        [Test]
        public void SQLInjection3()
        {
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("'1'='1")
                .PasswordField("'1'='1")
                .AccountLogInINButton()
                .AssertSqlInjectionError()
                .AssertSqlInjectionErrorText();

        }
        [Test]
        public void SQLInjection4()
        {
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("`' OR true--` ")
                .PasswordField("`' OR true--` ")
                .AccountLogInINButton()
                .AssertSqlInjectionError()
                .AssertSqlInjectionErrorText();

        }
        [Test]
        public void JimEmail()
        {
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("jim@juice-sh.op'--")
                .PasswordField("admin")
                .AccountLogInINButton()
                .AssertSqlInjectionError()
                .AssertSqlInjectionErrorText();

        }
        [Test]
        public void BenderEmail()
        {
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("bender@juice-sh.op'--")
                .PasswordField("admin")
                .AccountLogInINButton()
                .AssertSqlInjectionError()
                .AssertSqlInjectionErrorText();
        }
        [TearDown]
        public void AfterTests()
        {
            driver.Close();
        }

    }
}










