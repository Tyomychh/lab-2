using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    internal class User
    {
        public string Login { get; set; }

        public string Firstname { get; set; }

        public string Secondname { get; set; }

        public int Age { get; set; }

        public string Date_of_completion { get; set; }
        public void worksheet()
        {
            Console.WriteLine("Создать новый рабочий лист");
            Console.WriteLine("Напишите ваш логин");
            Login = Console.ReadLine();
            Console.WriteLine("Напишите ваше имя");
            Firstname = Console.ReadLine();
            Console.WriteLine("Напишите вашу фамилию");
            Secondname = Console.ReadLine();
            Console.Write("Напишите ваш возраст");
            Age = Convert.ToInt32(Console.ReadLine());
            Date_of_completion = DateTime.Now.ToString();
            Console.WriteLine($"Ваш логин {Login} имя фамилия {Firstname} {Secondname}и ваш возраст {Age}. Сегодня {Date_of_completion} ");
        }
    }
}
