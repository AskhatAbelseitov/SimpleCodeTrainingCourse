using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollarRate = 442.34;
            double euroRate = 482.56;
            double nationalCurrency, dollarCurrency, euroCurrency;
            
            Console.WriteLine("Enter your sum in the national currency");

            nationalCurrency = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your sum is {nationalCurrency} tenge");

            Console.WriteLine($"Your exchange course is: {nationalCurrency / dollarRate} dollars or {nationalCurrency / euroRate} euro");
        }
    }
}

