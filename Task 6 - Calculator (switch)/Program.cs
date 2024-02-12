using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.Clear();

            double firstValue, secondValue;

                try
                {
                    Console.WriteLine("Enter your first number");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your second number");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch                 
                {
                    Console.WriteLine("Exception!");
                    Console.ReadLine();
                    continue;                
                }            

            Console.WriteLine("Choose your action: +  -  *  /");

            string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine($"Adding result is {firstValue + secondValue}");
                        break;

                    case "-":
                        Console.WriteLine($"Subtraction result is {firstValue - secondValue}");
                        break;

                    case "*":
                        Console.WriteLine($"Multiplication result is {firstValue * secondValue}");
                        break;

                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Division on zero is frobidden");
                        }
                        else
                        {
                            Console.WriteLine($"Division result is {firstValue / secondValue}");
                        }
                        break;

                    default:
                        Console.WriteLine("You entered an invalid action");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
