using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAT.Database;
using PAT.Models.Employee;

namespace PAT.Tests.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PATDbContext context = new PATDbContext();
            var employee = new Employee(123);
            context.Employees.Add(employee);

        }
    }
}
