using System;
using System.Collections.Generic;
using System.Text;

namespace AnalisadorDeContribuicaoDeImpostos.Entities
{
    class Person
    {
        public string Name { get; set; }
        public double AnullIncome { get; set; }
        public double Tax { get; set; }

        public Person(string name, double anullIncome, double tax)
        {
            Name = name;
            AnullIncome = anullIncome;
            Tax = tax;
        }
        public Person()
        {
        }

        public virtual double TaxCalculete()
        {            
            return 0;
        }
    }
}
