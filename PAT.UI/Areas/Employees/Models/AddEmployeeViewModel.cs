using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PAT.Entities;

namespace PAT.UI.Areas.Employees.Models
{
    public class AddEmployeeViewModel
    {
        [DisplayName("First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter last name")]
        public string LastName { get;set; }

        public List<Dependent> Dependants { get; set; }
        public Wage BiWeeklyWage { get; set; }

        [DisplayName("Employee ID")]
        [Range(typeof(int), "0", "10000",ErrorMessage = "Please enter a number between 1-10000")]
        [Required(ErrorMessage = "Please enter an employee Id")]
        public int EmployeeID { get; set; }
    
    }
}