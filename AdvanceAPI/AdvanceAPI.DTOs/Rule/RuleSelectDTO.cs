using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DTOs.Rule
{
    public record RuleSelectDTO
    {
        public int Id { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? MinAmount { get; set; }
        public DateTime? Date { get; set; }
        public int? TitleId { get; set; }
    }
}
