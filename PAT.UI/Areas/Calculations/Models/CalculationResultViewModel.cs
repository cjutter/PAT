using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PAT.UI.Areas.Calculations.Models
{
    public class CalculationResultViewModel
    {
        public string EmployeeName { get; set; }
        public decimal YearlyPay { get; set; }
        [DisplayName("Gross Pay After Deductions")]
        public decimal EmployeeGrossPayAfterBenefitsDeduction { get; set; }
    }
}