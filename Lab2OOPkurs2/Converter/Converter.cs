using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    internal class Converter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }
    }
}
