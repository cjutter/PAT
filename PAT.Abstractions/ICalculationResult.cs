namespace PAT.Abstractions
{
    public interface ICalculationResult
    {
        decimal EmployeeYearlyGrossPay { get; set; }
        decimal EmployeeBiWeeklyPay { get; set; }
        decimal EmployeeGrossPayAfterBenefitsDeduction { get; set; }
    }
}