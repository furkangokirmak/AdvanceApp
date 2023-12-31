﻿using System;

namespace AdvanceUI.DTOs.Receipt
{
    public record ReceiptSelectDTO
    {
        public int Id { get; set; }
        public string ReceiptNo { get; set; }
        public bool? IsRefundReceipt { get; set; }
        public int? AdvanceId { get; set; }
        public DateTime? Date { get; set; }
        public int? AccountantId { get; set; }
    }
}
