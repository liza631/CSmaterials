using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class методы1
    {
        /*static void OddNumber(int number1, int number2)
        {
            for (int i = number1; i < number2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            OddNumber(10, 20);
        }*/
        /*static void DrawLine(int l, int d, char c)
        {
            for (int i = 0; i < l; i++)
            {
                if (d == 0)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.Write(c);
                }
            }

        }

        static void Main(string[] args)
        {
            DrawLine(5, 1, '*');
        }*/
        /*static int maxNumbers(int[] numbers)
        {
            List<int> result = new List<int>(numbers);
            return list.Max();
        }
        static void Main(string[] args)
        {
            int[] numbers = maxNumbers(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(max);
        }*/
        /*static int MaxMinNumbers(int min, int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxMinNumbers(10, 15));
        }*/
        /*static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPrime(11));
        }*/
        /*static void Main(string[] args)
        {
            string a =Console.ReadLine();
            if (ChechHappy(a))
            {
                Console.WriteLine("Счастливое");
            }
            else
            {
                Console.WriteLine("Несчастливые");
            }
        }
        static bool ChechHappy(string a)
        {
            int[] nums1 = new int[3];
            int[] nums2 = new int[3];
            int[] sum1 = 0;
            int[] sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                nums1[i] = Convert.ToInt32(a[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                nums1[i] = Convert.ToInt32(a[i+2]);
            }
            foreach (int i in nums1)
            {
                sum1[i] += nums2[i];
            }
            foreach (int i in nums2)
            {
                sum2[i] += nums1[i];
            }

        }*/
        //ДЗ
        static void Main(string[] args)
        {
            Console.WriteLine("=== Игра камень, ножницы, бумага ===\n" +
                "Выберете чем сделать ход: \n" +
                "1. камень\n" +
                "2. ножницы\n" +
                "3. бумага");
            int choce = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int d = random.Next(1, 3);

            switch (choce)
            {
                case 1:
                    Console.WriteLine(random);
                    //if (random.Next(2) == 0)
                    //{
                        
                    //}
                    break;
            }
        }


    }
}
