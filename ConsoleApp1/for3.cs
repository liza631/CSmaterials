using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class for3
    {
        static void Main(string[] args)
        {
           // int width = Convert.ToInt32(Console.Read());
            int heigh = Convert.ToInt32(Console.Read());

            for (int i = 0; i < heigh; i++)
            {
                for (int j = 0; j < heigh; j++)
                {
                    if (i > 0 && i < heigh - 1 && j > 0 && j < heigh - 1)
                    {
                        
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                     }
                }
                Console.WriteLine();
            }   
            }
            
        }
    }

