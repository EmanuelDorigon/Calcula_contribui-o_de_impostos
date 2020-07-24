using System;
using System.Collections.Generic;
using System.Text;

namespace AnalisadorDeContribuicaoDeImpostos.Entities
{
    class LegalPerson : Person
    {
        public double HealthSpend { get; set; }

        public LegalPerson(string name, double anullIncome, double healthSpend, double tax) : base(name, anullIncome, tax)
        {
            HealthSpend = healthSpend;            
        }
    }
}
