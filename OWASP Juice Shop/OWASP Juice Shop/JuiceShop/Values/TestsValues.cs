using System;
using System.Collections.Generic;
using System.Text;

namespace OWASP_Juice_Shop.JuiceShop.Values
{
    public class TestsValues
    {
        public static TestsValues NotificationOne = new TestsValues ("We are out of stock! Sorry for the inconvenience.");
        public static TestsValues NotificationTwo = new TestsValues ("Placed Green Smoothie into basket.");
        public static TestsValues NotificationThree = new TestsValues ("Added another Green Smoothie to basket.");

        public string notification;

        public TestsValues(string notification)
        {
            this.notification = notification;
        }

    }
}
