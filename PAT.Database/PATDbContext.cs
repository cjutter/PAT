using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAT.Models.Employee;
using PAT.Models.Payroll;

namespace PAT.Database
{
    public class PATDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
    }
 
}
