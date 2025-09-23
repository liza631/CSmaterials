using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main2(string[] args)
        {

            string name = "салат";
            string ingridients = "1. помидоры 2шт \n " +
                "2. огурцы 2шт \n " +
                "3. растительное масло \n " +
                "4. соль \n " +
                "5. репчатый лук 0,5шт";
            int prise = 350;

            Console.WriteLine("НАЗВАНИЕ \n" + name + "\n");
            Console.WriteLine($"ИНГРЕДИЕНТЫ\n {ingridients} \n\nЦЕНА:{prise}");
        }
    }
}
