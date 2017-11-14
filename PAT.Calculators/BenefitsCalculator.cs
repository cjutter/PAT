using System;
using System.Linq;
using PAT.Abstractions;
using PAT.Entities;


namespace PAT.Calculators
{
    public class BenefitsCalculator 
    { 
        public ICalculationResult CalculateEmployeeGrossPayAfterBenefitsDeduction(Employee emp)
        {
            var result = new BenefitsCalcResult();
            var cost = 2000M + emp.Dependants.Sum(dependent => 500M);
            result.Result = (emp.BiWeeklyWage * 26) - cost;
            return result;
        }
    }

    public class BenefitsCalcResult : ICalculationResult
    {
        public decimal Result { get; set; }
    }
}