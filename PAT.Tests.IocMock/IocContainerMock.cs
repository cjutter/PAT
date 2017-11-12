using PAT.Abstractions;
using PAT.Models;

namespace PAT.Tests.IocMock
{
    public static class IocContainerMock
    {
        //public static IPayrollCalculator GetBenefitsCalculator()
        //{
        //    return new BenefitsCalculator();
        //}

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