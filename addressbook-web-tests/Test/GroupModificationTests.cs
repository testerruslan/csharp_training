using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddresbookTest
{
    [TestFixture]

    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {

            GroupData newData = new GroupData("121");
            newData.Header = "232";
            newData.Footer = "343";

            app.Groups.Modify(1, newData);

            

        }
    }
}
