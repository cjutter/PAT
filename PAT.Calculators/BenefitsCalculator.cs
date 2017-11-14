using System;
using System.Linq;
using PAT.Abstractions;
using PAT.Entities;


namespace PAT.Calculators
{
    public class BenefitsCalculator 
    { 
        //Todo refactor out inputs to calc
        public ICalculationResult CalculateEmployeeGrossPayAfterBenefitsDeduction(Employee emp)
        {
            var discount = 0.10M;
            var empBaseCost = 1000M;
            var dependentBaseCost = 500M;

            var result = new BenefitsCalcResult();
           // var cost = 1000M + emp.Dependents.Sum(dependent => 500M);
            var cost = emp.FirstName.StartsWith("A") ? (empBaseCost * discount) + empBaseCost : empBaseCost;
            foreach (var dependent in emp.Dependents)
            {
                cost += dependent.FirstName.StartsWith("A") ? (dependentBaseCost * discount) + dependentBaseCost : dependentBaseCost;
            }
            result.Result = (emp.BiWeeklyWage * 26) - cost;
            return result;
        }
    }

    public class BenefitsCalcResult : ICalculationResult
    {
        public decimal Result { get; set; }
    }
}