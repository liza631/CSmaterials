using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class for1
    {
        static void Main3(string[] args)
        {
            Console.Write("Введите размер стороны квадрата:");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int g = 0; g < size; g++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}