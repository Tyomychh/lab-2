using System;
using System.Collections.Generic;
using System.Text;

namespace Emploee
{
    internal class Emploee
    {
        private readonly string name;
        private readonly string secondname;

        internal Emploee(string name, string secondname)
        {
            this.name = name;
            this.secondname = secondname;
        }

        public void salary()
        {
            int position, experience;
            double salary, tax;
            Console.WriteLine("У нас есть три вакансии");
            Console.WriteLine("junior programmer -- 1");
            Console.WriteLine("junior graphic designer -- 2");
            Console.WriteLine("senior programmer -- 3");
            Console.WriteLine("выберете ту на которую претендуете");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Есть ли у вас опыт работы? Выберете как вы его оуениваете по шкале от одного до 3");
            Console.WriteLine("У меня нет опыта я новичёк -- 1");
            Console.WriteLine("Нуууу, немного работал в этой сфере -- 2");
            Console.WriteLine("Я супер опытный и крутой -- 3");
            experience = Convert.ToInt32(Console.ReadLine());
            if (position == 1 && experience <= 3)
            {
                Console.WriteLine("Вы junior programmer");
                salary = ((50002.05 + 78950.61) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Ваша зарплата: {salary}");
                Console.WriteLine($"Ваш налог: {tax}");
            }
            if (position == 2 && experience <= 3)
            {
                Console.WriteLine("Вы junior graphic designer");
                salary = ((53000 + 23000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Ваша зарплата: {salary}");
                Console.WriteLine($"Ваш налог: {tax}");
            }
            if (position == 3 && experience >= 10)
            {
                Console.WriteLine("Вы senior programmer");
                salary = ((52633.74 + 82503.39) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Ваша зарплата: {salary}");
                Console.WriteLine($"Ваш налог: {tax}");
            }

            Console.WriteLine($"You {name} {secondname} and your posiotion {position}.");

        }

    }
}
