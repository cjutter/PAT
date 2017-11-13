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
      
        public DbSet<Dependent> Dependents { get; set; }
    }

}
