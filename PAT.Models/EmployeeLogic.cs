using System;
using System.Collections.Generic;
using System.Linq;
using PAT.Abstractions;
using PAT.Calculators;
using PAT.Database;
using PAT.Entities;

namespace PAT.Models
{
    public class EmployeeLogic 
    {
        private Entities.Employee _employee;
        private List<Dependent> _dependents;

        public EmployeeLogic(int? empId)
        {
            _dependents = new List<Dependent>();
            if (empId.HasValue)
            {
                using (var db = new PATDbContext())
                {
                    _employee = db.Employees.FirstOrDefault(e => e.EmployeeId == empId);
                    _employee.Dependants = db.Dependents.Where(d => d.EmployeeId == empId).ToList();
                }
            }
            else
            {
                _employee = new Employee();
            }
            
        }

        public void AddDependent(string firstName,string lastName,bool isSpouse)
        {
            var dependent = new Dependent
            {
                LastName = lastName,
                FirstName = firstName,
                IsSpouse = isSpouse,
                EmployeeId = _employee.EmployeeId
            };
            _dependents.Add(dependent);
            
        }
        
        public string FirstName
        {
            get { return _employee.FirstName; }

            set { _employee.FirstName = value; }
        }
        public string FullName => FirstName + " " + LastName;

        public string LastName
        {
            get { return _employee.LastName; }

            set { _employee.LastName = value; }
        }

        public decimal BiWeeklyWage
        {
            set { _employee.BiWeeklyWage = value; }
        }

        public decimal YearlyPay => _employee.BiWeeklyWage * 26;

        public int Persist()
        {
            using (var db = new PATDbContext())
            {
                db.Employees.Add(_employee);
                db.SaveChanges();
            }
            return _employee.EmployeeId;
        }

        public void PersistDependents()
        {
            using (var db = new PATDbContext())
            {
                db.Dependents.AddRange(_dependents);
                db.SaveChanges();
            }
        }

        public ICalculationResult GetBenefitsCalcResult()
        {
            var calc = new BenefitsCalculator();
            return calc.CalculateEmployeeGrossPayAfterBenefitsDeduction(_employee);
        }
    }
}