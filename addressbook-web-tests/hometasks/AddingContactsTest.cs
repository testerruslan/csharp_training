
using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace WebAddressbookTests
{
    [TestFixture]
    public class AddingContactsTest : TestBase
    {


        [Test]
        public void AddingContactsTests()
        {
            GoToHomePage();
            Login(new AccountData ("admin", "secret"));
            GoToContactsPage();
            InitNewContacts();
            ContactsData group = new ContactsData("Test");
            group.Lastname = "Testov";
            group.Address = "Russia";
            group.Email = "tester@ya.ru";
            group.Home = "1234567890";
            group.Mobile = "1234567890";
            FillContactsForm(group);
            SubmitContactsCreation();
            ReturnToContactsPage();
        }

        private void GoToHomePage()
        {
            throw new NotImplementedException();
        }

        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        protected void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        protected void InitNewContacts()
        {
            driver.FindElement(By.Name("firstname")).Click();
        }

        protected void FillContactsForm(ContactsData group)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(group.Name);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(group.Lastname);
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(group.Address);
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(group.Email);
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(group.Home);
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(group.Mobile);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
        }

        protected void SubmitContactsCreation()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        protected void ReturnToContactsPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}
