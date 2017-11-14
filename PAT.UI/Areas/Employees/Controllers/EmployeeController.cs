using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PAT.Models;
using PAT.UI.Areas.Employees.Models;

namespace PAT.UI.Areas.Employees.Controllers
{
    public class EmployeeController : Controller
    {
        
        public ActionResult AddEmployee()
        {
            var model = new AddEmployeeViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult PersistEmployee(AddEmployeeViewModel emp)
        {
            var employee = new EmployeeLogic(null)
            {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                BiWeeklyWage = emp.BiWeeklyWage
            };

            emp.EmployeeId = employee.Persist();

            if (emp.HasDependents)
            {
                var dvm = new AddDependentViewModel(emp.EmployeeId);

                return View("AddDependents", dvm);
            }
            else
            {
                return View("EmployeeAdded", emp);
            }
        }

        [HttpPost]
        public ActionResult PersistDependents(AddEmployeeViewModel emp)
        {
          throw new NotImplementedException();
        }

    }
}