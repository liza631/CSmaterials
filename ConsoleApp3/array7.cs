using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class array7
    {
        static void Main6(string[] args)
        {
            int[] numbers = new int[10];
            int[] squares = new int[10];
            int[] cubes = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                Console.Write(numbers[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                squares[i] = i * i;
                Console.Write(squares[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                cubes[i] = i * i * i;
                Console.Write(cubes[i]);
            }
            Console.WriteLine();



        }
    }
}
