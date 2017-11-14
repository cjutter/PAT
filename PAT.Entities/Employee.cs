using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAT.Entities
{
    public class Employee
    {
        [Required, Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(1, 9999999999, ErrorMessage = "Can only be between 1 .. 9999999999")]
        public decimal BiWeeklyWage { get; set; }

        public virtual List<Dependent> Dependants { get; set; }

      


        //Next iteration
        //public DateTime HireDate { get; set; }
        //public bool IsActive { get; set; }
        //Address etc...





    }
}
