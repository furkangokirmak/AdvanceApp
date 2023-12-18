using System;

namespace AdvanceUI.DTOs.Payment
{
    public record PaymentSelectDTO
    {
        public int Id { get; set; }
        public DateTime? DeterminedPaymentDate { get; set; }
        public int? FinanceManagerId { get; set; }
        public int? AdvanceId { get; set; }
    }
}
