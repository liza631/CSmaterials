using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class array5
    {
        static void Mainggf(string[] args)
        {
            char[,] gameBoard = new char[3, 3];
            bool queue = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = '-';
                    Console.Write(gameBoard[i, j]);
                }
                Console.WriteLine();
            }

            while (true)
            {
                if (queue)
                {
                    Console.WriteLine("Ходит правый игрок");
                }
                else
                {
                    Console.WriteLine("Ходит левый игрок");
                }

                Console.Write("Введите номер строки: ");
                int row =Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер столбца: ");
                int column = Convert.ToInt32(Console.ReadLine());

                if (row > 3 || row < 1 || column > 3 || column < 1)
                {
                    Console.Write("Введены неверные кординаты, попробуй снова");
                    continue;
                }

                if (queue)
                {
                    gameBoard[row - 1, column - 1] = 'x';
                }
                else
                {
                    gameBoard[row - 1, column - 1] = 'o';
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(gameBoard[i, j]);
                    }
                    Console.WriteLine();
                }

                queue = !queue;
            }
        }
    }
}
