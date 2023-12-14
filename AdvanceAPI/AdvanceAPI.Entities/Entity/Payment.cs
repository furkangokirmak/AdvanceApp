using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Entities.Entity
{
    public class Payment : BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DeterminedPaymentDate { get; set; }
        public int? FinanceManagerId { get; set; }
        public int? AdvanceId { get; set; }

        public virtual Employee FinanceManager { get; set; }
        public virtual Advance Advance { get; set; }
    }
}
