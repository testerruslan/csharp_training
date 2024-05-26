using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Docker.DotNet.Models;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Click();
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }

        }

        public void Type1(By locator1, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator1).Clear();
                driver.FindElement(locator1).SendKeys(text);
            }

        }
    }

    

    
}