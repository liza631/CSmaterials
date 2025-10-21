using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class set1
    {
        static void Mainшг(string[] args)
        {
            HashSet<int> numbers1 = new HashSet<int>() {1, 2, 3, 4, 5, 5};
            HashSet<int> numbers2 = new HashSet<int>() { 5, 6, 7, 8, 9, 9 };

            numbers1.Add(6);//добавить (если дубликат, то не добавиться)

            Console.WriteLine(numbers1.Count); //кол-во элементов

            numbers1.Remove(1); //удалить элемент

            Console.WriteLine(numbers2.ToArray()[0]); //индекстирование возможно только при приобразовании в множество

            //вывод
            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }

            //объединение
            numbers1.UnionWith(numbers2);
            foreach (int i in numbers1)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            numbers1 = new HashSet<int>() { 1, 2, 3, 4, 5, 5 };
            //пересечение
            numbers1.IntersectWith(numbers2);
            foreach (int i in numbers1)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            numbers1 = new HashSet<int>() { 1, 2, 3, 4, 5, 5 };
            //разность
            numbers1.ExceptWith(numbers2);
            foreach (int i in numbers1)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
