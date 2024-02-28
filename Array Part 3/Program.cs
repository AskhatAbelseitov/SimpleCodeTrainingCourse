using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays_Part_1
{
    internal class Program  //Индексы и диапазоны
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 20, 300, 2, 3, 4 };

            Index myIndex = new Index(0, false);

            Console.WriteLine(myArray[myIndex]);            
        }
    }
}
