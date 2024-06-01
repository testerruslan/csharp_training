using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddresbookTest
{
    public class ContactsData
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";
        
        public ContactsData(string firstname)
        {
            Firstname = firstname;
    
        }

       

        public string Firstname
        { 
            get 
            {
                return firstname;
            }
            set 
            {
                firstname = value;
            }
        }

        public string  Middlename
        {
            get 
            {
            return middlename;
            }
            set
            {
               middlename = value;
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
    }
}
