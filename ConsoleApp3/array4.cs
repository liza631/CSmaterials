using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class array4
    {
        static void Main32(string[] args)
        {
            int[,] multiplicationTable = new int[9, 9];

            multiplicationTable[0, 0] = 1;

            /*
            foreach (int i in multiplicationTable)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{multiplicationTable[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
