using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddresbookTest
{
    [TestFixture]
    public class AddContact : TestBase
    {
       
        [Test]
        public void AddContacts()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitContactssCreation();
            ContactsData group = new ContactsData("aaa");
            group.Middlename = "bbb";
            group.Lastname = "ccc";
            FillContactsForm(group);
            SubmitContactsCreation();
            ReturnToContactsPage();

        }
    }
}

