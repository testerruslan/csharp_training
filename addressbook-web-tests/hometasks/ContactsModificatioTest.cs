using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests

{
    [TestFixture]
    public class ContactsModificatioTest : AuthTestBase
    {
        private object v;

        [Test]
        public void ContactsModificationTests()
        {
            ContactsData newData = new ContactsData("aa");
            newData.Lastname = "bbb";
            newData.Address = "ccc";
            newData.Email = "ddd@ya.ru";
            newData.Home = "000";
            newData.Mobile = "111";
            app.Groups.Modify2(v, newData);
        }
    }
}
