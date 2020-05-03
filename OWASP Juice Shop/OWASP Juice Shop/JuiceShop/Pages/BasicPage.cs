using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.JuiceShop.Pages
{
    public class BasicPage
    {
        protected IWebDriver driver;
        public BasicPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
