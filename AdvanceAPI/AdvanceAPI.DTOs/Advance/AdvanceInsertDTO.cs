using AdvanceAPI.DTOs.AdvanceHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DTOs.Advance
{
    public class AdvanceInsertDTO
    {
        public decimal? AdvanceAmount { get; set; }
        public string AdvanceDescription { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? DesiredDate { get; set; }
        public int? StatusId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? RequestDate { get; set; }
        public virtual ICollection<AdvanceHistoryInsertDTO> AdvanceHistories { get; set; }
    }
}
