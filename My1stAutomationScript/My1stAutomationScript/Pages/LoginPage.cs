using My1stAutomationScript.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace My1stAutomationScript.Pages
{
    class LoginPage
    {
        public void GoToLoginPage(IWebDriver testDriver)
        {
            // Launch turn up portal and maximize window
            testDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            testDriver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            try
            {
                // Identify the username textbox enter valid username
                IWebElement usernameTextBox = testDriver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");

                // Identify password textbox enter valid password
                IWebElement passwordTextBox = testDriver.FindElement(By.Id("Password"));
                passwordTextBox.SendKeys("123123");

                // Identify login button and click
                Wait.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='loginForm']/form/div[3]/input[1]", 2);
                IWebElement loginButton = testDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
                
                //Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal home page did not launch", ex.Message);
            }
        }
    }
}
