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
            int count = 5;
            do
            {
                count++;
                Console.WriteLine(count);
            }
            while (count < 5);
        }
    }
}
