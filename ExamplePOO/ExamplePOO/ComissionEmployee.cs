using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePOO
{
    public class ComissionEmployee : Employee
    {
        public float ComissionPercentage { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales*(decimal)ComissionPercentage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tComission percentage: {$"{ComissionPercentage:p2}",18} " +
                $"\n\tSales...............: {$"{Sales:c2}",18} " +
                $"\n\tValue to pay........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
