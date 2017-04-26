using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services
{
    public class ProductService : IProductService
    {
        public void add(Product pro)
        {
            throw new NotImplementedException();
        }

        public List<Product> FindAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Iphone 5S", "VND", 15.000, "IP"));
            products.Add(new Product(2, "Iphone 6S", "VND", 22.000, "IP"));
            products.Add(new Product(3, "Samsung A8", "VND", 8.000, "SM"));

            return products;
        }

        public Product findByID(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
