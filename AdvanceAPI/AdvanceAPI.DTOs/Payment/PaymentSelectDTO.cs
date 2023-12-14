﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DTOs.Payment
{
    public record PaymentSelectDTO
    {
        public int Id { get; set; }
        public DateTime? DeterminedPaymentDate { get; set; }
        public int? FinanceManagerId { get; set; }
        public int? AdvanceId { get; set; }
    }
}
