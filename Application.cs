using SampleApp.Model;
using SampleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class Application
    {
        private List<Product> products;
        private IProductService productService = new ProductService();

        public Application()
        {
            initial();
        }

        public static void Main(string[] args)
        {
            new Application();
            Console.ReadLine();
        }
        private void initial()
        {
            products = productService.FindAll();
        }

        public void GetProductPrice(out string name)
        {
            var pro = products.Where(p => p.CategoryID.Equals("IP")).SingleOrDefault();
            name = pro.Name;
        }
    }
}
