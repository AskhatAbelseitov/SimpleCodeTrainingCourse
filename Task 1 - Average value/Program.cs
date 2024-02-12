using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, averageValue;

            Console.WriteLine("Enter your first number");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your first number is: {firstValue}");

            Console.WriteLine("Enter your second number");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your second number is: {secondValue}");

            averageValue = (firstValue + secondValue) / 2;

            Console.WriteLine($"Average value is: {averageValue}");
        }
    }
}

