using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace DadosDeImposto.Entities
{
    abstract class Peoples
    {
        public string Name { get; set; }
        public double AnnualMoney { get; set; }

        public Peoples()
        {
        }

        public Peoples(string name, double annualMoney)
        {
            Name = name;
            AnnualMoney = annualMoney;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"Tax Paid:\n {Name}: ${Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
