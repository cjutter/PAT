using PAT.Abstractions;
using PAT.Models;
using PAT.Models.Employee;
using PAT.Models.Payroll;

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
            return new EmployeeLogic(empId);
        }

        public static IPayroll GetPayroll()
        {
            return new Payroll();
        }
    }
}