using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FileName2
    {
        static void Mainфвц(string[] args)
        {
            string login = "admin";
            string password = "1234";
            Console.Write("Введите логин:");
            string userLogin=Console.ReadLine();

            Console.Write("Введите пароль:");
            string userPassword=Console.ReadLine();

            if (userLogin == login && userPassword == password)
            { 
                Console.WriteLine("Добро пожаловать!");
            }
        }
    }
}
