using NUnit.Framework;
using NUnitTestProject1;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            //Navigate to Execute automation demo page
            driver.Url = ("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetTextFromDDL(driver,"TitleId","Id"));
            Console.WriteLine("The value from my Initial is:" + SeleniumGetMethods.GetText(driver,"Initial","Name"));

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}