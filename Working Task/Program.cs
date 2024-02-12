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
            int fanSpeed = 3000;

            bool isHighTemperature = false;

            bool hasNoColling = fanSpeed <= 10;

            if (hasNoColling || isHighTemperature)
            {
                Console.WriteLine("Processor is broken!");
            }
        }
    }
}
