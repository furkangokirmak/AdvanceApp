using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class Authorization : BaseEntity
    {
        public int AuthorizationId { get; set; }
        public string AuthroizationName { get; set; }

        public virtual ICollection<TitleAuthorization> TitleAuthorizations { get; set; }
    }
}
