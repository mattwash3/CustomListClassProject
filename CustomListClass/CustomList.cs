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
        public int thang;
        public int numbers;

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
            thang.Add(thangs);
        }

        public void Add(T thang)
        {
            // what if we run out of room?
            thangs[count] = thang; // where do we add an item? (not always 0)
            count++;
            if (count == capacity)
            {
                capacity *= 2;               
                T[]newArray = new T[capacity];
                for (int item = 0; item < count; item++)
                {
                    newArray[item] = thangs[item];
                }
                thangs = newArray;
            }   
        }

        public void Remove(T thangToRemove)
        {
            thangs[count] = thangToRemove;
            count--;
            for(int item = 0; item < thangToRemove.Length - 1; item++)
            {
                thangToRemove[item] = thangToRemove[item + 1];
            }
            thangs.Resize();
            //thangToRemove;
            count--;
            if (thangs[i].Equals(thangToRemove))
            {
                
            }
            
        }

        public void Length()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


        public void Zip()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < thangs.Length; i++)
            {
                yield return thangs[i];
                yield return thangsList[i];
            }
            yield return ;
        }
    }





















}