using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollarRate = 442.34;
            double euroRate = 482.56;
            double nationalCurrency;
            
            Console.WriteLine("Enter your sum in the national currency");

            nationalCurrency = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your sum is {nationalCurrency} tenge");

            double dollarCurrency  = nationalCurrency / dollarRate;

            double euroCurrency = nationalCurrency / euroRate;

            Console.WriteLine($"Your exchange course is: {dollarCurrency} dollars or {euroCurrency} euro");
        }
    }
}

