using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__8
{
    public class GenericKeeper<T>
    {
        static List<T> Items = new List<T>();
        public void AddItem(T item)
        {
            Items.Add(item);
        }
        public List<T> ShowItem()
        {
            List<T> items = new List<T>(Items);
            return items;
        }
    }
}
