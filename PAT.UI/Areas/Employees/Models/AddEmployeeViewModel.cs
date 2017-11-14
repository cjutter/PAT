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

        [DisplayName("Bi-Weekly Wage")]
        [Required(ErrorMessage = "Please enter wage")]
        [Range(1, 999999999.99, ErrorMessage = "Please valid wage between 1 - 999999999.99")]
        public Decimal BiWeeklyWage { get; set; }

        [DisplayName("Has Dependents")]
        public bool HasDependents { get; set; }

        public int EmployeeId { get; set; }

    }
}