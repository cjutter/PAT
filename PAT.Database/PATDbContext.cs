using System.Data.Entity;
using PAT.Entities;


namespace PAT.Database
{
    public class PATDbContext :DbContext
    {
        public PATDbContext() :base("name=PATDBConnectionString")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Wage> Wages { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
    }

}
