using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class Title : BaseEntity
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public string TitleDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Rule> Rules { get; set; }
        public virtual ICollection<TitleAuthorization> TitleAuthorizations { get; set; }
    }
}
