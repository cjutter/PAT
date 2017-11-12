using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAT.Entities
{
    public class EmployeeRelationship
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        [Required]
        public int RelationshipType { get; set; }

        public virtual Person Person { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
