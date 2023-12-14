using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DTOs.Status
{
    public record StatusSelectDTO
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
}
