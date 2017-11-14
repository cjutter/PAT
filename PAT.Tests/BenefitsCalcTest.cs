using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAT.Calculators;
using PAT.Entities;


namespace PAT.Tests
{
    //Wanted to get a verticle slice of app up and running.
    //Depending on task may be more TDD

    [TestClass]
    public class BenefitsCalcTest
    {
        [TestMethod]
        public void CalculateSingleEmployeeCost()
        {
          var calc = new BenefitsCalculator();
            var employee = new Employee
            {
                BiWeeklyWage = 2000M,
                Dependents = new List<Dependent>(),
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            var result = calc.CalculateEmployeeGrossPayAfterBenefitsDeduction(employee);
            Assert.AreEqual(51000, result.Result);
        }

        [TestMethod]
        public void CalculateSingleEmployeeCostNameStartsWithA()
        {
            var calc = new BenefitsCalculator();
            var employee = new Employee
            {
                BiWeeklyWage = 2000M,
                Dependents = new List<Dependent>(),
                EmployeeId = 1,
                FirstName = "AAron",
                LastName = "Doe"
            };
            var result = calc.CalculateEmployeeGrossPayAfterBenefitsDeduction(employee);
            Assert.AreEqual(50900, result.Result);
        }

        //Not implemeted yet
        [TestMethod, Ignore]
        public void CalculateMarriedEmployees(){}

        [TestMethod, Ignore]
        public void CalculateDependents() { }


    }
}
