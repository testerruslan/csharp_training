using OpenQA.Selenium;
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
    public class GroupHelper : HelperBase
    {
       
        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }


        public GroupHelper CreatAddingContacts(ContactsData group)
        {
            manager.Navigator.GoToContactsPage();
            InitNewContacts();
            FillContactsForm(group);
            SubmitContactsCreation();
            ReturnToContactsPage();

            return this;
        }

       

        public GroupHelper CreatDelittingContacts(ContactsData group)
        {
            manager.Navigator.GoToContactsPageDelit();
            SelectContacts();
            RemoveContacts();
            ReturnToContactsPage();
            return this;
        }

        private void SelectContacts()
        {
            throw new NotImplementedException();
        }

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitNewGroupsCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Modify2(int v, ContactsData newData)
        {
            manager.Navigator.GoToContactsPage();
            SelectContacts(1);
            InitContactsModification();
            FillContactsForm(newData);
            SubmitContactsCreation();
            ReturnToContactsPage();

            return this;
        }

        public GroupHelper InitContactsModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper Modify(int p, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();

            return this;
        }

      

        public GroupHelper Remov(int v)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(v);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper InitNewGroupsCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);

            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper InitNewContacts()
        {
            driver.FindElement(By.Name("firstname")).Click();
            return this;
        }

        public GroupHelper FillContactsForm(ContactsData group)
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

            return this;
        }

        public GroupHelper SubmitContactsCreation()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public GroupHelper ReturnToContactsPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }

        public GroupHelper SelectContacts(int v)
        {
            driver.FindElement(By.Id("1")).Click();
            return this;
        }

        public GroupHelper RemoveContacts()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public GroupHelper CreatDelittingContacts(GroupData group)
        {
            
            return this;
        }

        public GroupHelper Modify2(object v, ContactsData newData)
        {
            
            return this;
        }
    }
}