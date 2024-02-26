using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Working_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 10, 18, 190 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);               
            }

            Console.WriteLine(myArray.Length);


        }
    }
}
