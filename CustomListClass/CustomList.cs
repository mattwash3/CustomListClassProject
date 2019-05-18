using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        private T[] thangs;

        public int Count { get { return count; } }
        private int count;
        public int Capacity { get { return capacity; } }
        private int capacity;
        public int thang;
        public int numbers;

        public T this[int indexRange]
        {
            get { return thangs[indexRange]; }
            set { thangs[indexRange] = value; }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            thangs = new T[capacity];

        }

        public void Add(T thang)
        {

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
            thangs[count] = thang;
            count++;
        }

        public bool Remove(T thangToRemove)
        {
            for (int i = 0; i < count; i++)
            {  
                if (thangs[i].Equals(thangToRemove))
                {
                    for(int j = i; j < (count -1); j++)
                    {
                        thangs[j] = thangs[j + 1];
                    }
                    count--;
                    thangs[count] = default(T); 
                    return true;
                }               
            }
            return false;
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < thangs.Length; i++)
            {
                yield return thangs[i];
            }           
        }    
    }





















}