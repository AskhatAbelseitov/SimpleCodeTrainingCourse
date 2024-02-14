using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your start number");            
            int curentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your end number");
            int limit = int.Parse(Console.ReadLine());

            uint evenNumbersCount = 0;
            uint oddNumbersCount = 0;

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;


            while (curentValue <= limit)
            {               
                if (curentValue%2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += curentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += curentValue;
                }
                curentValue++;
            }

            Console.WriteLine("Even numbers are: " + evenNumbersCount);
            Console.WriteLine("Odd numbers are: " + oddNumbersCount);
            Console.WriteLine("Even numbers sum is: " + evenNumbersSum);
            Console.WriteLine("Odd numbers sum is: " + oddNumbersSum);

            Console.ReadLine();
        }
    }
}
