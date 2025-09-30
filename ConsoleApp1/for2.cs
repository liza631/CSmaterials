using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class for2
    {
        static void Mainfor2(string[] args)
        {
            Console.WriteLine("От:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("До:");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int j = min; j < max; j++)
            {
                for (int i = min; i < max; i++)
                {
                    Console.Write($"{j} * {i} = {i * j} |");
                }

                Console.WriteLine();
            }
        }
    }
}
