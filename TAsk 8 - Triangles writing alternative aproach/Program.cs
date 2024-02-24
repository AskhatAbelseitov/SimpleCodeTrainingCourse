using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Working_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Первый треугольник
            /*for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(0, i);

                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                Console.WriteLine();
            }*/



            //Второй треугольник
            /*for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(0, i);

                for (int j = 10; j >= i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                Console.WriteLine();
            }*/



            //Третий треугольник
            /*for (int i = 0; i <= 10; i++)
            {
                Console.SetCursorPosition(10 - i, i);

                for (int j = 0; j < i; j++) 
                { 
                    Console.Write("#");                 
                }
                Console.WriteLine();
                Console.WriteLine();
            }*/


            //Четвертый треугольник
            for (int i = 0; i <= 10; i++)
            {
                Console.SetCursorPosition(i, i);

                for (int j = 10; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
