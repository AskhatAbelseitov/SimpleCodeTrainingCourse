﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays_Part_1
{
    internal class Program  //Заполнение массива случайными цифрами
    {
        static void Main(string[] args)
        {
            int [,] myArray = new int[10, 10];

            Random random = new Random();


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100); //100 - это ограничение по максимальному числу
                }
            }
            
            
            for (int y = 0; y < myArray.GetLength(0); y++)
            {             
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }            
        }
    }
}
