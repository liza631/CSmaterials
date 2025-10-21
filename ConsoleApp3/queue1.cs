using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class queue1
    {static void Mainad(string[] args)
        {
            Queue<string> people = new Queue<string>();

            //добавление
            people.Enqueue("Дима");
            people.Enqueue("Влад");

            //размер очереди
            Console.WriteLine(people.Count());
            //people[0]; ошибка!индексации не существует!

            //взять и удалить элемент из очереди
            string name = people.Dequeue();
            Console.WriteLine($"взят {name}");

            //взять, но не удалить элемент из очереди
            string peekName = people.Peek();
            Console.WriteLine($"взят {peekName}");

            //перебор элементов
            foreach (string item in people)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(people.Count);
        }
    }
}
