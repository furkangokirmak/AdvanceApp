using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int? PaymentId { get; set; }
        public DateTime? RequestDate { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<AdvanceHistory> AdvanceHistories { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
