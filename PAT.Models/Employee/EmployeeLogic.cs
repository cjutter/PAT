using System;
using System.Collections.Generic;
using System.Linq;
using PAT.Abstractions;
using PAT.Database;

namespace PAT.Models.Employee
{
    public class EmployeeLogic : IEmployee, IPerson
    {
        private int _empId;
        private Entities.Employee _employee;

        public EmployeeLogic(int empId)
        {
            _empId = empId;
            using (var db = new PATDbContext())
            {
                _employee = db.Employees.FirstOrDefault(e => e.EmpId == empId);
            }
        }

        public List<IPerson> Dependants
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string FullName => FirstName + " " + LastName;

        public bool HasDependants
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasSpouse
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string LastName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IPerson Spouse
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int EmpId { get; set; }

        IPerson IEmployee.Employee
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}