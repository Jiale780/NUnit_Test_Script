using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace My1stAutomationScript
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open chrome browser
            IWebDriver testDriver = new ChromeDriver();

            // Launch turn up portal and maximize window
            testDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            testDriver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // Identify the username textbox enter valid username
            IWebElement usernameTextBox = testDriver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            // Identify password textbox enter valid password
            IWebElement passwordTextBox = testDriver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            // Identify login button and click
            IWebElement loginButton = testDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1500);

            // Check if user has logged in successfully
            IWebElement helloHari = testDriver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("The Test is successfully passed due to the login successfully.");
            }
            else
            {
                Console.WriteLine("The Test is failed due to the failed login message.");
            }

            // Click on administration dropdown
            IWebElement administration = testDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            // Select Time & Material from dropdown list
            IWebElement TMdropdown = testDriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMdropdown.Click();
            Thread.Sleep(2000);

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
            Thread.Sleep(5000);

            // Assert that Time record has been created.
            IWebElement goToLastPageBtn = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn.Click();

            IWebElement timeRecord = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if(timeRecord.Text == "AutomatedScript")
            {
                Console.WriteLine("The Test is successfully passed due to the new creation successfully.");
            }
            else
            {
                Console.WriteLine("The Test is failed.");
            }

            // Click on the Edit Button
            IWebElement editButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            // Click on "TypeCode" from dropdown list and set the Type Code
            IWebElement typeCodeDropdown1 = testDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown1.Click();
            Thread.Sleep(2000);

            IWebElement selectMaterial = testDriver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            selectMaterial.Click();
            Thread.Sleep(2000);

            // Click on "Code" from Textbox and set the code
            IWebElement codeTextBox1 = testDriver.FindElement(By.Id("Code"));
            codeTextBox1.Clear();
            codeTextBox1.SendKeys("Automated Script1");
            Thread.Sleep(2000);

            // Click on "Description" from Textbox and set the description
            IWebElement descriptionTextBox1 = testDriver.FindElement(By.Id("Description"));
            descriptionTextBox1.Clear();
            descriptionTextBox1.SendKeys("Automated Script1 is changed");
            Thread.Sleep(2000);

            // Click on "Price per unit" textbox and clear the price
            IWebElement priceTag = testDriver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            priceTag.Click();
            Thread.Sleep(2000);

            IWebElement pricePerUnit1 = testDriver.FindElement(By.Id("Price"));
            pricePerUnit1.Clear();
            Thread.Sleep(2000);

            priceTag.Click();
            Thread.Sleep(2000);

            // IWebElement pricePerUnit2 = testDriver.FindElement(By.Id("Price"));
            pricePerUnit1.SendKeys("170.00");
            Thread.Sleep(2000);

            // Click on "Save" button
            IWebElement saveButton1 = testDriver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(5000);

            // Assert that Time record has been edited.
            IWebElement goToLastPageBtn1 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();

            IWebElement timeRecord1 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (timeRecord1.Text == "Automated Script1")
            {
                Console.WriteLine("The Test is passed successfully and edit successfully.");
            }
            else
            {
                Console.WriteLine("The Test is failed.");
            }

            // Click on the Delete Button
            IWebElement deleteButton = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(5000);

            testDriver.SwitchTo().Alert().Accept();

            // Assert that Time record has been deleted.
            IWebElement goToLastPageBtn2 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn2.Click();

            IWebElement timeRecord2 = testDriver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));

            if (timeRecord2.Text != "")
            {
                Console.WriteLine("The Test is passed successfully and delete successfully.");
            }
            else
            {
                Console.WriteLine("The Test is failed.");
            }
        }
    }
}
