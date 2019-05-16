using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        private T[] thangs;
        private CustomList<T> thangsList;
        public int Count { get { return count; } }
        private int count;
        private int capacity;

        public T this[int i]
        {
            get { return thangs[i]; }
            set { thangs[i] = value; }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            thangs = new T[capacity];
        }

        public void Add(T thang)
        {
            // what if we run out of room?
            thangs[count] = thang; // where do we add an item? (not always 0)
            if (count == capacity)
            {

            }
            count++;
        }

        public void Remove()
        {

        }

        public void Length()
        {

        }

        public void Zip()
        {

        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < thangs.Lenth; index++)
            {
                yield return thangs[index];
                yield return thangsList[index];
            }
            yield return "Stuff and Thangs";
        }
    }





















}