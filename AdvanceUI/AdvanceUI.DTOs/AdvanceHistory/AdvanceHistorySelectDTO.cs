using AdvanceUI.DTOs.Advance;
using AdvanceUI.DTOs.Employee;
using AdvanceUI.DTOs.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.DTOs.AdvanceHistory
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
