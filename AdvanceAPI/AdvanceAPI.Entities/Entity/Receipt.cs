using System;

namespace AdvanceAPI.Entities.Entity
{
    public class Receipt : BaseEntity
    {
        public int Id { get; set; }
        public string ReceiptNo { get; set; }
        public bool? IsRefundReceipt { get; set; }
        public int? AdvanceId { get; set; }
        public DateTime? Date { get; set; }
        public int? AccountantId { get; set; }

        public virtual Employee Accountant { get; set; }
        public virtual Advance Advance { get; set; }
    }
}
