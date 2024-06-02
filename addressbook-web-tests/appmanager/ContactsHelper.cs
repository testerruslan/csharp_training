using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddresbookTest
{
    public class ContactsHelper : HelperBase
    {
      

        public ContactsHelper(ApplicationManager manager) : base(manager)
        { }
       
        public ContactsHelper CreateContacts(ContactsData group)
        {

            InitContactssCreation();
            FillContactsForm(group);
            SubmitContactsCreation();
            ReturnToContactsPage();
            return this;
        }

        public ContactsHelper InitContactssCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactsHelper FillContactsForm(ContactsData group)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(group.Firstname);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(group.Middlename);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(group.Lastname);
            return this;
        }

        public ContactsHelper SubmitContactsCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public ContactsHelper ReturnToContactsPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }


        public ContactsHelper SelectionContactsPage()
        {
            driver.FindElement(By.Id("16")).Click();
            return this;
        }

        public ContactsHelper DelitContactsPage()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactsHelper Remowe(int v)
        {

             SelectionContactsPage();
             DelitContactsPage();
            return this;

        }

      
    }
}
