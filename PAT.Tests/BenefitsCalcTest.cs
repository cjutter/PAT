using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PAT.Tests
{
    [TestClass]
    public class BenefitsCalcTest
    {
        [TestMethod]
        public void CalculateCosts()
        {
            var benefitsCalc = IocContainer.BenefitsCalculator;
        }
    }

    public class BenefitsCalculator : IPayrollCalculator
    { 
        public ICalculationResult Calculate(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPayrollCalculator
    {
        ICalculationResult Calculate(IEmployee employee);
    }

    public interface ICalculationResult
    {
        
    }

    public static class IocContainer
    {
        private static IPayrollCalculator _calc;

        public static IPayrollCalculator GetBenefitsCalculator(IEmployee employee)
        {
            if (_calc != null) return _calc;
            _calc = new BenefitsCalculator();
            return _calc;
        }
    }
}

    public interface IEmployee
    {
        
    }
}
