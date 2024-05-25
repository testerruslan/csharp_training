using Docker.DotNet.Models;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class DelittingContactsTests : TestBase
    {
        private GroupData group;

        [Test]
        public void DelittingContactsTest()
        {
           
            
            app.Groups.CreatDelittingContacts(group);
            Driver.SwitchTo().Alert().private Accept();
        }

        
    }

}

