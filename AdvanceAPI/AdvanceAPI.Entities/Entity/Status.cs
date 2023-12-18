using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class Status : BaseEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<AdvanceHistory> AdvanceHistories { get; set; }
        public virtual ICollection<Advance> Advances { get; set; }
    }
}
