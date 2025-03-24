using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL
{
       class Customer
        {
            public string customer_name { get; set; }
            public string lastname { get; set; }
            public int NIT { get; set; }
            public string phone { get; set; }
            public string c_address { get; set; }


        public Customer() { }

            public Customer(string customer_name, string lastname, int NIT, string phone, string c_address)
            {
                this.customer_name = customer_name;
                this.lastname = lastname;
                this.NIT = NIT;
                this.phone = phone;
                this.c_address = c_address;
            }
        }
}
