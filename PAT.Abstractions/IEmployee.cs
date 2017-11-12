using System.Collections.Generic;

namespace PAT.Abstractions
{
    public interface IEmployee
    {
        int EmpId { get; set; }
        IPerson Employee { get; set; }
        List<IPerson> Dependants { get; set; }
        IPerson Spouse { get; set; }
        bool HasSpouse { get; set; }
        bool HasDependants { get; set; }
    }
}