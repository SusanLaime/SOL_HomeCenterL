using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL
{
    public class Sale
    {
        public string CustomerName { get; set; }
        public string BranchName { get; set; }
        public string EmployeeName { get; set; }
        public string PaymentMethodName { get; set; }
        public string SaleDetail { get; set; }  // Nullable field for sale details
        public string ProductName1 { get; set; }
        public int Quantity1 { get; set; }
        public string ProductName2 { get; set; } = null;
        public int Quantity2 { get; set; } = 0;
        public string ProductName3 { get; set; } = null;
        public int Quantity3 { get; set; } = 0;

        public Sale() { }

        public Sale(string customerName, string branchName, string employeeName, string paymentMethodName, string saleDetail,
                    string productName1, int quantity1, string productName2, int quantity2, string productName3, int quantity3)
        {
            CustomerName = customerName;
            BranchName = branchName;
            EmployeeName = employeeName;
            PaymentMethodName = paymentMethodName;
            SaleDetail = saleDetail;
            ProductName1 = productName1;
            Quantity1 = quantity1;
            ProductName2 = productName2;
            Quantity2 = quantity2;
            ProductName3 = productName3;
            Quantity3 = quantity3;
        }
    }
}