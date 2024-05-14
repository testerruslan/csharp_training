
using NUnit.Framework;


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
    }
}
