using My1stAutomationScript.Pages;
using My1stAutomationScript.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace My1stAutomationScript.Tests
{
    [TestFixture]
    class EmployeeTests : CommonDriver
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
            homePageObj.GoToEmployeePage(testDriver);
        }

        [Test, Order(1), Description("Check if the user...")]
        public void CreateEmployeeTest()
        {
            // TM Page object initialization and definition
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(testDriver);
        }

        [Test, Order(2), Description("Check if the user...")]
        public void EditEmployeeTest()
        {
            // Edit Time
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(testDriver);
        }

        [Test, Order(3), Description("Check if the user...")]
        public void DeleteEmployeeTest()
        {
            // Delete Material
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(testDriver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            //testDriver.Quit();
        }
    }
}
