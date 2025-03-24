using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCenterL
{
    class Product
    {
        public string category_id { get; set; }
        public string product_name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }


        public Product() {}

        public Product(string categoryid, string nameProduct, double price, int stock) {
            this.category_id = categoryid;
            this.product_name = nameProduct;
            this.price = price;
            this.stock = stock;
        }
    }
}
