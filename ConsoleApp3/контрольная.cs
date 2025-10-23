using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class контрольная
    {
        static void Mainвы(string[] args)
        {
            /*Dictionary<string, int> shopItems = new Dictionary<string, int>()
            {
                {"Бинты", 50},
                {"Зелья", 75},
                {"Хороший  меч", 200},
                {"Сапоги", 150},
            };
            foreach (var item in shopItems)
            {
                Console.WriteLine($"товар: {item.Key}; цена: {item.Value} золотых");
            }*/

            Dictionary<string, string> locations = new Dictionary<string, string>()
            {
                {"Колодец", "Старый колодец, находящийся на краю деревни"},
                {"Церковь", "Местные жители каждое уро собираются здесь на утреннюю молитву"},
                {"Рынок", "Самое многолюдное место в горое"}
            };
            Console.WriteLine("Введите название локации: ");
            string findLocations = Console.ReadLine();
            if (locations.TryGetValue(findLocations, out findLocations))
            {
                Console.WriteLine();
            }
        }
    }
}
