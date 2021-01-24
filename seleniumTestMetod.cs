using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Selinium
{
    class SeleniumTestMetod
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);

            }
            else if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }

        }
        public static void ClickButton(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
            {
                driver.FindElement(By.Id(element)).Click();

            }
            else if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).Click();

            }
            

        }
        public static void DropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
             if(elementtype=="Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
             
        }
    }
}
