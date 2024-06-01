using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddresbookTest
{
    internal class ContactsData
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";
        

       

        public string Firstname
        { 
            get 
            {
                return this.firstname;
            }
            set 
            {
                this.firstname = value;
            }
        }

        public string  Middlename
        {
            get 
            {
            return this.middlename;
            }
            set
            {
                this.middlename = value;
            }
        }

       public string Lastname
        {
            get 
            {
                return this.lastname;
            }
            set 
            {
                this.lastname = value;
            }
        }
    }
}
