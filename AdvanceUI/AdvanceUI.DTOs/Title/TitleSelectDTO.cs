using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.DTOs.Title
{
    public record TitleSelectDTO
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public string TitleDescription { get; set; }
    }
}
