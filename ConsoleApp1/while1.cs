using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class while1
    {
        static void Main6(string[] args)
        {
            int i = 0;
            int j = 0;

            while (i < 10)
            {
                while (j < 10)
                {
                    Console.Write($"{i} * {j} = {i * j} |");
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }

            i = 0;
            j = 0;
            do
            {
                Console.Write($"{i} * {j} = {i * j} |");
                j++;
            }
            while (j < 10);
        }
    }
}
