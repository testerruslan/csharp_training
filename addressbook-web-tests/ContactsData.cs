using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactsData
    {
        private string name;
        private string lastname = "";
        private string address = "";
        private string email = "";
        private string home = "";
        private string mobile = "";

        public ContactsData (string name)
        { 
            this.name = name; 
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

        public string Lastname 
        {
            get 
            {
                return lastname;
            }
            set 
            {
                lastname = value;
            }
        }

        public string Address 
        {
            get 
            {
                return address;
            }
            set 
            {
                address = value;
            }
        }

        public string Email 
        {
            get 
            {
                return email;
            }
            set 
            {
                email = value;
            }
        }


        public string Home 
        {
            get 
            {
                return home;
            }
            set 
            {
                home = value;
            }
        }

        public string Mobile 
        {
            get 
            {
                return mobile;
            }
            set 
            {
                mobile = value;
            }
        }
    }
}
