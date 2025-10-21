using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class dictionary3
    {
        static void Mainsf(string[] args)
        {
            Dictionary<string, bool> questProgress = new Dictionary<string, bool>()
            {
                {"Сделать дз", false },
                {"Собрать монетки", false},
            };

            while (true)
            {
                //отображение словаря
                foreach (var quest in questProgress)
                {
                    Console.Write($"{quest.Key} статус:");
                    if (quest.Value)
                    {
                        Console.WriteLine("Выполнено");
                    }
                    else
                    {
                        Console.WriteLine("Не выполнено");
                    }
                }
                Console.WriteLine("Напишите квкст для выполнения:");
                string userQuest = Console.ReadLine();

                if (questProgress.ContainsKey(userQuest))
                {
                    questProgress[userQuest] = true;
                    Console.WriteLine($"Квест {userQuest} выполнен!");
                }
                else
                {
                    Console.WriteLine($"Квест {userQuest} не найден.");
                }
            }

        }
    }
}
