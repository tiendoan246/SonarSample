using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public double Price { get; set; }
        public string CategoryID { get; set; }

        public Product()
        {
        }

        public Product(int productID, string name, string unitPrice, double price, string categoryID)
        {
            this.ProductID = productID;
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Price = price;
            this.CategoryID = categoryID;
        }
    }
}
