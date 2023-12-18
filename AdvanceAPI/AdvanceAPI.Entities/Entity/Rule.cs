using System;

namespace AdvanceAPI.Entities.Entity
{
    public class Rule : BaseEntity
    {
        public int Id { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? MinAmount { get; set; }
        public DateTime? Date { get; set; }
        public int? TitleId { get; set; }

        public virtual Title Title { get; set; }
    }
}
