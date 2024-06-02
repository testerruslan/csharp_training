using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;


namespace WebAddresbookTest
{
    public class LoginHelper : HelperBase
    {


        public LoginHelper(ApplicationManager manager) 
            : base(manager)
        { }
        
        public void Login(AccountData account)
        {
            if (IsLoggedIn ())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }

            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
                == "(" + account.Username + ")";
     
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
           
        }

        public void Logout()
        {
            if (IsLoggedIn()) 
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
           
        }
    }

    
}
