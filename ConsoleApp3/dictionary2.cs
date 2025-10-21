using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class dictionary2
    {
        static void Mainert(string[] args)
        {
            Dictionary<string, int> shopItems = new Dictionary<string, int>()
            {
                {"Health Potion", 50},
                {"Mana Potion", 75},
                {"Sword Potion", 200},
                {"Shield", 150},
            };

            foreach (var item in shopItems)
            {
                Console.WriteLine($"название: {item.Key}, цена: {item.Value}");
            }

            Console.WriteLine("Введите название товара: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену товара: ");
            int price = Convert.ToInt32(Console.ReadLine());

            shopItems.Add(name, price);

        }
    }
}
