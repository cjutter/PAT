using System.Linq;
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
                //var person = new Person()
                //{
                //    FirstName = "John",
                //    LastName = "Doe"

                //};
                //db.Persons.Add(person);

                var person = db.Persons.FirstOrDefault();

                var emp = new Employee
                {
                    EmpId = 0,
                    Person = person
                };

                var relation = new EmployeeRelationship()
                {
                    Employee = emp,
                    Person = person,
                    RelationshipType = 0
                };

                db.Employees.Add(emp);
                db.EmployeeRelationships.Add(relation);

                db.SaveChanges();
            }

        }
    }
}
