using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class array6
    {
        static void Main64(string[] args)
        {
            char[,] treasureMap = new char[10, 10];

            Random random = new Random();

            int y = random.Next(0, 10);
            int x = random.Next(0, 10);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    treasureMap[i, j] = '#';
                    Console.Write(treasureMap[i, j]);
                }
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Найдите сокровища");
                Console.Write("Введите кординаты по x: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите кординаты по y: ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a == x || b == y)
                {
                    Console.WriteLine("Сокровище найдено!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Сщкровище не найдено");
                    treasureMap[a - 1, b - 1] = '_';

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write(treasureMap[i, j]);
                        }
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
