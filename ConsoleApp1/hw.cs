using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class hw
    {
        static void Main5(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1 || a == 2 || a == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (a == 3 || a == 4 || a == 5)
            {
                Console.WriteLine("Spring");
            }
            else if (a == 6 || a == 7 || a == 8)
            {
                Console.WriteLine("Summer");
            }
            else if (a > 12 || a < 1)
            {
                Console.WriteLine("Ввели неправильное число");
            }
            else
            {
                Console.WriteLine("Autumn");
            }
        }
    }
}
