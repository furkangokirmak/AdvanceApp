using System;
using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class Advance : BaseEntity
    {
        public int Id { get; set; }
        public decimal? AdvanceAmount { get; set; }
        public string AdvanceDescription { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? DesiredDate { get; set; }
        public int? StatusId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? RequestDate { get; set; }

		public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<AdvanceHistory> AdvanceHistories { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
