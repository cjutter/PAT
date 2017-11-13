using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAT.Database;
using PAT.Entities;

namespace PAT.Models
{
    public class WagesLogic
    {
        private Wage _wage;

        public WagesLogic(int wageId)
        {
            using (var db = new PATDbContext())
            {
                _wage = db.Wages.FirstOrDefault(w => w.EmployeeId == wageId);
            }
        }
    }
}
