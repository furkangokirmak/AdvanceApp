﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.Entities.Entity
{
    public class Status : BaseEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<AdvanceHistory> AdvanceHistories { get; set; }
        public virtual ICollection<Advance> Advances { get; set; }
    }
}
