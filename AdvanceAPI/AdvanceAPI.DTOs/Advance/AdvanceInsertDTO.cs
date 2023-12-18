using System;

namespace AdvanceAPI.DTOs.Advance
{
    public record AdvanceInsertDTO
    {
        public decimal? AdvanceAmount { get; set; }
        public string AdvanceDescription { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? DesiredDate { get; set; }
        public int? EmployeeId { get; set; }
    }
}
