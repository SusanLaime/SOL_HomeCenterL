using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL
{
    class Purchase
    {
        public string SupplierName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Detail { get; set; }
        public string ProductName1 { get; set; }
        public int Quantity1 { get; set; }
        public decimal UnitaryCost1 { get; set; }
        public string ProductName2 { get; set; }
        public int Quantity2 { get; set; } =  0;
        public decimal UnitaryCost2 { get; set; } = 0;

        public Purchase() { }

        public Purchase(string supplierName, DateTime purchaseDate, string detail, string productName1, int quantity1, decimal unitaryCost1,
                        string productName2, int quantity2, decimal unitaryCost2)
        {
            SupplierName = supplierName;
            PurchaseDate = purchaseDate;
            Detail = detail;
            ProductName1 = productName1;
            Quantity1 = quantity1;
            UnitaryCost1 = unitaryCost1;
            ProductName2 = productName2;
            Quantity2 = quantity2;
            UnitaryCost2 = unitaryCost2;
        }
    }
}
