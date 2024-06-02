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
    public class AddGroup : TestBase
    {

        [Test]
        public void AddGroups()
        {
            
            GroupData group = new GroupData("11");
            group.Header = "22";
            group.Footer = "33";

            app.Groups.CreateGroup(group);
         
        }

        [Test]
        public void EmptyAddGroups()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            
            app.Groups.CreateGroup(group);
        }   
    }

}
