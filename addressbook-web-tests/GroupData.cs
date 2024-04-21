using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class GroupData
    {
        private string name;
        private string header = "";
        private string footer;
        private string v;

        public GroupData(string v)
        {
            this.v = v;
        }

        public string Name
        { 
            get 
            {
                return name;
            }
            set 
            {
                name = value;
                    }
        }
        public string Header 
        {
            get 
            {
                return header;
            }
            set 
            {
                header = value;
            }
        }

        public string Footer 
        {
            get 
            {
                return footer;
            }
            set 
            {
                footer = value;
            }
        }
    }
}
