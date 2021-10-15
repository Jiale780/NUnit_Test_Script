using NUnit_Test_Script.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit_Test_Script.TestDatabase;

namespace NUnit_Test_Script.Pages
{
    class LoginPage
    {
        public void GoToLoginPage(IWebDriver testDriver)
        {
            // Launch turn up portal and maximize window
            string loginPagePath = "http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f";
            testDriver.Navigate().GoToUrl(loginPagePath);
            testDriver.Manage().Window.Maximize();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            testDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            try
            {
                // Identify the username textbox enter valid username
                IWebElement usernameTextBox = testDriver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys(TestLoginData.username);

                // Identify password textbox enter valid password
                IWebElement passwordTextBox = testDriver.FindElement(By.Id("Password"));
                passwordTextBox.SendKeys(TestLoginData.password);

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
