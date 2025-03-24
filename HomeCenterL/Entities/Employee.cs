using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL
{

    class Employee
    {
        public string branch_name { get; set; }
        public string emp_name { get; set; }
        public string emp_lastname { get; set; }
        public string position { get; set; }
        public string phone { get; set; }


        public Employee() { }

        public Employee(string branch_name, string emp_name, string emp_lastname, string position, string phone)
        {
            this.branch_name = branch_name;
            this.emp_name = emp_name;
            this.emp_lastname = emp_lastname;
            this.position = position;
            this.phone = phone;
        }
    }
}
