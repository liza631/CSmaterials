using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FileName
    {
        static void Mainarray2(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите {i + 1} числo: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Элементы массива");
            int sum = 0;
            int maxNumber = numbers[0];
            int minNumber = numbers[0];

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine($"Сумма всех элементов {sum}");
            Console.WriteLine($"Среднее арифметическое {sum / numbers.Length}");
            Console.WriteLine($"Максимальное число {maxNumber}\n" +
                $"Минимально число {minNumber}");

        }
    }
}
