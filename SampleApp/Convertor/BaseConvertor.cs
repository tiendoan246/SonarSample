using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Convertor
{
    public abstract class BaseConvertor<T, V> : IConvertor<T, V>
    {
        public abstract V Convert(T item);

        public abstract T Convert(V item);

        public IList<T> Convert(IList<V> items)
        {
            IList<T> list = new List<T>();
            foreach(var item in items)
            {
                list.Add(Convert(item));
            }
            return list;
        }
        public IList<V> Convert(IList<T> items)
        {
            IList<V> list = new List<V>();
            foreach (var item in items)
            {
                list.Add(Convert(item));
            }
            return list;
        }
    }
}
