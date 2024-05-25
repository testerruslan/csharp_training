﻿using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    public class TestBase
    {
             

        protected ApplicationManager app;

        protected LoginHelper loginHelper;

        [SetUp]
        public void SetupTest()
        {
           app = new ApplicationManager();
           app.Navigator.GoToHomePage();
           app.Auth.Login(new AccountData("admin", "secret"));

        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }

        
    }
}