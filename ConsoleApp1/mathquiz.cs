using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class mathquiz
    {
        static void Main3(string[] args)
        {
            int score = 0;


            //создали объект который может генерировать рандомные числа
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                //rand.Next(min, max) - генерация числа от 10 до 100
                int num1 = rand.Next(10, 100);
                int num2 = rand.Next(10, 100);

                Console.WriteLine($"{num1} + {num2} =");

                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == num1 + num2)
                {
                    Console.WriteLine("Ответ правильный!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Ответ не правильный");
                    score--;
                }
            }

            Console.WriteLine();


        }
    }
}
