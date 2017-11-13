using System;
using System.Collections.Generic;
using System.Linq;
using PAT.Abstractions;
using PAT.Database;
using PAT.Entities;

namespace PAT.Models
{
    public class EmployeeLogic 
    {
        private Entities.Employee _employee;

        public EmployeeLogic(int? empId)
        {
            if (empId.HasValue)
            {
                using (var db = new PATDbContext())
                {
                    _employee = db.Employees.FirstOrDefault(e => e.EmployeeId == empId);
                }
            }
            else
            {
                _employee = new Employee();
            }
           
        }

        public List<Dependent> Dependants
        {
            get
            {
                return _employee.Dependants;
            }

            set { _employee.Dependants = value; }
        }

        public string FirstName
        {
            get { return _employee.FirstName; }

            set { _employee.FirstName = value; }
        }
        public string FullName => FirstName + " " + LastName;

        public bool HasDependants => _employee.Dependants.Any();

        public bool HasSpouse =>  _employee.Dependants.Any(s => s.IsSpouse); 
        
        public string LastName
        {
            get { return _employee.LastName; }

            set { _employee.LastName = value; }
        }

        public Dependent Spouse => _employee.Dependants.FirstOrDefault(s => s.IsSpouse);

        public int EmpId => _employee.EmployeeId;

        public decimal BiWeeklyWage
        {
            set
            {
                if (_employee.Wage != null)
                {
                    _employee.Wage.BiWeeklyWage = value;
                }
                else
                {
                    _employee.Wage = new Wage()
                    {
                        BiWeeklyWage = value,
                        EmployeeId = _employee.EmployeeId
                    };
                }
               
            }
        }

        public void Persist()
        {
            using (var db = new PATDbContext())
            {
                db.Employees.Add(_employee);
                db.SaveChanges();
            }
        }
    }
}