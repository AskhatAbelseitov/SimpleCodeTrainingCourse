using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays_Part_2
{
    internal class Program   //Заполнение массива с клавиатуры
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 2];

           

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("X:" + i + " Y:" + j);
                    myArray[i, j] = int.Parse(Console.ReadLine()); //Если данные будут string то парсить не надо!

                }
            }


            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
