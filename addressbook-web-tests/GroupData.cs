﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddresbookTest
{
    internal class GroupData
    {
        private string name;
        private string header = "";
        private string footer = "";

        

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
                return this.footer;
            }
            set
            {
                this.footer = value;
            }
        }

    }
}
