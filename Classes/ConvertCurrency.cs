using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicConsoleApp.Classes
{
    public class ConvertCurrency
    {
        public int Value { get; set; }
        public int MoneyRate { get; set; }

        public ConvertCurrency(int value, int moneyRate)
        {
            Value = value;
            MoneyRate = moneyRate;
        }

        public void ConvertToSom()
        {
            Console.WriteLine(Value * MoneyRate);
        }

        public void ConvertToAnotherCurrency()
        {
            Console.WriteLine(Value / MoneyRate);
        }
    }
}