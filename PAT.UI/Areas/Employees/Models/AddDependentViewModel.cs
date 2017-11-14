using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAT.UI.Areas.Employees.Models
{
    public class AddDependentViewModel
    {

        public AddDependentViewModel(int employeeId)
        {
            EmployeeId = employeeId;
        }
        public int EmployeeId { get; }

        [DisplayName("First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        [DisplayName("Spouse")]
        public bool IsSpouse { get; set; }
    }
}