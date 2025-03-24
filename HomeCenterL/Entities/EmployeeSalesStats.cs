using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL.Entities
{
    class EmployeeSalesStats
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalSales { get; set; }
        public decimal TotalAmount { get; set; }

        public EmployeeSalesStats() { }

        public EmployeeSalesStats(string employeeName, string employeeLastname, DateTime startDate, DateTime endDate, int totalSales, decimal totalAmount)
        {
            EmployeeName = employeeName;
            EmployeeLastname = employeeLastname;
            StartDate = startDate;
            EndDate = endDate;
            TotalSales = totalSales;
            TotalAmount = totalAmount;
        }
    }
}
