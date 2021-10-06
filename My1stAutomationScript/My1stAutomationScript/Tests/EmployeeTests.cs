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

        [Test, Order(1), Description("Check if the user is able to create Employee record with valid data")]
        public void CreateEmployeeTest()
        {
            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(testDriver);

            // TM Page object initialization and definition
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(testDriver);
        }

        [Test, Order(2), Description("Check if the user is able to edit Employee record with valid data")]
        public void EditEmployeeTest()
        {
            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(testDriver);

            // Edit Time
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(testDriver);
        }

        [Test, Order(3), Description("Check if the user is able to delete Employee record with valid data")]
        public void DeleteEmployeeTest()
        {
            // Home Page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(testDriver);

            // Delete Material
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(testDriver);
        }

    }
}
