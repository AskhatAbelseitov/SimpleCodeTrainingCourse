using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());  

            switch (a)
            {
                case 0:
                case 1: 
                case 3: 
                case 4:
                Console.WriteLine("Your entered from 1 to 4");
                        break;
                default: Console.WriteLine("Your entered wrong number");
                        break;
            }
        }
    }
}
