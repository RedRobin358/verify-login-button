using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;

namespace Selinium
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {




        }
        [SetUp]
        public void Initiator()
        {
            driver.Navigate().GoToUrl("https://sr-rs.facebook.com/");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void Executer()
        {
            //seleniumTestMetod.dropDown(driver, "", "", "");

            seleniumTestMetod.EnterText(driver, "email", "aca", "Name");

            seleniumTestMetod.EnterText(driver, "pass", "Aca", "Name");

            seleniumTestMetod.ClickButton(driver, "login", "Name");



            Console.WriteLine("Insert Text,Click button");

        }

        //[TearDown]
        //public void Closer()
        //{
        //    driver.Close();
        //    Console.WriteLine("finished test");
        //}
    }

}
