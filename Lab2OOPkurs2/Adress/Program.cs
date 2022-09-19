using System;

namespace Adress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adress p = new Adress();
            p.index = 11001;
            p.country = "Canada";
            p.city = "Leduc";
            p.street = "Avena Circle";
            p.house = "1";
            p.apartamens = "House";
            p.Print();
        }
    }
}
