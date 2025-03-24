using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL.Entities
{
    class SalesBetweenDates
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SalesBetweenDates() { }

        public SalesBetweenDates(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
