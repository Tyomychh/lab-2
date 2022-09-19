using System;
using System.Collections.Generic;
using System.Text;

namespace Adress
{
    internal class Adress
    {
        private int _index;
        public int index
        {
            get => _index;
            set
            {
                if ((value > 00000) && (value < 99999))
                {
                    _index = value;
                }
            }

        }
        private string _country;
        public string country
        {
            get => _country;
            set => _country = value;
        }
        private string _city;
        public string city
        {
            get => _city;
            set => _city = value;
        }
        private string _street;
        public string street
        {
            get => _street;
            set => _street = value;
        }
        private string _house;
        public string house
        {
            get => _house;
            set => _house = value;
        }
        private string _apartamens;
        public string apartamens
        {
            get => _apartamens;
            set => _apartamens = value;
        }
        public void Print() => Console.WriteLine($"{index} - {country} - {city} - {street} - {house} - {apartamens}");
    }
}

