using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL
{
    class Supplier
    {
        public string country_name { get; set; }
        public string company_name { get; set; }
        public string contact_name { get; set; }
        public string contact_phone { get; set; }
        public string email { get; set; }
        public string s_address { get; set; }


        public Supplier() { }

        public Supplier(string country_name, string company_name, string contact_name, string contact_phone, string email, string s_address)
        {
            this.country_name = country_name;
            this.company_name = company_name;
            this.contact_name = contact_name;
            this.contact_phone = contact_phone;
            this.email = email;
            this.s_address = s_address;
        }
    }
}
