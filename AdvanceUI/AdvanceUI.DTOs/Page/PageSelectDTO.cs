using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.DTOs.Page
{
    public record PageSelectDTO
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Path { get; set; }
		public string Icon { get; set; }
	}
}
