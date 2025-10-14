using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class string1
    {
        static void Mainsfd(string[] args)
        {
            //1
            /*
            string[,] users = new string[10, 2];

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string secondname = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            string fullName = string.Concat(name, secondname); //объединить
            fullName = fullName.Replace(" ", ""); //заменить
            fullName = fullName.ToLower(); // преобразовать в нижний регистр
            Console.WriteLine(fullName);

            if (password.Contains(" ")) // есть ли элемент в строке
            {
                Console.WriteLine("Пароль не должен содержать пробел");
            }
            else
            {
                users[0,0] = fullName;
                users[0,1] = password;
                Console.WriteLine("Пользователь добавлен");
            }

            foreach (string data in users) { Console.WriteLine(data); }
            */

            //2
            string[,] users = new string[2, 2] { { "вандех", "1234" }, { "ивандай", "4545" } };
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string secondname = Console.ReadLine();

            string fullname =string.Concat(name, secondname).ToLower().Replace(" ", "");

            bool isUsers = true; 
            foreach (string user in users)
            {
                if (user == fullname)
                {
                    isUsers = true;
                    break;
                }
            }
            if (isUsers)
            {
                Console.WriteLine("Пользователь найден");
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                for (int i = 0; i < users.Length / 2; i++)
                {
                    if (users[i, 0] == fullname && users[i, 1] == password)
                    {
                        Console.WriteLine("Пользователь удалён");
                        users[i, 0] = string.Empty;
                        users[i, 1] = string.Empty;
                    }
                }
            }
            else
            {
                Console.WriteLine("Полбзователь не найден");
            }
            foreach (string data in users)
            {
                Console.WriteLine(data);
            }
            

            


        }
    }
}
