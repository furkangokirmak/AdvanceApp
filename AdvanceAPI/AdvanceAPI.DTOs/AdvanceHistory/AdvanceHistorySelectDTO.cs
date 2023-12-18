﻿using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.DTOs.Status;
using System;

namespace AdvanceAPI.DTOs.AdvanceHistory
{
    public record AdvanceHistorySelectDTO
    {
        public int Id { get; set; }
        public int? StatusId { get; set; }
        public int? AdvanceId { get; set; }
        public int? TransactorId { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public DateTime? Date { get; set; }

        public virtual AdvanceSelectDTO Advance { get; set; }
        public virtual StatusSelectDTO Status { get; set; }
        public virtual EmployeeSelectDTO Transactor { get; set; }
    }
}
