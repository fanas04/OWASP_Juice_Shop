using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OWASP_Juice_Shop.JuiceShop.Pages;
using OWASP_Juice_Shop.JuiceShop.Values;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OWASP_Juice_Shop.JuiceShop
{
    public class Test : JuiceShop.Tests.BaseTest
    {
        private TestsPage testsPage;

        [SetUp]
        public void BeforeTests()
        {
            testsPage = new TestsPage(driver);
           
            testsPage
                .AccountButton()
                .AccountLoginButton()
                .EmailField("admin@juice-sh.op")
                .PasswordField("admin123")
                .AccountLogInINButton();
        }

        [Test]
        public void BuyZeroStorage()
        { 
            testsPage
                .SearhButtonIcon()
                .SearhTextField("OWASP Juice Shop Coaster (10pcs)")   
                .SearhTextField("\ue007")       
                .AddToCartButton()
                .AssertNonExistentQty();
        }

        [Test]
        public void BuyFullStorage()
        {
            testsPage
                 .SearhButtonIcon()
                 .SearhTextField("Green Smoothie")
                 .SearhTextField("\ue007")
                 .AddToCartButton()
                 .AssertExistingQty();
        }
        [TearDown]
        public void AfterTests()
        {
            testsPage
                .AccountButton()
                .AccountLogOutButton();
        }

    }
}
