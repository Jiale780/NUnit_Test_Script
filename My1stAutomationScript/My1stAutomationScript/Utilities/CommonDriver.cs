using My1stAutomationScript.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace My1stAutomationScript.Utilities
{
    class CommonDriver
    {
        public static IWebDriver testDriver;

    // [OneTimeSetUp]
    // public void GoToLoginPage()
    // {
    //     // Open chrome browser
    //     testDriver = new ChromeDriver();
    //
    //     // Login Page object initialization and definition
    //     LoginPage loginPageObj = new LoginPage();
    //     loginPageObj.GoToLoginPage(testDriver);
    //
    //     // Home Page object initialization and definition
    //     HomePage homePageObj = new HomePage();
    //     homePageObj.GoToTMPage(testDriver);
    // }
    //
    // [OneTimeTearDown]
    // public void CloseTestRun()
    // {
    //     testDriver.Quit();
    // }
    }
}
