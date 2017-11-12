using PAT.Database;
using PAT.Entities;

namespace PAT.Tests.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new PATDbContext())
            {
                var person = new Person()
                {
                    FirstName = "John",
                    LastName = "Doe"

                };
                db.Persons.Add(person);
                db.SaveChanges();
            }

        }
    }
}
