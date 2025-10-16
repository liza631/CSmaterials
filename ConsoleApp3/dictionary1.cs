using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class dictionary1
    {
        static void Mainцу(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            //добавление
            people["Vlad"] = 268376399;
            people.Add("Dima", 51368812);

            //вывод
            foreach (var item in people)
            {
                Console.WriteLine($"ключ - {item.Key}; значение - {item.Value}");
            }

            //удаление
            people.Remove("Vlad");

            Console.WriteLine($"Dima есть в словаре {people.ContainsKey("Dima")}");

            //поиск(int findNumber)
            int findNumber;
            if (people.TryGetValue("Dima", out findNumber))
            {
                Console.WriteLine(findNumber);
            }

            //количество пар ключей
            Console.WriteLine(people.Count());

        }
    }
}
