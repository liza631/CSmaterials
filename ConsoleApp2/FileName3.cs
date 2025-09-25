using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileName3
    {
        static void Main(string[] args)
        {
            string password = "1234";
            string login = "login";
            string userLogin;

            int attemptCount = 3;
            int  attempts = 0;

            while (true)
            {
                Console.Write("Введите логин:");
                userLogin = Console.ReadLine();

                Console.Write("Введите пароль:");
                userPassword = Console.ReadLine();

                if (userLogin == login && userPassword == password)
                {
                    Console.WriteLine("Добро пожаловать");
                    break;
                }
                else if (userLogin == login)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
