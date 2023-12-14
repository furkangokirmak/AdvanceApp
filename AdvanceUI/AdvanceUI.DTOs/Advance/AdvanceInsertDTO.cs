using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.DTOs.Advance
{
    public class AdvanceInsertDTO
    {
        public decimal? AdvanceAmount { get; set; }
        public string AdvanceDescription { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? DesiredDate { get; set; }
        public int? EmployeeId { get; set; }
    }
}
