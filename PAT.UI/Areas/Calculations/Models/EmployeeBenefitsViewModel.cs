using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAT.UI.Areas.Calculations.Models
{
    public class EmployeeBenefitsViewModel
    {
        [DisplayName("EmployeeLogic ID")]
        [Required]
        [Range(0,50000, ErrorMessage = "Please enter valid EmployeeLogic ID")]
        public int EmployeeId { get; set; }
    }
}