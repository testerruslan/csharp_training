
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class AddingContactsTest : AuthTestBase
    {


        [Test]
        public void AddingContactsTests()
        {
           
            
            ContactsData group = new ContactsData("Test");
            group.Lastname = "Testov";
            group.Address = "Russia";
            group.Email = "tester@ya.ru";
            group.Home = "1234567890";
            group.Mobile = "1234567890";
            app.Groups.CreatAddingContacts(group);
              
        }

        [Test]
        public void EmptyAddingContactsTests()
        {

            
            ContactsData group = new ContactsData("Test");
            group.Lastname = "";
            group.Address = "";
            group.Email = "";
            group.Home = "";
            group.Mobile = "";
            app.Groups.CreatAddingContacts(group);

        }
    }
}
