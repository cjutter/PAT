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
            var empLogic = new EmployeeLogic(employeeId);
            var result = empLogic.GetBenefitsCalcResult();
            model.EmployeeGrossPayAfterBenefitsDeduction = result.Result;
            model.EmployeeName = empLogic.FullName;
            model.YearlyPay = empLogic.YearlyPay;
            return PartialView(model);
        }

       
    }
}