using System;
using System.Collections.Generic;
using System.Text;
using AnalisadorDeContribuicaoDeImpostos.Entities;
using System.Globalization;

namespace AnalisadorDeContribuicaoDeImpostos.Entities

{
    class Individual : Person
    {
        public int EmployeeNumber { get; set; }

        public Individual(string name, double anullIncome, int employeeNumber) : base(name, anullIncome, tax)
        {
            EmployeeNumber = employeeNumber;          
        }
        public Individual()
        { 
        }
        public override double TaxCalculete()
        {            
            return AnullIncome * Tax;
        }
    }
}
