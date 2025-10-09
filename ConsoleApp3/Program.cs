using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Mainhkjh(string[] args)
        {
            string[] inventory = new string[10];

            while (true)
            {
                Console.WriteLine("Меню\n" +
                    "1. Отобразить весь инвентарь.\n" +
                    "2. Добавить элемент в инвентарь.\n" +
                    "3. Удалить элемент из инвентаря.\n" +
                    "4. Найти элемент в инвентаре.");
                Console.WriteLine("Введите номер команды:");

                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 0:
                        Console.WriteLine("Весь инвентарь: ");
                        foreach (string item in inventory)
                        {
                            
                            Console.WriteLine(item);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Добавление в инвентарь");
                        Console.WriteLine("Что хотели бы добавить: ");
                        string newElemebt = Console.ReadLine();

                        Console.WriteLine("Под какой номер: ");
                        int index = Convert.ToInt32(Console.ReadLine());

                        if (index <= 10)
                        {
                            inventory[index] = newElemebt;
                            Console.WriteLine("Элемент добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Не верный индекс.");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Удаление элемента.");
                            Console.WriteLine("Что хотели бы удалить: ");
                            string deleteElemebt = Console.ReadLine();


                            for (int i = 0; i <= inventory.Length; i++)
                            {
                                if (inventory[i] == deleteElemebt)
                                {
                                    Console.WriteLine("Объект удалён!");
                                    inventory[i] = "";
                                    break;
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Поиск объекта");
                            Console.WriteLine("Что хотели бы найти: ");
                            string searchElement = Console.ReadLine();

                            bool isElement = false;

                            for (int i = 0; i <= inventory.Length; i++)
                            {
                                if (inventory[i] == searchElement)
                                {
                                    isElement = true;
                                    break;
                                }


                            }
                            if (isElement)
                            {
                                Console.WriteLine("Элемент найден");
                            }
                            else
                            {
                                Console.WriteLine("Элемент не найден");
                            }
                            break;
                        }
                    default:
                            Console.WriteLine("Не верная команда");
                            break;
                        }
                    }
                } 
            }
        }

