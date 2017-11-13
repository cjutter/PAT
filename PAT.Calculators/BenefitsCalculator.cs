using System;
using PAT.Abstractions;
using PAT.Models;

using PAT.Tests.IocMock;

namespace PAT.Calculators
{
    public class BenefitsCalculator : IPayrollCalculator
    { 
        public ICalculationResult CalculateEmployeeGrossPayAfterBenefitsDeduction(IEmployee employee)
        {
           // var payroll = IocContainerMock.GetPayroll();
         //   var payroll = new Payroll();
         //   var grossPay = payroll.GetEmployeeGrossPay(employee);
            throw new NotImplementedException();
        }
    }
}