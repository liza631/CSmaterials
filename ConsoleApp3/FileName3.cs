using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FileName3
    {
        static void Mainпо(string[] args)
        {
            List<int> ints = new List<int>() { 1, 2, 3};
            List<string> list = new List<string>();

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(ints[0]);

            ints[0] = 50;
            Console.WriteLine(ints[0]);

            for (int i = 0; i < ints.Count - 1; i++)
            {
                Console.WriteLine(ints[i]);
            }

            List<string> shoppingList = new List<string>();
            shoppingList.Add("Молоко");
            shoppingList.Add("Хлеб");
            shoppingList.Insert(1, "Масло");
            shoppingList.Add("Хлеб");
            foreach (string s in shoppingList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            shoppingList.Remove("Хлеб"); //удалить по первому значечию
            shoppingList.RemoveAt(1); //
            foreach (string s in shoppingList)
            {
                Console.WriteLine(s);
            }

            bool hasMilk = shoppingList.Contains("Молоко"); //содержится ли?
            Console.WriteLine(hasMilk);

            int butterIndex = shoppingList.IndexOf("Масло"); //индекс первого вхождения
            Console.WriteLine( butterIndex);
        }
    }
}
