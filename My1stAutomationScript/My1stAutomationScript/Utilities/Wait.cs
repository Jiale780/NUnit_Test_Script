using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Test_Script.Utilities
{
    class Wait
    {
        public static void WaitForElementToExist(IWebDriver testDriver, string locationType, string locationValue, int seconds)
        {
            var wait = new WebDriverWait(testDriver, new TimeSpan(0, 0, seconds));

            if (locationType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locationValue)));
            }

            if (locationType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locationValue)));
            }

            if (locationType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locationValue)));
            }
        }
        public static void WaitForElementToBeClickable(IWebDriver testDriver, string locationType, string locationValue, int seconds)
        {
            var wait = new WebDriverWait(testDriver, new TimeSpan(0, 0, seconds));

            if(locationType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locationValue)));
            }

            if (locationType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locationValue)));
            }

            if (locationType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locationValue)));
            }
        }
    }
}
