using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PAT.Tests
{
    [TestClass]
    public class BenefitsCalcTest
    {
        [TestMethod]
        public void CalculateCosts()
        {
            var benefitsCalc = IocContainerMock.GetBenefitsCalculator();
            var employee = IocContainerMock.GetEmployee(0);
            var result = benefitsCalc.CalculateEmployeeGrossPayAfterBenefitsDeduction(employee);
        }
    }

    public class BenefitsCalculator : IPayrollCalculator
    { 
        public ICalculationResult CalculateEmployeeGrossPayAfterBenefitsDeduction(IEmployee employee)
        {
            var payroll = IocContainerMock.GetPayroll();
            var grossPay = payroll.GetEmployeeGrossPay(employee);
            throw new NotImplementedException();
        }
    }


    public interface IPayrollCalculator
    {
        /// <summary>
        /// Calculate employee yearly pay after cost of benefits and before addtional deductions. 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        ICalculationResult CalculateEmployeeGrossPayAfterBenefitsDeduction(IEmployee employee);

    }

    public interface ICalculationResult
    {
        decimal EmployeeYearlyGrossPay { get; set; }
        decimal EmployeeBiWeeklyPay { get; set; }
        decimal EmployeeGrossPayAfterBenefitsDeduction { get; set; }
    }
    
    public interface IEmployee
    {
        int EmpId { get; set; }
        IPerson Employee { get; set; }
        List<IPerson> Dependants { get; set; }
        IPerson Spouse { get; set; }
        bool HasSpouse { get; set; }
        bool HasDependants { get; set; }
    }


    public class Employee : IEmployee, IPerson
    {
        private int _empId;

        public Employee(int empId)
        {
            _empId = empId;
        }

        public List<IPerson> Dependants
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasDependants
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasSpouse
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string LastName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IPerson Spouse
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int EmpId { get; set; }

        IPerson IEmployee.Employee
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    public interface IPayroll
    {
        decimal GetEmployeeGrossPay(IEmployee employee);
    }

    public class Payroll : IPayroll
    {
        public decimal GetEmployeeGrossPay(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }

    public static class IocContainerMock
    {
        public static IPayrollCalculator GetBenefitsCalculator()
        {
            return new BenefitsCalculator();
        }

        public static IEmployee GetEmployee(int empId)
        {
            return new Employee(empId);
        }

        public static IPayroll GetPayroll()
        {
            return new Payroll();
        }
    }

}
