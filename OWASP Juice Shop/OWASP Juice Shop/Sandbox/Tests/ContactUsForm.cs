using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Tests
{
    public class ContactUsForm
    {
        [Test]
        public void ContactUsToday()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/input-form-demo.html";
            driver.Manage().Window.Maximize();

            IWebElement FirstName = driver.FindElement(By.Name("first_name"));
            IWebElement LastName = driver.FindElement(By.Name("last_name"));
            IWebElement Email = driver.FindElement(By.Name("email"));
            IWebElement Phone = driver.FindElement(By.Name("phone"));
            IWebElement Address = driver.FindElement(By.Name("address"));
            IWebElement City = driver.FindElement(By.Name("city"));
            IWebElement State = driver.FindElement(By.Name("state"));
            IWebElement ZipCode = driver.FindElement(By.Name("zip"));
            IWebElement WebSite = driver.FindElement(By.Name("website"));
            IWebElement HostingRadioButtonYes = driver.FindElement(By.CssSelector(".radio:nth-child(1) > label"));
            IWebElement HostingRadioButtonNo = driver.FindElement(By.CssSelector(".radio:nth-child(2) > label"));
            IWebElement ProjectDescription = driver.FindElement(By.Name("comment"));
            IWebElement Send = driver.FindElement(By.CssSelector(".btn"));


            FirstName.SendKeys("Kobe");
            LastName.SendKeys("Super");
            Email.SendKeys("Super@kobe.com");
            Phone.SendKeys("25252525");
            Address.SendKeys("Super");
            City.SendKeys("LA");
            State.SendKeys("Alaska");
            ZipCode.SendKeys("85855");
            WebSite.SendKeys("www.super.com");
            HostingRadioButtonYes.Click();
            ProjectDescription.SendKeys("Woolia"); ;
            Send.Click();


        }

            


    }
}
