using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FileName
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("Введите количество секунд");

            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.минуты, 2.часы, 3.секунды");

            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 3)
            {
                int secondsInDay = 60 * 60 * 24;
                Console.WriteLine(secondsInDay - seconds);

            }
            else if (option == 2)
            {
                int hoursInDay = 24;
                int hours = seconds / 60 / 60;
                Console.WriteLine(hoursInDay - hours);
            }
        }
    }
}
