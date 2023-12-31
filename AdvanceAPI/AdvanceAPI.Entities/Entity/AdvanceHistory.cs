﻿using System;

namespace AdvanceAPI.Entities.Entity
{
    public class AdvanceHistory : BaseEntity
    {
        public int Id { get; set; }
        public int? StatusId { get; set; }
        public int? AdvanceId { get; set; }
        public int? TransactorId { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public DateTime? Date { get; set; }
        public bool isDone { get; set; }

        public virtual Advance Advance { get; set; }
        public virtual Status Status { get; set; }
        public virtual Employee Transactor { get; set; }
    }
}
