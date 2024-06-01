using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace WebAddressbookTests
{
    [TestFixture]
    public class DelittingContactsTests : TestBase
    {
       

        [Test]
        public void DelittingContactsTest()
        {
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            GoToContactsPageDelit();
            SelectContacts();
            RemoveContacts();
            ReturnToContactsPage();

        }

        private void SelectContacts()
        {
            throw new NotImplementedException();
        }

        private void GoToContactsPageDelit()
        {
            throw new NotImplementedException();
        }

        private void RemoveContacts()
        {
            throw new NotImplementedException();
        }

        private void GoToHomePage()
        {
            throw new NotImplementedException();
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }



        private void ReturnToContactsPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

       
       
    }
}

