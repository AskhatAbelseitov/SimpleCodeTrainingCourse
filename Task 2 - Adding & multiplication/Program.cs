using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue, addValue, multValue;

            Console.WriteLine("Enter your first number");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your first number is: {firstValue}");

            Console.WriteLine("Enter your second number");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your second number is: {firstValue}");

            Console.WriteLine("Enter your third number");

            thirdValue = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your third number is: {secondValue}");

            addValue = firstValue + secondValue + thirdValue;

            multValue = firstValue * secondValue * thirdValue;

            Console.WriteLine($"Adding result is: {addValue} and multiplication result is: {multValue}");
        }
    }
}

