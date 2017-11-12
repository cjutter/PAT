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
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }

        [Microsoft.Build.Framework.Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    
    }
}
