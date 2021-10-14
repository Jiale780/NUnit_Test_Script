using NUnit_Test_Script.Pages;
using NUnit_Test_Script.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Test_Script.Tests
{
    [TestFixture]
    [Parallelizable]
    class EmployeeTests : CommonDriver
    {
        // Home Page object initialization and definition
        HomePage homePageObj = new HomePage();
        // TM Page object initialization and definition
        EmployeePage employeePageObj = new EmployeePage();

        [Test, Order(1), Description("Check if the user is able to create Employee record with valid data")]
        public void CreateEmployeeTest()
        {
            homePageObj.GoToEmployeePage(testDriver);
            employeePageObj.CreateEmployee(testDriver);
        }

        [Test, Order(2), Description("Check if the user is able to edit Employee record with valid data")]
        public void EditEmployeeTest()
        {
            homePageObj.GoToEmployeePage(testDriver);
            employeePageObj.EditEmployee(testDriver);
        }

        [Test, Order(3), Description("Check if the user is able to delete Employee record with valid data")]
        public void DeleteEmployeeTest()
        {
            homePageObj.GoToEmployeePage(testDriver);
            employeePageObj.DeleteEmployee(testDriver);
        }
    }
}
