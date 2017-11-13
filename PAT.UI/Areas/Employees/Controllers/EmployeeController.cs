using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PAT.UI.Areas.Employees.Models;

namespace PAT.UI.Areas.Employees.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AddEmployee()
        {
            var model = new AddEmployeeViewModel();
            return PartialView(model);
        }
    }
}