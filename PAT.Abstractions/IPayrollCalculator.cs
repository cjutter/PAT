namespace PAT.Abstractions
{
    public interface IPayrollCalculator
    {
        /// <summary>
        /// Calculate employee yearly pay after cost of benefits and before addtional deductions. 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        ICalculationResult CalculateEmployeeGrossPayAfterBenefitsDeduction(IEmployee employee);

    }
}