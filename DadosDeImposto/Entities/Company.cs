using System;
using System.Collections.Generic;
using System.Text;

namespace DadosDeImposto.Entities
{
    class Company: Peoples
    {
        public int Employee { get; set; }

        public Company(string name, double annualMoney, int employee ) : base (name, annualMoney)
        {
            Employee = employee;
        }

        public override double Tax()
        {
            if (Employee > 10)
                return (AnnualMoney * 0.14);
            else
                return (AnnualMoney * 0.16);
        }
    }
}
