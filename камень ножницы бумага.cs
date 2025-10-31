using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Игра камень, ножницы, бумага ===\n" +
                "Выберете чем сделать ход: \n" +
                "1. камень\n" +
                "2. ножницы\n" +
                "3. бумага");
            int choce = Convert.ToInt32(Console.ReadLine());
            if (choce < 1 || choce > 3)
            {
                Console.WriteLine("Неверный номер ответа!");
            }
            else
            {
                Random random = new Random();
                int d = random.Next(1, 3);

                Console.WriteLine($"Бот: {d}");
                if (random.Next(1) == d)
                {
                    if (choce == 1)
                    {
                        Console.WriteLine("Ничья!");
                    }
                    else if (choce == 2)
                    {
                        Console.WriteLine("Вы проиграли!");
                    }
                    else if (choce == 3)
                    {
                        Console.WriteLine("Вы победили!");
                    }
                }
                else if (random.Next(2) == d)
                {
                    if (choce == 1)
                    {
                        Console.WriteLine("Вы победили!");
                    }
                    else if (choce == 2)
                    {
                        Console.WriteLine("Ничья!");
                    }
                    else if (choce == 3)
                    {
                        Console.WriteLine("Вы проиграли!");
                    }
                }
                else if (random.Next(3) == d)
                {
                    if (choce == 1)
                    {
                        Console.WriteLine("Вы проиграли!");
                    }
                    else if (choce == 2)
                    {
                        Console.WriteLine("Вы победили!");
                    }
                    else if (choce == 3)
                    {
                        Console.WriteLine("Ничья!");
                    }
                }
            }
            
        }
    }
}
