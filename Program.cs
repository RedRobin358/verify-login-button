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
        public void a()
        {
            driver.Navigate().GoToUrl("https://sr-rs.facebook.com/");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void b()
        {
            //seleniumTestMetod.dropDown(driver, "", "", "");

            seleniumTestMetod.EnterText(driver, "email", "aca", "Name");

            seleniumTestMetod.EnterText(driver, "pass", "Aca", "Name");

            seleniumTestMetod.clickButton(driver, "login", "Name");



            Console.WriteLine("Tested ddm,insert Text,lick button");

        }

        //[TearDown]
        //public void c()
        //{
        //    driver.Close();
        //    Console.WriteLine("finished test");
        //}
    }
}
