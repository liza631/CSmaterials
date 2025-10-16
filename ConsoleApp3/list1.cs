using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class list1
    {
        static void Main134(string[] args)
        {
            List<string> adjectives = new List<string>() {"Big", "Крутой", "Легендарный", "Глупый", "Маленький", "Большой"};
            List<string> nouns = new List<string>() { "Головач", "Арбуз", "Человек", "Динамит" };
            List<string> numbers = new List<string>() { "52", "42", "102", "77" };

            Console.WriteLine("Хотите ли добавить элементы в список с прилагательными");
            string answer = Console.ReadLine();
            if (answer.ToLower().Trim() == "да")
            {
                Console.WriteLine("Введите желаемые прилагательные через <,>:");
                string[] adjsFromUser = Console.ReadLine().Split(',');
                foreach (string s in adjsFromUser)
                {
                    adjectives.Add(s.Trim());
                }
                Console.WriteLine($"{adjsFromUser.Length} элементов были добавлены");
            }
            Console.WriteLine("Все прилагательнные: ");
            Console.WriteLine(String.Join(", ", adjectives));

            Console.WriteLine();

            Console.WriteLine("Хотите ли удалить элементы из списка с прилагательными?");
            answer = Console.ReadLine();
            if (answer.ToLower().Trim() == "да")
            {
                Console.WriteLine("Какой элемент хочешь удалить? Введите значение: ");
                string elForDelete = Console.ReadLine();
                if (adjectives.Contains(elForDelete))
                {
                    adjectives.Remove(elForDelete);
                   Console.WriteLine("Удалено!");
                }
                
            }

            Console.WriteLine("Хотите ли добавить элементы в список с существительными");
            string answer1 = Console.ReadLine();
            if (answer1.ToLower().Trim() == "да")
            {
                Console.WriteLine("Введите желаемые существительные через <,>:");
                string[] nounsFromUser = Console.ReadLine().Split(',');
                foreach (string s in nounsFromUser)
                {
                    nouns.Add(s.Trim());
                }
                Console.WriteLine($"{nounsFromUser.Length} элементов были добавлены");
            }
            Console.WriteLine("Все существительные: ");
            Console.WriteLine(String.Join(", ", nouns));

            Console.WriteLine();

            Console.WriteLine("Хотите ли удалить элементы из списка с существительными?");
            answer = Console.ReadLine();
            if (answer.ToLower().Trim() == "да")
            {
                Console.WriteLine("Какой элемент хочешь удалить? Введите значение: ");
                string elForDelete = Console.ReadLine();
                if (nouns.Contains(elForDelete))
                {
                    nouns.Remove(elForDelete);
                    Console.WriteLine("Удалено!");
                }

            }

            Console.WriteLine("Хотите ли добавить элементы в список с числами");
            string answer2 = Console.ReadLine();
            if (answer2.ToLower().Trim() == "да")
            {
                Console.WriteLine("Введите желаемые числа через <,>:");
                string[] numbersFromUser = Console.ReadLine().Split(',');
                foreach (string s in numbersFromUser)
                {
                    numbers.Add(s.Trim());
                }
                Console.WriteLine($"{numbersFromUser.Length} элементов были добавлены");
            }
            Console.WriteLine("Все числа: ");
            Console.WriteLine(String.Join(", ", numbers));

            Console.WriteLine();

            Console.WriteLine("Хотите ли удалить элементы из списка с числами?");
            answer = Console.ReadLine();
            if (numbers.ToString().Trim() == "да")
            {
                Console.WriteLine("Какой элемент хочешь удалить? Введите значение: ");
                string elForDelete = Console.ReadLine();
                if (numbers.Contains(elForDelete))
                {
                    numbers.Remove(elForDelete);
                    Console.WriteLine("Удалено!");
                }

            }

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                string adj = adjectives[random.Next(0, adjectives.Count)];
                string noun = nouns[random.Next(0, nouns.Count)];
                string number = numbers[random.Next(0, numbers.Count)];

                Console.WriteLine($"{adj}{noun}{number}");
            }
        }
    }
}
