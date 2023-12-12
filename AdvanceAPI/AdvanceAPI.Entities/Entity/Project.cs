using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Entities.Entity
{
    public class Project : BaseEntity
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartingDate { get; set; }

        public virtual ICollection<Advance> Advances { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
