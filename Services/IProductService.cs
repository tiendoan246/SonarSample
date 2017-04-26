using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services
{
    public interface IProductService
    {
        void add(Product pro);
        void remove(int id);
        Product findByID(int id);
        List<Product> FindAll();
    }
}
