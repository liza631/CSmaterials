using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class гншщн
    {
        static void Mainаы(string[] args)
        {
            /*List<string> items = new List<string>() {"топор", "шлем"};

            while (true)
            {
                Console.Write("Меню\n" +
                    "1. Добавить предмет\n" +
                    "2. Удалить предмет\n" +
                    "3. Найти предмет\n" +
                    "4. Отобразить инвентарь\n" +
                    "Выберете пункт меню: ");
                int command = Convert.ToInt32(Console.ReadLine());

                if (command == 1)
                {
                    Console.WriteLine("Введите название предмета: ");
                    items.Add(Console.ReadLine());
                }
                else if (command == 2)
                {
                    Console.WriteLine("Введите название предмета: ");
                    string name = Console.ReadLine();
                    if (items.Contains(name))
                    {
                        items.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine("Данного предмета нет. ");
                    }
                }
                else if (command == 3)
                {
                    Console.WriteLine("Введите название предмета: ");
                    if (items.Contains(Console.ReadLine()))
                    {
                        Console.WriteLine("Предмет в инвентаре есть.");
                    }
                    else
                    {
                        Console.WriteLine("Данного предмета нет в инвентаре. ");
                    }
                }
                else if (command == 4)
                {
                    foreach (string item in items)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Такого пункта нет.");
                }
            }*/

            /*Dictionary<string, int> spells = new Dictionary<string, int>()
            {
                {"авадакидавра", 30},
                {"вергандикм левиоса", 0},
                {"удар палкой", 10}
            };
            foreach (var spell in spells)
            {
                Console.WriteLine($"заклинание: {spell.Key}, урон: {spell.Value}");
            }*/

            /*Dictionary<int, string> dialogues = new Dictionary<int, string>()
            {
                {1,"Ты уже выполнил новый ивент?"},
                {2, "Да, только сегодня закончил."},
                {3, "И как тебе?"},
                {4, "Супер! Сюжет интересный и локации красивые!"}
            };
            foreach (var dialogue in dialogues)
            {
                Console.WriteLine($"{dialogue.Key}) {dialogue.Value}");
            }*/

            Queue<string> message = new Queue<string>();
        }
    }
}
