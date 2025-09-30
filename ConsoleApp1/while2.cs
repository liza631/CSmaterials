using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class while2
    {
        static void Main41(string[] args)
        {
            Console.Write("Введите ширину:");
            int width = Console.Read();
            Console.Write("Введите высоту:");
            int heigh = Console.Read();

            int i = 0;
            int j = 0;

            while (i < width)
            {
                while (j < heigh)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }
        }
    }
}
