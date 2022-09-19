using System;

namespace Converter
{
    internal class Program
    {
            static void Main(string[] args)
            {
                var converters = new Converter(40.700, 40.300, 0.60);

                Console.WriteLine("Choose option:");
                Console.WriteLine("1: Convert to hryvnia");
                Console.WriteLine("2: Convert from hryvnia");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        ConvertTo(converters);
                        break;
                    case 2:
                        ConvertFrom(converters);
                        break;
                }

                Console.WriteLine("Done");
                Console.ReadKey();
            }

            private static void ConvertTo(Converter currencyConverter)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1: Convert from USD");
                Console.WriteLine("2: Convert from EUR");
                Console.WriteLine("3: Convert from RUB");

                var option = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter amount");

                var input = double.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                        break;
                    case 2:
                        Console.WriteLine(currencyConverter.ConvertFromEur(input));
                        break;
                    case 3:
                        Console.WriteLine(currencyConverter.ConvertFromRub(input));
                        break;
                }
            }

            private static void ConvertFrom(Converter currencyConverter)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1: Convert to USD");
                Console.WriteLine("2: Convert to EUR");
                Console.WriteLine("3: Convert to RUB");

                var option = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter amount");

                var input = double.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(currencyConverter.ConvertToUsd(input));
                        break;
                    case 2:
                        Console.WriteLine(currencyConverter.ConvertToEur(input));
                        break;
                    case 3:
                        Console.WriteLine(currencyConverter.ConvertToRub(input));
                        break;
                }
            }
        }
    }

