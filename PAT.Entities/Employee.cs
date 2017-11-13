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

        [Microsoft.Build.Framework.Required]
        public string FirstName { get; set; }

        [Microsoft.Build.Framework.Required]
        public string LastName { get; set; }

        
        public virtual Wage Wage { get; set; }

        [ForeignKey("Dependants")]
        public int? DependantId { get; set; }
        public virtual List<Dependent> Dependants { get; set; }

        //Next iteration
        //public DateTime HireDate { get; set; }
        //public bool IsActive { get; set; }
        //Address etc...

      

      
    
    }
}
