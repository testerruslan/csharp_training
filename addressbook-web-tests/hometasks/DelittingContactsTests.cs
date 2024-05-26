using Docker.DotNet.Models;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class DelittingContactsTests : AuthTestBase
    {
        private GroupData group;

        [Test]
        public void DelittingContactsTest()
        {
           
            
            app.Groups.CreatDelittingContacts(group);
           
        }

        
    }

}

