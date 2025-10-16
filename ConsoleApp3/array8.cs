using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class array8
    {
        static void Mainцук(string[] args)
        {
            string filedString =
                "#######" +
                "#     #" +
                "##  # #" +
                "#   ###" +
                "### # #" +
                "#     #" +
                "#######";

            char[][] fieled = new char[7][];
            fieled[0] = filedString.Substring(0, 7).ToCharArray();
            fieled[1] = filedString.Substring(7, 7).ToCharArray();
            fieled[2] = filedString.Substring(14, 7).ToCharArray();
            fieled[3] = filedString.Substring(21, 7).ToCharArray();
            fieled[4] = filedString.Substring(28, 7).ToCharArray();
            fieled[5] = filedString.Substring(35, 7).ToCharArray();
            fieled[6] = filedString.Substring(42, 7).ToCharArray();

            int playerX = 3;
            int playerY = 5;
            while (true)
            {
                fieled[playerY][playerX] = '*';

                for (int i = 0; i < fieled.Length; i++)
                {
                    for (int j = 0; j < fieled[i].Length; j++)
                    {
                        if (fieled[i][j] == ' ')
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (fieled[i][j] == '#')
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else if (fieled[i][j] == '*')
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.BackgroundColor = ConsoleColor.Black;

                char direction = Console.ReadKey().KeyChar;

                fieled[playerY][playerX] = ' ';
                Console.Clear();

                switch (direction)
                {
                    case 'd':
                        if (fieled[playerY][playerX + 1] != '#')
                        {
                        playerX += 1;
                        }
                        break;
                    case 'a':
                        if (fieled[playerY][playerX - 1] != '#')
                        {
                            playerX -= 1;
                        }
                        break;
                    case 'w':
                        if (fieled[playerY - 1][playerX] != '#')
                        {
                            playerY -= 1;
                        }
                        break;
                    case 's':
                        if (fieled[playerY + 1][playerX] != '#')
                        {
                            playerY += 1;
                        }
                        break;
                }
            }
;

        }
    }
}
