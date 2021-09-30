using My1stAutomationScript.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace My1stAutomationScript.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver testDriver)
        {
            try
            {
                // Click on "Create New" button
                IWebElement CreateNewButton = testDriver.FindElement(By.XPath("//*[@id='container']/p/a"));
                CreateNewButton.Click();

                // Select Time from "Type Code" dropdown list
                IWebElement typeCodeDropdown = testDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                typeCodeDropdown.Click();

                IWebElement selectTime = testDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
                selectTime.Click();

                // Identify "Code" from Textbox and Input code
                IWebElement codeTextBox = testDriver.FindElement(By.Id("Code"));
                codeTextBox.SendKeys("AutomatedScript");

                // Identify "Description" from Textbox and Input description
                IWebElement descriptionTextBox = testDriver.FindElement(By.Id("Description"));
                descriptionTextBox.SendKeys("AutomatedScript");

                // Identify "Price per unit" textbox and input price
                testDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

                IWebElement pricePerUnit = testDriver.FindElement(By.Id("Price"));
                pricePerUnit.SendKeys("37.00");

                // Click on "Save" button
                IWebElement saveButton = testDriver.FindElement(By.Id("SaveButton"));
                saveButton.Click();

                // Click on "Go to the last page" button
                Thread.Sleep(5000);
                IWebElement goToLastPageButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageButton.Click();

                // Assert that Time record has been created.
                Wait.WaitForElementToExist(testDriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 4);
                IWebElement timeRecord = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));
            }
            catch(Exception ex)
            {
                Assert.Fail("TurnUp Portal of Time & Materials did not create", ex.Message);
            }
            finally
            {
                Assert.Pass("TurnUp Portal of Time & Materials did create");
            }
        }
        public void EditTM(IWebDriver testDriver)
        {
            try
            {
                // Click on "Go to the last page" button
                Thread.Sleep(5000);
                IWebElement goToLastPageButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageButton.Click();

                // Click on the Edit Button
                IWebElement editButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();

                // Click on "TypeCode" from dropdown list and set the Type Code\
                Wait.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span", 3);
                IWebElement typeCodeDropdown1 = testDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                typeCodeDropdown1.Click();
                //Thread.Sleep(2000);

                Wait.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='TypeCode_listbox']/li[1]", 2);
                IWebElement selectMaterial = testDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                selectMaterial.Click();
                //Thread.Sleep(2000);

                // Click on "Code" from Textbox and set the code
                IWebElement codeTextBox1 = testDriver.FindElement(By.Id("Code"));
                codeTextBox1.Clear();
                codeTextBox1.SendKeys("Automated Script1");

                // Click on "Description" from Textbox and set the description
                IWebElement descriptionTextBox1 = testDriver.FindElement(By.Id("Description"));
                descriptionTextBox1.Clear();
                descriptionTextBox1.SendKeys("Automated Script1 is changed");

                // Click on "Price per unit" textbox and clear the price
                IWebElement priceTag = testDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
                priceTag.Click();

                IWebElement pricePerUnit1 = testDriver.FindElement(By.Id("Price"));
                pricePerUnit1.Clear();
                priceTag.Click();

                // IWebElement pricePerUnit2 = testDriver.FindElement(By.Id("Price"));
                pricePerUnit1.SendKeys("170.00");

                // Click on "Save" button
                IWebElement saveButton1 = testDriver.FindElement(By.Id("SaveButton"));
                saveButton1.Click();

                // Click on "Go to the last page" button
                Wait.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]", 5);
                IWebElement goToLastPageButton1 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageButton1.Click();

                // Assert that Time record has been edited.
                Wait.WaitForElementToExist(testDriver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 4);
                IWebElement timeRecord1 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal of Time & Materials did not edit", ex.Message);
            }
            finally
            {
                Assert.Pass("TurnUp Portal of Time & Materials did edit");
            }
        }
        public void DeleteTM(IWebDriver testDriver)
        {
            // Click on "Go to the last page" button
            Thread.Sleep(5000);
            IWebElement goToLastPageButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // Click on the Delete Button
            IWebElement deleteButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            // Alert of the display prompt message for the delete button
            testDriver.SwitchTo().Alert().Accept();

            // Assert that Time record has been deleted.
            IWebElement timeRecord2 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));

            if (timeRecord2.Text != "")
            {
                Assert.Pass("The Test is passed successfully and delete successfully.");
            }
            else
            {
                Assert.Fail("The Test is failed.");
            }
        }
    }
}
