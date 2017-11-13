using System.Web.Mvc;

namespace PAT.UI.Areas.Employees
{
    public class EmployeesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Employees";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Employees_default",
                "Employees/{controller}/{action}/{id}",
                new { action = "AddEmployee", id = UrlParameter.Optional }
            );
        }
    }
}