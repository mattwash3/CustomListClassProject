using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] items = new T[1];
        public int Count { get { return count; } }
        private int count;

        public void Add(T item)
        {
            items[0] = item;
            count++;
        }
    }
}