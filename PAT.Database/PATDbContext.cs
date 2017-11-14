using System.Data.Entity;
using PAT.Entities;


namespace PAT.Database
{
    public class PATDbContext :DbContext
    {
        public PATDbContext() :base("name=PATDBConnectionString")
        {
            //todo: remove hack and either set nav properties or redo context lifetime
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { get; set; }
      
        public DbSet<Dependent> Dependents { get; set; }
    }

}
