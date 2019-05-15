using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(6);
            numbers.Add(10);
            numbers.Add(16);
        }
    }
}
