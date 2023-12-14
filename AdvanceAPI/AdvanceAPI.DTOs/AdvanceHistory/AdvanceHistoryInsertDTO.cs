using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DTOs.AdvanceHistory
{
    public record AdvanceHistoryInsertDTO
    {
        public int? StatusId { get; set; }
        public int? AdvanceId { get; set; }
        public int? TransactorId { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public DateTime? Date { get; set; }
    }
}
