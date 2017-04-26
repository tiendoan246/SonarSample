using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Convertor
{
    public interface IConvertor<T, V>
    {
        T Convert(V item);
        V Convert(T item);
        IList<T> Convert(IList<V> items);
        IList<V> Convert(IList<T> items);
    }
}
