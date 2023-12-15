using AdvanceUI.DTOs.AdvanceHistory;
using AdvanceUI.DTOs.Employee;
using AdvanceUI.DTOs.Payment;
using AdvanceUI.DTOs.Project;
using AdvanceUI.DTOs.Receipt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.DTOs.Advance
{
    public record AdvanceSelectDTO
    {
        public int Id { get; set; }
        public decimal? AdvanceAmount { get; set; }
        public string AdvanceDescription { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? DesiredDate { get; set; }
        public int? StatusId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? RequestDate { get; set; }

        public virtual EmployeeSelectDTO Employee { get; set; }
        public virtual StatusSelectDTO Status { get; set; }
        public virtual ProjectSelectDTO Project { get; set; }

        public virtual ICollection<AdvanceHistorySelectDTO> AdvanceHistories { get; set; }
        public virtual ICollection<ReceiptSelectDTO> Receipts { get; set; }
        public virtual ICollection<PaymentSelectDTO> Payments { get; set; }
    }
}
