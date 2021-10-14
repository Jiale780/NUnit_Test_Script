using NUnit_Test_Script.Pages;
using NUnit_Test_Script.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace NUnit_Test_Script
{
    [TestFixture]
    [Parallelizable]
    class TM_Tests : CommonDriver
    {
        // Home Page object initialization and definition
        HomePage homePageObj = new HomePage();
        // TM Page object initialization and definition
        TMPage tmPageObj = new TMPage();

        [Test, Order(1), Description("Check if the user is able to create Time record with valid data")]
        public void CreateTMTest()
        {
            homePageObj.GoToTMPage(testDriver);
            tmPageObj.CreateTM(testDriver);
        }

        [Test, Order(2), Description("Check if the user is able to edit Time record with valid data")]
        public void EditTMTest()
        {
            homePageObj.GoToTMPage(testDriver);
            tmPageObj.EditTM(testDriver);
        }

        [Test, Order(3), Description("Check if the user is able to delete Material record")]
        public void DeleteTMTest()
        {
            homePageObj.GoToTMPage(testDriver);
            tmPageObj.DeleteTM(testDriver);
        }

    }
}
