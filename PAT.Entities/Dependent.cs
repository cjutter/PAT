using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAT.Entities
{
    public class Dependent
    {
        [Required, Key]
        public int DependantId { get; set; }

        [Required]
        [Microsoft.Build.Framework.Required]
        public string FirstName { get; set; }
        
        [Required]
        [Microsoft.Build.Framework.Required]
        public string LastName { get; set; }

        [Required]
        public bool IsSpouse { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
