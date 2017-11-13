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

        public ActionResult PersistEmployee(AddEmployeeViewModel model)
        {
            var employee = new EmployeeLogic(null);
            //model.EmployeeName = employee.FullName;
            return PartialView("AddDependents",model);
        }
    }
}