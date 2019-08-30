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

        public T this[int indexRange]
        {
            get
            {
                if (indexRange >= count)
                {
                    throw new IndexOutOfRangeException($"List can only hold {capacity} elements.");
                }
                return thangs[indexRange];
            }
            set
            {
                if (indexRange >= count)
                {
                    throw new IndexOutOfRangeException($"List can only hold {capacity} elements.");
                }
                thangs[indexRange] = value;
            }
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
                capacity = (capacity * 2);               
                T[] newArray = new T[capacity];
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
                if (thangToRemove.Equals(thangs[i]))
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

        public override string ToString()
        {
            string strings = "";
            if (this.count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    strings += thangs[i].ToString() + ",";
                }
                strings += thangs[count - 1].ToString();
            }
            return strings;
        }

        public static CustomList<T> operator +(CustomList<T> initialList, CustomList<T> secondaryList)
        {
            CustomList<T> combinedLists = new CustomList<T>();
            for (int i = 0; i < initialList.count; i++)
            {
                combinedLists.Add(initialList.thangs[i]);
            }
            for (int i = 0; i < secondaryList.count; i++)
            {
                combinedLists.Add(secondaryList.thangs[i]);
            }
            return combinedLists;
        }

        public static CustomList<T> operator -(CustomList<T> initialList, CustomList<T> secondaryList)
        {
            CustomList<T> shrunkenList = new CustomList<T>();
            int number = 0;
            for (int i = 0; i < initialList.Count; i++)
            {
                //for (int i = 0; i < secondaryList.Count; i++)
                //{
                //    initialList.Remove(secondaryList.thangs[i]);
                //}
                for (int j = 0; j < secondaryList.Count; j++)
                {
                    if (initialList.thangs[i].Equals(secondaryList.thangs[j]))
                    {
                        number++;
                    }
                }
                if (number == 0)
                {
                    shrunkenList.Add(initialList.thangs[i]);
                }
                number = 0;
            }
            return shrunkenList;
        }

        public CustomList<T> Zip(CustomList<T> list)
        {
            CustomList<T> zipList = new CustomList<T>();
            if (count > list.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    zipList.Add(thangs[i]);
                    if (list[i] == null)
                    {

                    }
                    else
                    {
                        zipList.Add(list[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.count; i++)
                {
                    if (thangs[i] == null)
                    {

                    }
                    else
                    {
                        zipList.Add(thangs[i]);
                    }
                    zipList.Add(list[i]);
                }
            }
            return zipList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return thangs[i];
            }           
        }    
    }





















}