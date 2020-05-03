using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.Sandbox.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
//apra6ytas metodas kaip ta draiveri paimti