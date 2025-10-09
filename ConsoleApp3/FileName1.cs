using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FileName1
    {
        static void Mainцйу(string[] args)
        {
            int[] originalArray = new int[5] { 10, 20, 30, 40, 50 };
            int[] reversedArray = new int[5];

            int n = originalArray.Length - 1;

            for (int i = 0; i <= n; i++)
            {
                reversedArray[n - i] = originalArray[i];
            }
            foreach (int i in reversedArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
