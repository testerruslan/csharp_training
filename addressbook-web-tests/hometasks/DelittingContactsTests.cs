using NUnit.Framework;


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
    }
}

