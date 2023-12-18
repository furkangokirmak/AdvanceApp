using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class Page : BaseEntity
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<TitleAuthorization> TitleAuthorizations { get; set; }
    }
}
