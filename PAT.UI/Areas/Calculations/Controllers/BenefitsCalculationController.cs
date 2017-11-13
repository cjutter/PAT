using PAT.Models;
using PAT.UI.Areas.Calculations.Models;
using System.Web.Mvc;

namespace PAT.UI.Areas.Calculations.Controllers
{
    public class BenefitsCalculationController : Controller
    {
        // GET: Calculations/BenefitsCalculation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculationResult(int employeeId)
        {
            var model = new CalculationResultViewModel();
            var employee = new EmployeeLogic(employeeId);
            model.EmployeeName = employee.FullName;
            return PartialView(model);
        }
    }
}