using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Entities.Entity
{
    public class Authorization : BaseEntity
    {
        public int AuthorizationId { get; set; }
        public string AuthroizationName { get; set; }

        public virtual ICollection<TitleAuthorization> TitleAuthorizations { get; set; }
    }
}
