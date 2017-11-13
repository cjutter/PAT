using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAT.Entities
{
   public class Wage
    {
        [Key, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
      
        [Required]
        public virtual Employee Employee { get; set; }

        [Required]
        public decimal BiWeeklyWage { get; set; }
    }
}
