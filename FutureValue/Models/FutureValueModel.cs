using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Models
{
    public class FutureValueModel  // a model can not have the same name as the namespace
    {
        // properties
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInvestmentRate { get; set; }
        public int Years { get; set; }

        // method to calculate the future value of the investment input
        public decimal CalculateFutureValue()
        {
            decimal futureValue = 0m;
            int months = Years * 12;
            decimal monthlyInterestRate = (YearlyInvestmentRate / 12) / 100;
            
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

    }
}
