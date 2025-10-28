using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class method1
    {
        static void DisplayMenu()
        {
            Console.WriteLine("---Меню---");
            Console.WriteLine("1. Добавить элемент в инвентарь\n" +
                "2. Удалить элемент из инвентаря.\n" +
                "3. Найти элемент в инвентаре." +
                "4. Отобразить инвентарь.");
        }
        static void DisplayInventory(List<string> inventory)
        {
           for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        } 
        static void AddElement(List<string> inventory)
        {
            Console.WriteLine("Введите новый предмет: ");
            string newItem = Console.ReadLine();
            inventory.Add(newItem);
        }
        static int FindElement(List<string> inventory)
        {
            Console.WriteLine("Введите предмет, который нужно найти: ");
            string searchElement = Console.ReadLine();
            if (inventory.Contains(searchElement))
            {
                Console.WriteLine("Элемент есть в списке");
                return inventory.IndexOf(searchElement);
            }
            else
            {
                Console.WriteLine("Данного элемента в списке нет");
                return -1;
            }
        }

        static void Mainке(string[] args)
        {
            List<String> list = new List<string>() {"Топор", "Меч"};
            DisplayInventory(list);
            AddElement(list);
            DisplayInventory(list);
            Console.WriteLine(FindElement(list));

        }
    }
}
