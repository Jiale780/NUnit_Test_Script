using My1stAutomationScript.Pages;
using My1stAutomationScript.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace My1stAutomationScript
{
    [TestFixture]
    class TM_Tests : CommonDriver
    {
        [SetUp]
        public void GoToLoginPage()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.GoToLoginPage(testDriver);

            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(testDriver);
        }

        [Test]
        public void CreateTMTest()
        {
            // TM Page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(testDriver);
        }

        [Test]
        public void EditTMTest()
        {
            // Edit Time
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(testDriver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // Delete Material
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(testDriver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
