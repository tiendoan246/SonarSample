using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Model
{
    [DataContract]
    public class ProductModel
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string UnitPrice { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string CategoryID { get; set; }
    }
}
