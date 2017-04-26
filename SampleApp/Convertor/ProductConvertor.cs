using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Convertor
{
    public class ProductConvertor : BaseConvertor<Product, ProductModel>
    {
        public override Product Convert(ProductModel item)
        {
            throw new NotImplementedException();
        }

        public override ProductModel Convert(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
