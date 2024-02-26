using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array capacity");

            int arrayCapacity = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayCapacity];

            Console.WriteLine("\nEnter array numbers");

            for (int i = 0; i < arrayCapacity; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();



            Console.WriteLine("Array is:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine();
           


            Console.WriteLine("Array in descending order is:");
            for (int i = myArray.Length - 1; i >= 0;  i--)
            {                
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine();
           

                        
            int evenNumbersSum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)

                    evenNumbersSum = evenNumbersSum + myArray[i];
            }
            Console.WriteLine($"Even numbers sum is: {evenNumbersSum}");


            //Второй вариант поиска наименьшего числа через цикл
            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }               
            }
            Console.WriteLine($"Minimum value in array is: {minValue}");
            Console.WriteLine();


            Console.WriteLine("\nThe least number in array is: " + Enumerable.Min(myArray));
            Console.WriteLine("\nThe maximum number in array is: " + Enumerable.Max(myArray));
            Console.WriteLine("\nThe average number in array is: " + Enumerable.Average(myArray));

        }
    }
}
