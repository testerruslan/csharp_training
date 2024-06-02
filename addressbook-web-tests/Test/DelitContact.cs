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
    public class DelContact : TestBase
    {
       

        [Test]
        public void DelContacts()
        {

            app.Contacts.Remowe(1);
          
        }
    }
}