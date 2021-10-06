using NUnit_Test_Script.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Test_Script.Pages
{
    class HomePage
    {
        public void GoToTMPage(IWebDriver testDriver)
        {
            // Click on administration dropdown
            IWebElement administration = testDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            // Select Time & Material from dropdown list
            //Wait.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);
            testDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
        public void GoToEmployeePage(IWebDriver testDriver)
        {
            // Click on administration dropdown
            IWebElement administration = testDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            // Navigate Employee Page from dropdown list
            //Wait.WaitForElementToBeClickable(testDriver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 2);
            testDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")).Click();
        }
    }
}
