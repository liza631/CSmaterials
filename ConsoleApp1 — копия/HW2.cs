using System;

namespace BMICalculator
{
    class HW2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nЧисла от {num} до 1:");
            for (int i = num; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}