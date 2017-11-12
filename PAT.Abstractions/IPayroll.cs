namespace PAT.Abstractions
{
    public interface IPayroll
    {
        decimal GetEmployeeGrossPay(IEmployee employee);
    }
}