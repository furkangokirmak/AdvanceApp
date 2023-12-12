using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Entities.Entity
{
    public class Page : BaseEntity
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Path { get; set; }

        public virtual ICollection<TitleAuthorization> TitleAuthorizations { get; set; }
    }
}
