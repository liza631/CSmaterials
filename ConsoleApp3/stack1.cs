using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class stack1
    {
        static void Mainqw(string[] args)
        {
            List<string> list = new List<string>() {"Вова", "Саша", "Арсений"};
            Stack<string> names = new Stack<string>();
            //добавить элемент
            names.Push("Вася");
            //взять с удалением
            string popName = names.Pop();
            Console.WriteLine($"взятый элемент {popName}");

            //взять без удаления
            string peekName = names.Peek();
            Console.WriteLine($"взятый элемент {peekName}");

            //вывести элемент
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
