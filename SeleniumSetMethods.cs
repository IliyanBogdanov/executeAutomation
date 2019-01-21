using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1
{
    class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if(elementtype == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);

        }

        //Click into a button, chechbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down 
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {

            if (elementtype == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
