using System;
using System.Collections.Generic;
using System.Text;

namespace DadosDeImposto.Entities
{
    class IndividualPerson: Peoples
    {
        public double Health;

        public IndividualPerson(string name, double annualMoney, double health) : base (name,annualMoney)
        {
            Health = health;
        }

        public override double Tax()
        {
            if (AnnualMoney < 20000)
                return (AnnualMoney * 0.15) - (Health * 0.50);

            else
                return (AnnualMoney * 0.25) - (Health * 0.50);
        }
    }
}
