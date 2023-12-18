using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class BusinessUnit : BaseEntity
    {
        public int Id { get; set; }
        public string BusinessUnitName { get; set; }
        public string BusinessUnitDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
