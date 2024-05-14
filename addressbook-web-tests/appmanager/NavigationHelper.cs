﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase

    {
               protected string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
                       this.baseURL = baseURL;
        }

    
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/addressbook/");
        }


        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
     
}
